using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSAMS_WebSys.Models;
using CSAMS_WebSys.Models.enums;
using CSAMS_WebSys.Services;
using Google.Cloud.Firestore;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace CSAMS_WebSys.Services
{
    public class AttendanceService
    {
        FirestoreDb db;
        MemberService memberservice;
        DocumentSnapshot firstDoc;
        public AttendanceService()
        {
            db = FirebaseConnectionService.GetConnection();
        }

/*        public async Task<List<MemberModel>> GetAbsentStudents(AttendanceModel attendance)
        {
            Query query = db.Collection("Member").WhereEqualTo("")
            memberservice = new MemberService();
            List<MemberModel> members = await
        }*/


        public async Task<string> GetEventID(string eventName)
        {

            Console.WriteLine($"Searching for EventName: {eventName}");

            QuerySnapshot querySnapshot = await db.Collection("Event")
                                                 .WhereEqualTo("EventName", eventName)
                                                 .GetSnapshotAsync();
            if (querySnapshot.Count > 0)
            {
                var doc = querySnapshot.Documents[0];
                Console.WriteLine($"Event found! Document ID: {doc.Id}");
                return doc.Id;
            }
            else
            {
                Console.WriteLine("Event not found.");
                return null;
            }
        }

        public async Task<List<MemberModel>> CurrentlyPresent(AttendanceModel attendance)
        {
            List<MemberModel> members = new List<MemberModel>();
            if(attendance == null)
            {
                Console.WriteLine("Attendance was null");
                return members;
            }
            string path = attendance.PresentSubCollectionPath;
            try
            {
                if (string.IsNullOrWhiteSpace(path))
                {
                    MessageBox.Show("Attendance path is invalid.");
                    return members;
                }

                CollectionReference collection = db.Collection(path);
                QuerySnapshot querySnapshot = await collection.GetSnapshotAsync();
                
                foreach (DocumentSnapshot document in querySnapshot.Documents)
                {
                    if (document.Exists)
                    {
                        MemberModel member = document.ConvertTo<MemberModel>();
                        members.Add(member);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving members: {ex.Message}");
            }

            return members;
        }
        public async Task<AttendanceModel> GetAttendanceForAnEvent(string EventName)
        {
            try
            {
                var eventId = await GetEventID(EventName);
                DocumentReference attendanceDocRef = db.Collection("Attendance").Document(eventId);

                DocumentSnapshot snapshot = await attendanceDocRef.GetSnapshotAsync();

                if (snapshot.Exists)
                {
                    var attendanceData = snapshot.ToDictionary();

                    var totalAttendees = attendanceData.ContainsKey("TotalAttendees") && attendanceData["TotalAttendees"] is long
                        ? Convert.ToInt32(attendanceData["TotalAttendees"])
                        : 0;
                    DateTime? timeInStart = attendanceData.ContainsKey("TimeInStart") && attendanceData["TimeInStart"] is Timestamp
                       ? ((Timestamp)attendanceData["TimeInStart"]).ToDateTime().ToLocalTime()
                       : (DateTime?)null;
                    DateTime? timeInEnd = attendanceData.ContainsKey("TimeInEnd") && attendanceData["TimeInEnd"] is Timestamp
                      ? ((Timestamp)attendanceData["TimeInEnd"]).ToDateTime().ToLocalTime()
                      : (DateTime?)null;
                    DateTime? timeOutStart = attendanceData.ContainsKey("TimeOutStart") && attendanceData["TimeOutStart"] is Timestamp
                     ? ((Timestamp)attendanceData["TimeOutStart"]).ToDateTime().ToLocalTime()
                     : (DateTime?)null;
                    DateTime? timeOutEnd = attendanceData.ContainsKey("TimeOutEnd") && attendanceData["TimeOutEnd"] is Timestamp
                    ? ((Timestamp)attendanceData["TimeOutEnd"]).ToDateTime().ToLocalTime()
                : (DateTime?)null;

                    Console.WriteLine(timeInStart + " " + timeOutStart);
                    return new AttendanceModel
                    {
                        EventID = eventId,
                        TotalAttendees = totalAttendees,
                        TimeInStart = timeInStart,
                        TimeInEnd = timeInEnd,
                        TimeOutStart = timeOutStart,
                        TimeOutEnd = timeOutEnd
                    };
                }
                else
                {
                    Console.WriteLine("Attendance data for the event not found.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        private async Task<List<string>> GetAttendedEventIdsAsync(string studentId)
        {
            var attendanceCollection = db.Collection("Attendance");
            var attendanceSnapshot = await attendanceCollection.GetSnapshotAsync();

            var attendedEventIds = new List<string>();

            foreach (var attendanceDoc in attendanceSnapshot.Documents)
            {
                var eventId = attendanceDoc.GetValue<string>("EventID");
                var presentSubCollection = attendanceDoc.Reference.Collection("Present");
                var studentDoc = presentSubCollection.Document(studentId);

                var studentSnapshot = await studentDoc.GetSnapshotAsync();
                if (studentSnapshot.Exists)
                {
                    attendedEventIds.Add(eventId);
                }
            }
            return attendedEventIds;
        }

        public async Task<int> GetTotalAttendees(AttendanceModel attendance)
        {
            try
            {
                DocumentReference docRef = db.Collection("Attendance").Document(attendance.EventID);
                DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

                if (snapshot.Exists)
                {
                    if (snapshot.TryGetValue("TotalAttendees", out int totalAttendees))
                    {
                        Console.WriteLine($"Total Attendees: {totalAttendees}");
                        return totalAttendees;
                    }
                    else
                    {
                        Console.WriteLine("TotalAttendees field is missing.");
                    }
                }
                else
                {
                    Console.WriteLine($"Document with ID {attendance.EventID} does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching TotalAttendees: {ex.Message}");
            }

            return 0; 
        }


    private async Task StoreAttendanceData(AttendanceModel attendance, string path, MemberModel member, DateTime time, bool isTimeIn)
        {
            DocumentReference attendanceDoc = db.Collection("Attendance").Document(attendance.EventID);
            await attendanceDoc.UpdateAsync("TotalAttendees", FieldValue.Increment(1));

            if (string.IsNullOrWhiteSpace(path))
            {
                MessageBox.Show("Attendance path is invalid.");
                return;
            }

            try
            {
                CollectionReference collection = db.Collection(path);
                if (isTimeIn)
                {
                    await collection.AddAsync(new
                    {
                        StudentID = member.StudentID,
                        FirstName = member.FirstName,
                        LastName = member.LastName,
                        YearLevel = member.YearLevel,
                        TimeIn = time.ToUniversalTime(),
                    });
                }
                else
                {
                    await collection.AddAsync(new
                    {
                        StudentID = member.StudentID,
                        FirstName = member.FirstName,
                        LastName = member.LastName,
                        YearLevel = member.YearLevel,
                        TimeOut = time.ToUniversalTime(),
                    });
                }
                MessageBox.Show("Attendance logged successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while storing data: {ex.Message}");
            }
        }

        public async Task StoreMemberPresentTimeIn(MemberModel member, AttendanceModel attendance, DateTime time)
        {
            try
            {
                if (member == null)
                {
                    MessageBox.Show("Member is NULL");
                    return;
                }
                await StoreAttendanceData(attendance, attendance.PresentSubCollectionPath, member, time, true);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error occured when logging attendance" + ex.Message);
            }
        }

        public async Task StoreMemberPresentTimeOut(MemberModel member, AttendanceModel attendance, DateTime time)
        {
            try
            {
                if (member == null)
                {
                    MessageBox.Show("Member is NULL");
                    return;
                }
                await StoreAttendanceData(attendance, attendance.PresentSubCollectionPath, member, time, false);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error occured when logging attendance" + ex.Message);
            }
        }

        public async Task<(List<MemberModel>, DocumentSnapshot)> GetAbsentMembers(AttendanceModel attendance, int pageSize, DocumentSnapshot lastdoc)
        {
            memberservice = new MemberService();

            List<MemberModel> present = await CurrentlyPresent(attendance);
            (List<MemberModel> memberlist, DocumentSnapshot firstDoc) = await memberservice.RetrieveActiveMembersAsync(pageSize, lastdoc);
            List<MemberModel> absentMembers = memberlist.Except(present).ToList();

            return (absentMembers, firstDoc);
        }
    }
}
