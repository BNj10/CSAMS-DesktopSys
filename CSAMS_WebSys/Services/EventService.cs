using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using CSAMS_WebSys.Models;
using CSAMS_WebSys.Services;
using System.Windows.Forms;
using System.CodeDom;
using CSAMS_WebSys.Services.Dashboard;
using CSAMS_WebSys.Models.enums;
using System.Diagnostics.Metrics;

namespace CSAMS_WebSys.Services
{
    public class EventService
    {
        private FirestoreDb db;

        public EventService()
        {
            db = FirebaseConnectionService.GetConnection();
        }

        public async Task SaveEvent(EventModel eventModel, AttendanceModel attendance, PresentModel present)
        {
            try
            {
                var EventData = new Dictionary<string, object>
                {
                    { "EventName", eventModel.EventName },
                    { "DateAdded", eventModel.DateAdded },
                    { "DateStart", eventModel.DateStart },
                    { "DateEnd", eventModel.DateEnd },
                    { "isArchived", eventModel.IsArchived },
                };

                    DocumentReference eventDocRef = db.Collection("Event").Document();

                    string eventId = eventDocRef.Id;

                    await eventDocRef.SetAsync(EventData);

                    var AttendanceData = new Dictionary<string, object>
                    {
                        { "EventName", attendance.EventName },
                        { "SchoolYearID", attendance.SchoolYearID },
                        { "DateStart", attendance.DateStart },
                        { "TotalAttendees", attendance.TotalAttendees },
                        { "TimeInStart", attendance.TimeInStart },
                        { "TimeInEnd", attendance.TimeInEnd },
                        { "TimeOutEnd", attendance.TimeOutEnd },
                        { "TimeOutStart", attendance.TimeOutStart }
                    };

                    DocumentReference attendanceDocRef = db.Collection("Attendance").Document();

                await attendanceDocRef.SetAsync(AttendanceData);

                CollectionReference presentSubCollectionRef = attendanceDocRef.Collection("Present");

                MessageBox.Show($"Event and attendance added successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving event to Firestore: {ex.Message}");
            }
        }

        public async Task<EventModel> GetEventByName(EventModel Event)
        {
            Query query = db.Collection("Event").WhereEqualTo("EventName", Event.EventName);
            QuerySnapshot querySnapshot = await query.GetSnapshotAsync();

            if (querySnapshot.Documents.Count == 0)
            {
                MessageBox.Show("No event found with the specified name.");
                return null;
            }

            DocumentSnapshot document = querySnapshot.Documents[0];
            EventModel eventModel = new EventModel
            {
                EventID = document.Id,
                EventName = document.ContainsField("EventName") ? document.GetValue<string>("EventName") : null,
                DateStart = document.ContainsField("DateStart") ? document.GetValue<DateTime?>("DateStart") : null,
                DateEnd = document.ContainsField("DateEnd") ? document.GetValue<DateTime?>("DateEnd") : null,
                DateAdded = document.ContainsField("DateAdded") ? document.GetValue<DateTime?>("DateAdded") : null,
                IsArchived = document.ContainsField("isArchived") ? document.GetValue<bool>("isArchived") : false
            };
            return eventModel;
        }

        private async Task<List<EventModel>> GetAllEventsAsync()
        {
            var eventsCollection = db.Collection("Event");
            var eventsSnapshot = await eventsCollection.GetSnapshotAsync();
            var eventModels = new List<EventModel>();

            foreach (var document in eventsSnapshot.Documents)
            {
                var eventModel = new EventModel
                {
                    EventID = document.Id,
                    EventName = document.ContainsField("EventName") ? document.GetValue<string>("EventName") : null,
                    DateStart = document.ContainsField("DateStart") ? document.GetValue<DateTime?>("DateStart") : null,
                    DateEnd = document.ContainsField("DateEnd") ? document.GetValue<DateTime?>("DateEnd") : null,
                    DateAdded = document.ContainsField("DateAdded") ? document.GetValue<DateTime?>("DateAdded") : null,
                    IsArchived = document.ContainsField("isArchived") ? document.GetValue<bool>("isArchived") : false
                };
                eventModel.Status = GetCurrentStatus(eventModel);
                eventModels.Add(eventModel);
            }
            return eventModels;
        }

