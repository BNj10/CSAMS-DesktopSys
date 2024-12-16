    using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSAMS_WebSys.Services;
using System.Windows.Forms;
using static Google.Cloud.Firestore.V1.StructuredAggregationQuery.Types.Aggregation.Types;
using CSAMS_WebSys.Models;
using CSAMS_WebSys.Models.enums;
using FireSharp.Extensions;
using Google.Cloud.Firestore.V1;
using DocumentFormat.OpenXml.Office2013.WebExtension;
using DocumentFormat.OpenXml.Vml.Spreadsheet;

namespace CSAMS_WebSys.Services.Dashboard
{
    public class UpdatesService
    {
        public event Action<int> TotalMembersUpdated;
        FirestoreDb db;

        public UpdatesService()
        {
            db = FirebaseConnectionService.GetConnection();
        }
        
        public void ListenChanges()
        {
            CollectionReference studentsRef = db.Collection("Member");
            FirestoreChangeListener listener = studentsRef.Listen(snapshot =>
            {
                Console.WriteLine("Callback received query snapshot.");
                int totalStudents = snapshot.Documents.Count;

                TotalMembersUpdated?.Invoke(totalStudents);
            });
        }

        public async Task<int> GetTotalMembersAsync()
        {
            int count = 0;
            try
            {
                var membersCollection = db.Collection("Member");
                var snapshot = await membersCollection.GetSnapshotAsync();

                count = snapshot.Documents.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured" + ex);
            }
            return count;
        }

        public async Task<List<SchoolYearModel>> GetAllSchoolYearAsync()
        {
            try
            {
                CollectionReference colref = db.Collection("School Year");
                var snapshot = await colref.OrderBy("SchoolYearID").GetSnapshotAsync();

                List<SchoolYearModel> schoolYearsList = snapshot.Documents.Select(doc => new SchoolYearModel
                {
                    SchoolYearDocID = doc.Id,
                    SchoolYearID = doc.GetValue<string>("SchoolYearID"),
                    isActive = doc.GetValue<bool>("isActive")
                }).ToList();

                return schoolYearsList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching school year data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<SchoolYearModel>();
            }
        }

