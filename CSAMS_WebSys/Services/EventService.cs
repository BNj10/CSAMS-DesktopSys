﻿using System;
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
                        { "TotalAttendees", attendance.TotalAttendees },
                        { "TimeInStart", attendance.TimeInStart },
                        { "TimeInEnd", attendance.TimeInEnd },
                        { "TimeOutEnd", attendance.TimeOutEnd },
                        { "TimeOutStart", attendance.TimeOutStart }
                    };

                    DocumentReference attendanceDocRef = db.Collection("Attendance").Document(eventId);

                await attendanceDocRef.SetAsync(AttendanceData);

                CollectionReference presentSubCollectionRef = attendanceDocRef.Collection("Present");

                MessageBox.Show($"Event and attendance added successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving event to Firestore: {ex.Message}");
            }
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
                    EventName = document.GetValue<string>("EventName"),
                    DateAdded = document.GetValue<DateTime?>("DateAdded").Value.ToLocalTime(),
                    DateStart = document.GetValue<DateTime?>("DateStart").Value.ToLocalTime(),
                    DateEnd = document.GetValue<DateTime?>("DateEnd").Value.ToLocalTime(),
                    IsArchived = document.GetValue<bool>("isArchived")
                };
                eventModels.Add(eventModel);
            }
            return eventModels;
        }

        public async Task<List<string>> GetAttendedEventIdsAsync(string studentId)
        {
            var attendanceCollection = db.Collection("Attendance");
            var attendanceSnapshot = await attendanceCollection.GetSnapshotAsync();
            var attendedEventIds = new List<string>();

            foreach (var attendanceDoc in attendanceSnapshot.Documents)
            {

                if (string.IsNullOrEmpty(attendanceDoc.Id))
                {
                    Console.WriteLine("Invalid EventID found, skipping...");
                    continue;
                }

                var attendanceModel = new AttendanceModel
                {
                    EventID = attendanceDoc.Id,
                };
                var presentSubCollectionPath = attendanceModel.PresentSubCollectionPath;

                try
                {
                    var presentSubCollection = db.Collection(presentSubCollectionPath);

                    var query = presentSubCollection.WhereEqualTo("StudentID", studentId);
                    var studentSnapshot = await query.GetSnapshotAsync();

                    if (studentSnapshot.Documents.Count > 0)
                    {
                        attendedEventIds.Add(attendanceModel.EventID);
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error accessing sub-collection for EventID: {attendanceModel.EventID}. Error: {ex.Message}");
                }
            }

            foreach (var id in attendedEventIds)
            {
                Console.WriteLine($"Attended Event ID: {id}");
            }

            return attendedEventIds;
        }


        public async Task<List<EventModel>> GetMissedEventsAsync(string studentId)
        {
            var allEvents = await GetAllEventsAsync();
            var attendedEventIds = await GetAttendedEventIdsAsync(studentId);

            foreach (var id in attendedEventIds)
            {
                Console.WriteLine(id);
            }

            if (allEvents == null || !allEvents.Any())
            {
                Console.WriteLine("No events found.");
                return new List<EventModel>();
            }

            if (attendedEventIds == null || !attendedEventIds.Any())
            {
                return allEvents; 
            }

            var missedEvents = allEvents
                            .Where(e => !attendedEventIds.Any(id => id.Equals(e.EventID, StringComparison.OrdinalIgnoreCase)))
                            .ToList();
            return missedEvents;
        }
/*        public async Task<int> GetNumberOfAttendees(EventModel Event)
        {
            Query query = db.Collection("Attendance").WhereEqualTo("EventID", Event.EventID);
        }*/

        public async Task<(List<EventModel>, DocumentSnapshot)> GetActiveEvents(int pageSize, DocumentSnapshot lastVisible)
        {
            int page = pageSize;
            try
            {
                Console.WriteLine($"{page} - {lastVisible}");

                Query query = db.Collection("Event").WhereEqualTo("isArchived", false)
                                                    .Select("EventName", "DateStart", "DateEnd", "DateAdded")
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
                            DateAdded = document.ContainsField("DateAdded") ? document.GetValue<DateTime?>("DateAdded") : null
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
                            DateAdded = document.ContainsField("DateAdded") ? document.GetValue<DateTime?>("DateAdded") : null
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
                Console.WriteLine("Event archived successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error archiving event: {ex.Message}");
            }
        }

        public async Task EditEventDetails(EventModel Event)
        {
            try
            {
                QuerySnapshot querySnapshot = await db.Collection("Event").WhereEqualTo("EventName", Event.EventName)
                                                   .WhereEqualTo("isArchived", false).GetSnapshotAsync();

                if (querySnapshot == null)
                {
                    Console.WriteLine("No event found!");
                    return;
                }

                DocumentReference docRef = querySnapshot.Documents[0].Reference;
                await docRef.SetAsync(Event, SetOptions.MergeAll);
            }
            catch(Exception ex)
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

                string id = document.Id;

                Query query1 = db.Collection("Attendance").WhereEqualTo(FieldPath.DocumentId, id);
                QuerySnapshot snapshot1 = await query1.GetSnapshotAsync();
                foreach (DocumentSnapshot doc in snapshot1.Documents)
                {
                    await doc.Reference.DeleteAsync();
                }
                MessageBox.Show("Event and its associated attendance deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured when deleting events", ex.Message);
            } 
        }
    }
}