        public async Task<List<string>> GetAttendedEventIdsAsync(string studentId)
        {
            var attendanceCollection = db.Collection("Attendance");
            var attendanceSnapshot = await attendanceCollection.GetSnapshotAsync();
            var attendedEventNames = new List<string>();

            foreach (var attendanceDoc in attendanceSnapshot.Documents)
            {

                if (string.IsNullOrEmpty(attendanceDoc.Id))
                {
                    Console.WriteLine("Invalid AttendanceID found, skipping...");
                    continue;
                }

                var attendanceModel = new AttendanceModel
                {
                    AttendanceID = attendanceDoc.Id,
                    EventName = attendanceDoc.ContainsField("EventName") ? attendanceDoc.GetValue<string>("EventName") : null,
                };

                var presentSubCollectionPath = attendanceModel.PresentSubCollectionPath;
 
                try
                {
                    var presentSubCollection = db.Collection(presentSubCollectionPath);

                    Query query = presentSubCollection.WhereEqualTo("StudentID", studentId);
                    var studentSnapshot = await query.GetSnapshotAsync();

                    if (studentSnapshot.Documents.Count > 0)
                    {
                        attendedEventNames.Add(attendanceModel.EventName);
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error accessing sub-collection for EventID: {attendanceModel.AttendanceID}. Error: {ex.Message}");
                }
            }

            foreach (var name in attendedEventNames)
            {
                Console.WriteLine($"Attended Event ID: {name}");
            }

            return attendedEventNames;
        }


        public async Task<List<EventModel>> GetMissedEventsAsync(string studentId)
        {
            var allEvents = await GetAllEventsAsync();
            var attendedEventNames = await GetAttendedEventIdsAsync(studentId);

            if (allEvents == null || !allEvents.Any())
            {
                Console.WriteLine("No events found.");
                return new List<EventModel>();
            }

            if (attendedEventNames == null || !attendedEventNames.Any())
            {
                return allEvents; 
            }

            var missedEvents = allEvents
                          .Where(e => !attendedEventNames.Contains(e.EventName, StringComparer.OrdinalIgnoreCase))
                          .ToList();

            return missedEvents;
        }
        public async Task<(List<EventModel>, DocumentSnapshot)> GetAllEvents(int pageSize, DocumentSnapshot lastVisible)
        {
            int page = pageSize;
            try
            {
                Console.WriteLine($"{page} - {lastVisible}");

                Query query = db.Collection("Event").Select("EventName", "DateStart", "DateEnd", "DateAdded", "isArchived")
                                                    .Limit(page);

                if (lastVisible != null)
                {
                    Console.WriteLine($"Last Visible Document ID: {lastVisible.Id}");
                    query = query.StartAfter(lastVisible);
                }

                QuerySnapshot querySnapshot = await query.GetSnapshotAsync();
                if (querySnapshot.Documents.Count == 0)
                {
                    Console.WriteLine("No more data to fetch");
                    return (new List<EventModel>(), null);
                }

                List<EventModel> Events = new List<EventModel>();

                foreach (DocumentSnapshot document in querySnapshot.Documents)
                {
                    if (document.Exists)
                    {
                        var eventModel = new EventModel
                        {
                            EventName = document.ContainsField("EventName") ? document.GetValue<string>("EventName") : null,
                            DateStart = document.ContainsField("DateStart") ? document.GetValue<DateTime?>("DateStart") : null,
                            DateEnd = document.ContainsField("DateEnd") ? document.GetValue<DateTime?>("DateEnd") : null,
                            DateAdded = document.ContainsField("DateAdded") ? document.GetValue<DateTime?>("DateAdded") : null,
                            IsArchived = document.ContainsField("isArchived") ? document.GetValue<bool>("isArchived") : false
                        };
                        eventModel.Status = GetCurrentStatus(eventModel);
                        Events.Add(eventModel);
                    }
                }
                DocumentSnapshot lastDoc = querySnapshot.Documents.Count > 0 ? querySnapshot.Documents[querySnapshot.Documents.Count - 1] : null;
                return (Events, lastDoc);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving active members with pagination.", ex);
            }
        }

        public async Task<(List<EventModel>, DocumentSnapshot)> GetArchivedEvents(int pageSize, DocumentSnapshot lastVisible)
        {
            try
            { 
                Query query = db.Collection("Event").WhereEqualTo("isArchived", true)
                                                    .Select("EventName", "DateStart", "DateEnd", "DateAdded", "isArchived")
                                                    .Limit(pageSize);
                if (lastVisible != null)
                {
                    Console.WriteLine($"Last Visible Document ID: {lastVisible.Id}");
                    query = query.StartAfter(lastVisible);
                }

                QuerySnapshot querySnapshot = await query.GetSnapshotAsync();
                if (querySnapshot.Documents.Count == 0)
                {
                    Console.WriteLine("No more data to fetch");
                    return (new List<EventModel>(), null);
                }

                List<EventModel> Events = new List<EventModel>();

                foreach (DocumentSnapshot document in querySnapshot.Documents)
                {
                    if (document.Exists)
                    {
                        var eventModel = new EventModel
                        {
                            EventName = document.ContainsField("EventName") ? document.GetValue<string>("EventName") : null,
                            DateStart = document.ContainsField("DateStart") ? document.GetValue<DateTime?>("DateStart") : null,
                            DateEnd = document.ContainsField("DateEnd") ? document.GetValue<DateTime?>("DateEnd") : null,
                            DateAdded = document.ContainsField("DateAdded") ? document.GetValue<DateTime?>("DateAdded") : null,
                            IsArchived = document.ContainsField("isArchived") ? document.GetValue<bool>("isArchived") : false
                        };
                        eventModel.Status = GetCurrentStatus(eventModel);
                        Events.Add(eventModel);
                    }
                }
                DocumentSnapshot lastDoc = querySnapshot.Documents.Count > 0 ? querySnapshot.Documents[querySnapshot.Documents.Count - 1] : null;
                return (Events, lastDoc);
            }   
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving active members with pagination.", ex);
            }
        }
        public EventStatus GetCurrentStatus(EventModel eventData)
        {
            if (eventData.DateStart == null || eventData.DateEnd == null)
            {
                throw new ArgumentException("Event start and end dates cannot be null.");
            }
            DateTime CurrentDate = DateTime.Now;
            DateTime EventDateStart = eventData.DateStart.Value.ToLocalTime();
            DateTime EventDateEnd = eventData.DateEnd.Value.ToLocalTime();

            if(eventData.IsArchived)
            {
                return EventStatus.Archived;
            }

            if (CurrentDate >= EventDateStart && CurrentDate <= EventDateEnd)
            {
                return EventStatus.Ongoing;
            }
            else if (CurrentDate < EventDateStart)
            {
                return EventStatus.Pending;
            }
            else
            {
                return EventStatus.Done;
            }
        }