        public async Task<List<SchoolYearModel>> GetAllSchoolYearID()
        {
            try
            {
                List<SchoolYearModel> YearModel = await GetAllSchoolYearAsync();
                List<SchoolYearModel> sortedSY = YearModel.OrderBy(x => x.isActive)
                                                          .ThenBy(x => x.SchoolYearID)        
                                                          .ToList();      

                return sortedSY;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error on GetAllSchoolYearID: fetching school year data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<SchoolYearModel>();
            }
        }
        public async Task<int> GetTotalMembersWithNoBiometrics()
        {
            int count = 0;
            try
            {
                var memberCollection = db.Collection("Member");
                var snapshot = await memberCollection.WhereEqualTo("isArchived", false)
                                                     .WhereEqualTo("FingerprintData", new Object[] {})
                                                     .GetSnapshotAsync();
                count += snapshot.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
            return count;
        }

        public async Task<EventModel> GetLatestEventOccured()
        {
            TimeZoneInfo philippineTime;
            try
            {
                philippineTime = TimeZoneInfo.FindSystemTimeZoneById("China Standard Time");
            }
            catch
            {
                try
                {
                    philippineTime = TimeZoneInfo.FindSystemTimeZoneById("Asia/Manila");
                }
                catch
                {
                    philippineTime = TimeZoneInfo.CreateCustomTimeZone(
                        "Philippine Time",
                        new TimeSpan(8, 0, 0),
                        "Philippine Time",
                        "Philippine Standard Time");
                }
            }

            try
            {
                var eventRef = db.Collection("Event");
                var utcNow = DateTime.UtcNow;
                Console.WriteLine($"Current UTC time: {utcNow}");
                var philNow = TimeZoneInfo.ConvertTimeFromUtc(utcNow, philippineTime);
                Console.WriteLine($"Current Philippine time: {philNow}");

                Query ongoingQuery = eventRef
                    .WhereEqualTo("isArchived", false)
                    .WhereLessThanOrEqualTo("DateStart", utcNow)
                    .WhereGreaterThanOrEqualTo("DateEnd", utcNow)
                    .OrderByDescending("DateEnd") 
                    .Select("EventName", "EventDescription", "DateStart", "DateEnd");

                var ongoingSnapshot = await ongoingQuery.GetSnapshotAsync();

                if (ongoingSnapshot.Count > 0)
                {
                    return CreateEventModel(ongoingSnapshot.Documents[0], philippineTime);
                }

                Query recentlyEndedQuery = eventRef
                    .WhereEqualTo("isArchived", false)
                    .WhereLessThan("DateEnd", utcNow)
                    .OrderByDescending("DateEnd")
                    .Limit(1)
                    .Select("EventName", "EventDescription", "DateStart", "DateEnd");

                var recentlyEndedSnapshot = await recentlyEndedQuery.GetSnapshotAsync();
                if (recentlyEndedSnapshot.Count == 0)
                {
                    Console.WriteLine("No events found");
                    return null;
                }

                return CreateEventModel(recentlyEndedSnapshot.Documents[0], philippineTime);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred: {ex.Message}");
                return null;
            }
        }

        private EventModel CreateEventModel(DocumentSnapshot document, TimeZoneInfo timeZone)
        {
            DateTime? convertedStartDate = null;
            DateTime? convertedEndDate = null;

            if (document.ContainsField("DateStart") && document.GetValue<DateTime?>("DateStart").HasValue)
            {
                var utcStartDate = document.GetValue<DateTime>("DateStart");
                convertedStartDate = TimeZoneInfo.ConvertTimeFromUtc(utcStartDate, timeZone);
                Console.WriteLine($"Event Start (UTC): {utcStartDate}");
                Console.WriteLine($"Event Start (PHT): {convertedStartDate}");
            }

            if (document.ContainsField("DateEnd") && document.GetValue<DateTime?>("DateEnd").HasValue)
            {
                var utcEndDate = document.GetValue<DateTime>("DateEnd");
                convertedEndDate = TimeZoneInfo.ConvertTimeFromUtc(utcEndDate, timeZone);
                Console.WriteLine($"Event End (UTC): {utcEndDate}");
                Console.WriteLine($"Event End (PHT): {convertedEndDate}");
            }

            EventModel eventModel = new EventModel
            {
                EventName = document.ContainsField("EventName") ? document.GetValue<string>("EventName") : null,
                EventDescription = document.ContainsField("EventDescription") ? document.GetValue<string>("EventDescription") : null,
                DateStart = convertedStartDate,
                DateEnd = convertedEndDate
            };

            return SetStatus(eventModel);
        }

        public EventModel SetStatus(EventModel model)
        {
            try
            {
                var utcNow = DateTime.UtcNow;
                Console.WriteLine($"Setting status at UTC: {utcNow}");

                EventStatus newStatus;

                var startUtc = model.DateStart?.ToUniversalTime();
                var endUtc = model.DateEnd?.ToUniversalTime();

                if (startUtc <= utcNow && endUtc >= utcNow)
                {
                    newStatus = EventStatus.Ongoing;
                    Console.WriteLine("Status set to: Ongoing");
                }
                else if (startUtc > utcNow && endUtc > utcNow)
                {
                    newStatus = EventStatus.Pending;
                    Console.WriteLine("Status set to: Pending");
                }
                else
                {
                    newStatus = EventStatus.Done;
                    Console.WriteLine("Status set to: Done");
                }

                model.Status = newStatus;
                return model;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error setting status: {ex.Message}");
            }
            return model;
        }


        public async Task<int> GetTotalMembersByYear(string year)
        {
            int count = 0;
            try
            {
                var memberCollection = db.Collection("Member");
                var snapshot = await memberCollection.WhereEqualTo("YearLevel", year).WhereEqualTo("isArchived", false).GetSnapshotAsync(); 

                count = snapshot.Documents.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
            return count;
        }

        public async Task<int> GetTotalMembersFirstYear(string year)
        {
            return await GetTotalMembersByYear(year);
        }

        public async Task<int> GetTotalMembersSecondYear(string year)
        {
            return await GetTotalMembersByYear(year);
        }

        public async Task<int> GetTotalMembersThirdYear(string year)
        {
            return await GetTotalMembersByYear(year);
        }

        public async Task<int> GetTotalMembersFourthYear(string year)
        {
            return await GetTotalMembersByYear(year);
        }

        public async Task<int> GetTotalMembersFifthYearAndAbove(string year)
        {
            return await GetTotalMembersByYear(year);
        }

        /*public async Task<DashboardDataModel> GetDashboardDataAsync()
        {
            var data = new DashboardDataModel
            {
                TotalMembers = await GetTotalMembersAsync(),
                MembersWithoutBiometrics = await GetTotalMembersWithNoBiometrics(),
                MembersByYear = new Dictionary<string, int>
        {
            { "1", await GetTotalMembersByYear("1") },
            { "2", await GetTotalMembersByYear("2") },
            { "3", await GetTotalMembersByYear("3") },
            { "4", await GetTotalMembersByYear("4") },
            { "5th above", await GetTotalMembersByYear("5th above") }
        },
                LatestEvent = await GetLatestEventOccured(),
                SchoolYears = await GetAllSchoolYearID()
            };
            return data;
        }*/
    }
}
