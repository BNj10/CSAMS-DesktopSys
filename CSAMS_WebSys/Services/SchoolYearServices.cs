using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSAMS_WebSys.Services;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using CSAMS_WebSys.Models;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;
using System.Security.RightsManagement;

namespace CSAMS_WebSys.Services
{
    internal class SchoolYearServices
    {
        private FirestoreDb db;
        private List<SchoolYearModel> SchoolYears;
        public SchoolYearServices()
        {
            db = FirebaseConnectionService.GetConnection();
        }

        public async Task UpdateSchoolYearAsync()
        {

            try
            {
                var schoolYearsSnapshot = await db.Collection("School Year").GetSnapshotAsync();

                if(schoolYearsSnapshot.Count == 0)
                {
                    Console.WriteLine("No School Years found.");
                    return;
                }
                var currentTime = DateTime.UtcNow;

                foreach (var document in schoolYearsSnapshot.Documents)
                {
                    var data = document.ToDictionary();
                    var startDate = data.ContainsKey("StartDate") ? ((Timestamp)data["StartDate"]).ToDateTime() : (DateTime?)null;
                    var endDate = data.ContainsKey("EndDate") ? ((Timestamp)data["EndDate"]).ToDateTime() : (DateTime?)null;

                    if (startDate == null || endDate == null)
                    {
                        Console.WriteLine($"Skipping document {document.Id}: StartDate or EndDate is null.");
                        continue;
                    }

                    bool isActive = currentTime >= startDate && currentTime <= endDate;
                    await document.Reference.UpdateAsync("isActive", isActive);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while updating SchoolYear: " + ex.Message);
            }
        }

        public async Task<List<SchoolYearModel>> GetSchoolYears()
        {
            try
            {
                Query query = db.Collection("School Year")
                            .Select("SchoolYearID", "StartDate", "EndDate", "isActive");

                QuerySnapshot querySnapshot = await query.GetSnapshotAsync();
                if (querySnapshot.Documents.Count > 0)
                {
                    return null;
                }
                List<SchoolYearModel> schoolYears = new List<SchoolYearModel>();
                foreach (DocumentSnapshot document in querySnapshot.Documents)
                {

                    var SY = new SchoolYearModel
                    {
                        SchoolYearID = document.ContainsField("SchoolYearID") ? document.GetValue<string>("SchoolYearID") : null,
                        StartDate = document.ContainsField("StartDate") ? document.GetValue<DateTime?>("StartDate") : null,
                        EndDate = document.ContainsField("EndDate") ? document.GetValue<DateTime?>("EndDate") : null,
                        isActive = document.ContainsField("isActive") ? document.GetValue<bool>("isActive") : false
                    };
                    schoolYears.Add(SY);
                }
                return schoolYears;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while fetching School Years: " + ex.Message);
                return null;
            }
        }

        public async Task<SchoolYearModel> GetActiveSchoolYearAsync()
        {
            try
            {
                var query = await db.Collection("School Year")
                                     .WhereEqualTo("isActive", true)
                                     .Limit(1)  
                                     .GetSnapshotAsync();

                var activeDocument = query.Documents.FirstOrDefault();

                if (activeDocument != null)
                {
                    return new SchoolYearModel
                    {
                        SchoolYearID = activeDocument.ContainsField("SchoolYearID") ? activeDocument.GetValue<string>("SchoolYearID") : null,
                        StartDate = activeDocument.ContainsField("StartDate") ? ((Timestamp)activeDocument.GetValue<Timestamp>("StartDate")).ToDateTime() : (DateTime?)null,
                        EndDate = activeDocument.ContainsField("EndDate") ? ((Timestamp)activeDocument.GetValue<Timestamp>("EndDate")).ToDateTime() : (DateTime?)null,
                        isActive = true
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching the active school year: " + ex.Message);
                return null;
            }
        }
    }
}