        public async Task ArchiveEvents(EventModel Event)
        {
            try
            {
                Query query = db.Collection("Event").WhereEqualTo("EventName", Event.EventName)
                                                   .WhereEqualTo("isArchived", false);
                QuerySnapshot querySnapshot = await query.GetSnapshotAsync();

                foreach (DocumentSnapshot document in querySnapshot.Documents)
                {
                    if (document.Exists)
                    {
                        DocumentReference docRef = document.Reference;
                        await docRef.UpdateAsync(new Dictionary<string, object>
                        {
                            { "isArchived", true }
                        });
                     }
                }
                MessageBox.Show("Event archived successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error archiving event: {ex.Message}");
            }
        }

        public async Task EditEventDetails(EventModel Event)
        {
            try
            {
                DocumentReference docRef = db.Collection("Event").Document(Event.EventID);
                DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

                if (!snapshot.Exists)
                {
                    Console.WriteLine("No event found!");
                    return;
                }

                var fieldsToUpdate = new[] { "EventName", "DateStart", "DateEnd"};

                var updatedFields = new Dictionary<string, object>
                {
                    { "EventName", Event.EventName },
                    { "DateStart", Event.DateStart },
                    { "DateEnd", Event.DateEnd }
                };

                await docRef.SetAsync(updatedFields, SetOptions.MergeFields(fieldsToUpdate));

                Console.WriteLine("Event updated successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating event: {ex.Message}");
            }
        }


        public async Task DeleteEvent(EventModel Event)
        {
            try
            {
                Query query = db.Collection("Event")
                            .WhereEqualTo("EventName", Event.EventName);

                QuerySnapshot snapshot = await query.GetSnapshotAsync();

                if (snapshot.Documents.Count == 0)
                {
                    MessageBox.Show("No event found with the specified name.");
                    return;
                }

                DocumentSnapshot document = snapshot.Documents[0];
                await document.Reference.DeleteAsync();

                Query query1 = db.Collection("Attendance").WhereEqualTo("EventName", Event.EventName);
                QuerySnapshot snapshot1 = await query1.GetSnapshotAsync();
                foreach (DocumentSnapshot doc in snapshot1.Documents)
                {
                    await doc.Reference.DeleteAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured when deleting events", ex.Message);
            } 
        }
    }
}