/*        public class PaginationParameters
        {
            public string LastDocumentId { get; set; } = null;
            public int PageSize { get; set; } = 10;
        }*/

/*        private async Task GetAttendanceRecord(EventModel Event)
        {

        }*/

        /*public class PaginatedEventModel
        {
            public List<EventModel> Events { get; set; }
            public bool HasMore { get; set; }
            public string LastDocumentId { get; set; }
            public Dictionary<EventStatus, int> StatusCounts { get; set; }
        }

        public async Task<PaginatedEventModel> GetEventsWithInfiniteScroll(PaginationParameters pagination, string last)
        {
            TimeZoneInfo philippineTime = GetPhilippineTimeZone();
            var currentDateTime = TimeZoneInfo.ConvertTime(DateTime.UtcNow, philippineTime);

            try
            {
                var eventRef = db.Collection("Event");
                Query query = eventRef.OrderBy("DateStart").Limit(pagination.PageSize);

                if (!string.IsNullOrEmpty(pagination.LastDocumentId))
                {
                    var lastDoc = await eventRef.Document(pagination.LastDocumentId).GetSnapshotAsync();
                    query = query.StartAfter(lastDoc);
                }

                var snapshot = await query.GetSnapshotAsync();
                var events = new List<EventModel>();

                foreach (var document in snapshot.Documents)
                {
                    var data = document.ToDictionary();
                    var eventData = new EventModel
                    {
                        EventName = document.ContainsField("EventName") ? document.GetValue<string>("EventName") : null,
                        EventDescription = document.ContainsField("EventDescription") ? document.GetValue<string>("EventDescription") : null,
                        DateStart = document.ContainsField("DateStart") ? document.GetValue<DateTime?>("DateStart") : null,
                        DateEnd = document.ContainsField("DateEnd") ? document.GetValue<DateTime?>("DateEnd") : null
                    };

                    eventData.DateStart = TimeZoneInfo.ConvertTimeFromUtc((DateTime)eventData.DateStart, philippineTime);
                    eventData.DateEnd = TimeZoneInfo.ConvertTimeFromUtc((DateTime)eventData.DateEnd, philippineTime);

                    if (currentDateTime >= eventData.DateStart && currentDateTime <= eventData.DateEnd)
                    {
                        eventData.Status = EventStatus.Ongoing;
                    }
                    else if (currentDateTime < eventData.DateStart)
                    {
                        eventData.Status = EventStatus.Pending;
                    }
                    else
                    {
                        eventData.Status = EventStatus.Done;
                    }

                    events.Add(eventData);
                }

                var sortedEvents = events
                    .OrderBy(e => GetStatusOrder(e.Status))
                    .ThenBy(e => GetSecondarySort(e, currentDateTime))
                    .ToList();

                var statusCounts = new Dictionary<EventStatus, int>
                {
                    { EventStatus.Ongoing, events.Count(e => e.Status == EventStatus.Ongoing) },
                    { EventStatus.Pending, events.Count(e => e.Status == EventStatus.Pending) },
                    { EventStatus.Done, events.Count(e => e.Status == EventStatus.Done) }
                };

                return new PaginatedEventModel
                {
                    Events = sortedEvents,
                    HasMore = sortedEvents.Count == pagination.PageSize,
                    LastDocumentId = last,
                    StatusCounts = statusCounts
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving events: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new PaginatedEventModel
                {
                    Events = new List<EventModel>(),
                    HasMore = false,
                    LastDocumentId = null,
                    StatusCounts = new Dictionary<EventStatus, int>()
                };
            }
        }

        private TimeZoneInfo GetPhilippineTimeZone()
        {
            try
            {
                return TimeZoneInfo.FindSystemTimeZoneById("China Standard Time");
            }
            catch
            {
                try
                {
                    return TimeZoneInfo.FindSystemTimeZoneById("Asia/Manila");
                }
                catch
                {
                    return TimeZoneInfo.CreateCustomTimeZone(
                        "Philippine Time",
                        new TimeSpan(8, 0, 0),
                        "Philippine Time",
                        "Philippine Standard Time");
                }
            }
        }

        private int GetStatusOrder(EventStatus status)
        {
            switch (status)
            {
                case EventStatus.Ongoing:
                    return 0;
                case EventStatus.Pending:
                    return 1;
                case EventStatus.Done:
                    return 2;
                default:
                    return 3;
            }
        }

        private DateTime GetSecondarySort(EventModel evt, DateTime currentDateTime)
        {
            switch (evt.Status)
            {
                case EventStatus.Pending:
                    return (DateTime)evt.DateStart;
                case EventStatus.Ongoing:
                    return (DateTime)evt.DateEnd;
                case EventStatus.Done:
                    return (DateTime)(evt.DateEnd);
                default:
                    return DateTime.MaxValue;
            }
        }
    }
}

*/