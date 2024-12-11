﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSAMS_WebSys.Models;
using CSAMS_WebSys.Services;
using Google.Cloud.Firestore;
using Firebase.Auth;
using Google.Rpc;
using System.Security.Cryptography;



namespace CSAMS_WebSys.Services
{
    public class MemberService
    {
        private static List<MemberModel> members = new List<MemberModel>();
        private string StudentID;

        private FirestoreDb db;
        public MemberService()
        {
            try
            {
                db = FirebaseConnectionService.GetConnection();
                if (db == null)
                {
                    throw new Exception("Failed to initialize Firestore connection.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error initializing FirestoreDb connection: {ex.Message}");
                throw;
            }
        }

        //ADD STUDENT DATA WITHOUT FINGERPRINT #TESTED 
        public async Task SaveMemberToFirestore(MemberModel member)
        {
            try
            {
                var memberData = new Dictionary<string, object>
                {
                    { "FirstName", member.FirstName },
                    { "LastName", member.LastName },
                    { "YearLevel", member.YearLevel },
                    { "Status", member.Status },
                    { "FingerprintData", member.FingerprintData },
                    //{"SchoolYearID", member.SchoolYearID },
                    { "StudentID", member.StudentID },
                    { "DateAdded", member.DateAdded },
                    { "isArchived", member.isArchived },
                    { "BiometricsAdded", member.BiometricsAdded }
                };

                DocumentReference docRef = db.Collection("Member").Document();
                await docRef.SetAsync(memberData);
                members.Add(member);

                MessageBox.Show("Student data saved successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving member to Firestore: {ex.Message}");
            }
        }

        //ADD FINGERPRINT DATA ONLY 

        //ADD BOTH STUDENT AND FINGERPRINT DATA SILMUTANEOUSLY
        public async Task AddStudentWithFingerprint(MemberModel member)
        {
            try
            {
                var memberData = new Dictionary<string, object>
                {
                    { "FirstName", member.FirstName },
                    { "LastName", member.LastName },
                    { "YearLevel", member.YearLevel },
                    { "Status", member.Status },
                    { "StudentID", member.StudentID },
                    { "FingerprintData", member.FingerprintData },
                    { "DateAdded", member.DateAdded },
                    { "isArchived", member.isArchived }
                };

                DocumentReference docRef = db.Collection("Member").Document();
                await docRef.SetAsync(memberData);

                MessageBox.Show("Student added successfully!");
                members.Add(member);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving member to Firestore: {ex.Message}");
            }
        }

        public async Task StoreMemberInBulk(List<MemberModel> members)
        {
            var uniqueMembers = await CheckRedundancy(members.ToList());

            const int BatchSize = 500;
            var memberBatches = uniqueMembers
                .Select((student, index) => new { student, index })
                .GroupBy(x => x.index / BatchSize)
                .Select(g => g.Select(x => x.student).ToList())
                .ToList();

            foreach (var batch in memberBatches)
            {
                WriteBatch writeBatch = db.StartBatch();
                foreach (var member in batch)
                {
                    DocumentReference docRef = db.Collection("Member").Document();
                    writeBatch.Set(docRef, member);
                }
                await writeBatch.CommitAsync();
            }
        }

        public async Task<List<MemberModel>> CheckRedundancy(List<MemberModel> members)
        {
            const int PageSize = 500;
            var existingStudentIds = new HashSet<string>();
            var uniqueMembers = new List<MemberModel>();
            CollectionReference collectionRef = db.Collection("Member");

            Query query = collectionRef.Limit(PageSize);
            QuerySnapshot snapshot;

            do
            {
                snapshot = await query.GetSnapshotAsync();
                foreach (var document in snapshot.Documents)
                {
                    if (document.Exists)
                    {
                        string studentId = document.GetValue<string>("StudentID");
                        Console.WriteLine(studentId);
                        existingStudentIds.Add(studentId);
                    }
                }

                var lastDocument = snapshot.Documents.LastOrDefault();
                query = lastDocument != null
                                            ? collectionRef.StartAfter(lastDocument).Limit(PageSize)
                                            : null;
            } while (snapshot.Count > 0 && query != null);

            Console.WriteLine("Existing Student IDs: " + existingStudentIds.Count);

            foreach (var member in members)
            {
                if (!existingStudentIds.Contains(member.StudentID))
                {
                    uniqueMembers.Add(member);
                }
            }

            return uniqueMembers;
        }


        //RETRIEVE ALL MEMBERS THAT ARE NOT ARCHIVED #TESTED
        public async Task<(List<MemberModel>, DocumentSnapshot)> RetrieveActiveMembersAsync(int pageSize, DocumentSnapshot lastVisible)
        {
            try
            {
                Query query = db.Collection("Member")
                                .WhereEqualTo("isArchived", false)
                                .Limit(pageSize)
                                .Select("StudentID", "FirstName", "LastName", "Status", "YearLevel", "BiometricsAdded", "DateAdded");


                if (lastVisible != null)
                {
                    Console.WriteLine($"Last Visible Document ID: {lastVisible.Id}");
                    query = query.StartAfter(lastVisible);
                }

                QuerySnapshot querySnapshot = await query.GetSnapshotAsync();

                if (querySnapshot.Documents.Count == 0)
                {
                    Console.WriteLine("No more data to fetch");
                    return (new List<MemberModel>(), null);
                }

                List<MemberModel> members = new List<MemberModel>();

                foreach (DocumentSnapshot document in querySnapshot.Documents)
                {
                    if (document.Exists)
                    {
                        var memberModel = new MemberModel
                        {
                            StudentID = document.ContainsField("StudentID") ? document.GetValue<string>("StudentID") : null,
                            FirstName = document.ContainsField("FirstName") ? document.GetValue<string>("FirstName") : null,
                            LastName = document.ContainsField("LastName") ? document.GetValue<string>("LastName") : null,
                            YearLevel = document.ContainsField("YearLevel") ? document.GetValue<string>("YearLevel") : null,
                            Status = document.ContainsField("Status") ? document.GetValue<string>("Status") : null,
                            BiometricsAdded = document.ContainsField("BiometricsAdded") ? document.GetValue<bool>("BiometricsAdded") : false,
                            DateAdded = document.ContainsField("DateAdded") ? document.GetValue<DateTime?>("DateAdded") : null,
                        };
                        members.Add(memberModel);
                    }
                }
                DocumentSnapshot lastDoc = querySnapshot.Documents.Count > 0 ? querySnapshot.Documents[querySnapshot.Documents.Count - 1] : null;
                return (members, lastDoc);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving active members with pagination.", ex);
            }
        }

            public async Task<(List<MemberModel>, DocumentSnapshot)> RetrieveAllActiveMembersWithFingerprint(int pageSize, DocumentSnapshot lastVisible)
            {
            int size = pageSize;
                try
                {
                    Query QueryYesFp1 = db.Collection("Member")
                        .WhereEqualTo("isArchived", false)
                        .WhereNotEqualTo("FingerprintData", new object[] { })
                        .OrderBy("FingerprintData")
                        .OrderBy("DateAdded")
                        .OrderBy(FieldPath.DocumentId)
                        .Select("StudentID", "FirstName", "LastName", "YearLevel", "Status", "DateAdded", "FingerprintData")
                        .Limit(size);

                    Console.WriteLine("Retrieving all active members with fingerprint data FOR Fp1");

                    Query QueryNoFp2 = db.Collection("Member")
                     .WhereEqualTo("isArchived", false)
                     .WhereEqualTo("FingerprintData", new object[] { })
                     .OrderBy("DateAdded")
                     .OrderBy(FieldPath.DocumentId)
                     .Select("StudentID", "FirstName", "LastName", "YearLevel", "Status", "DateAdded", "FingerprintData")
                     .Limit(size);

                    Console.WriteLine("Retrieving all active members with fingerprint data FOR Fp2");

                    if (lastVisible != null)
                    {
                        QueryYesFp1 = QueryYesFp1.StartAfter(lastVisible);
                        QueryNoFp2 = QueryNoFp2.StartAfter(lastVisible);
                    }
                    QuerySnapshot withFingerprintSnapshot = await QueryNoFp2.GetSnapshotAsync();
                    QuerySnapshot withoutFingerprintSnapshot = await QueryNoFp2.GetSnapshotAsync();

                    List<MemberModel> members = new List<MemberModel>();
                Console.WriteLine("Passing data2");
                var allDocuments = withFingerprintSnapshot.Documents.Concat(withoutFingerprintSnapshot.Documents).ToList();
                Console.WriteLine("Passing data1");
                foreach (DocumentSnapshot document in allDocuments)
                    {
                        Console.WriteLine("Passing data");
                        if (document.Exists)
                        {
                            var member = new MemberModel
                            {
                                StudentID = document.ContainsField("StudentID") ? document.GetValue<string>("StudentID") : null,
                                FirstName = document.ContainsField("FirstName") ? document.GetValue<string>("FirstName") : null,
                                LastName = document.ContainsField("LastName") ? document.GetValue<string>("LastName") : null,
                                YearLevel = document.ContainsField("YearLevel") ? document.GetValue<string>("YearLevel") : null,
                                Status = document.ContainsField("Status") ? document.GetValue<string>("Status") : null,
                                FingerprintData = document.ContainsField("FingerprintData") ? document.GetValue<List<string>>("FingerprintData") : null,
                                DateAdded = document.ContainsField("DateAdded") ? document.GetValue<DateTime?>("DateAdded") : null,
                            };
                            members.Add(member);
                        }
                    }
                    DocumentSnapshot lastDoc = allDocuments.Count > 0
                        ? allDocuments[allDocuments.Count - 1]
                        : null;

                    return (members, lastDoc);
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred while retrieving active members with fingerprint data.", ex);
                }
            }
        public async Task<(List<MemberModel>, DocumentSnapshot)> RetrieveActiveMembersWithFingerprintAsync(int pageSize, DocumentSnapshot lastVisible)
        {
            try
            {
                Query query = db.Collection("Member")
                 .WhereEqualTo("isArchived", false)
                 .WhereNotEqualTo("FingerprintData", new object[] { })
                 .OrderBy("FingerprintData")
                 .OrderBy("DateAdded")
                 .OrderBy(FieldPath.DocumentId)
                 .Select("StudentID", "FirstName", "LastName", "YearLevel", "DateAdded", "FingerprintData")
                 .Limit(pageSize);

                if (lastVisible != null)
                {
                    query = query.StartAfter(lastVisible);
                }

                QuerySnapshot querySnapshot = await query.GetSnapshotAsync();
                List<MemberModel> members = new List<MemberModel>();

                foreach (DocumentSnapshot document in querySnapshot.Documents)
                {
                    if (document.Exists)
                    {
                        members.Add(new MemberModel
                        {
                            StudentID = document.ContainsField("StudentID") ? document.GetValue<string>("StudentID") : null,
                            FirstName = document.ContainsField("FirstName") ? document.GetValue<string>("FirstName") : null,
                            LastName = document.ContainsField("LastName") ? document.GetValue<string>("LastName") : null,
                            YearLevel = document.ContainsField("YearLevel") ? document.GetValue<string>("YearLevel") : null,
                            FingerprintData = document.ContainsField("FingerprintData") ? document.GetValue<List<string>>("FingerprintData") : null,
                            //DateAdded = document.ContainsField("DateAdded") ? document.GetValue<DateTime?>("DateAdded") : null,
                        });
                    }
                }
                DocumentSnapshot lastDoc = querySnapshot.Documents.Count > 0 ? querySnapshot.Documents[querySnapshot.Documents.Count - 1] : null;
                return (members, lastDoc);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving active members with pagination and fingerprint data.", ex);
            }
        }

        /*       public void ListenForMemberChanges(Action<MemberModel, string> onMemberChanged)
               {
                   CollectionReference membersRef = db.Collection("Member");
                   FirestoreChangeListener listener = membersRef.Listen(snapshot =>
                   {
                       foreach (DocumentChange change in snapshot.Changes)
                       {
                           MemberModel memberModel = null;

                           if (change.Document.Exists)
                           {
                               memberModel = new MemberModel
                               {
                                   StudentID = change.Document.ContainsField("StudentID") ? change.Document.GetValue<string>("StudentID") : null,
                                   FirstName = change.Document.ContainsField("FirstName") ? change.Document.GetValue<string>("FirstName") : null,
                                   LastName = change.Document.ContainsField("LastName") ? change.Document.GetValue<string>("LastName") : null,
                                   YearLevel = change.Document.ContainsField("YearLevel") ? change.Document.GetValue<string>("YearLevel") : null,
                                   Status = change.Document.ContainsField("Status") ? change.Document.GetValue<string>("Status") : null,
                                   DateAdded = change.Document.ContainsField("DateAdded") ? change.Document.GetValue<DateTime?>("DateAdded") : null
                               };
                           }

                           switch (change.ChangeType)
                           {
                               case DocumentChange.Type.Added:
                                   Console.WriteLine($"New member added: {memberModel.StudentID}");
                                   onMemberChanged?.Invoke(memberModel, "Added");
                                   break;
                               case DocumentChange.Type.Modified:
                                   Console.WriteLine($"Member modified: {memberModel.StudentID}");
                                   onMemberChanged?.Invoke(memberModel, "Modified");
                                   break;
                               case DocumentChange.Type.Removed:
                                   Console.WriteLine($"Member removed: {memberModel.StudentID}");
                                   onMemberChanged?.Invoke(memberModel, "Removed");
                                   break;
                           }
                       }
                   });
               }*/
        //RETRIEVE SPECIFIC DATA SPECIFIED BY THE USER

       /* public async Task<List<MemberModel>> SearchMembersByAnyAttribute(string searchTerm)
            {
                var result = new List<MemberModel>();

                try
                {
                    var queries = new List<Query>
                {
                    db.Collection("Member")
                        .WhereEqualTo("isArchived", false)
                        .WhereGreaterThanOrEqualTo("FirstName", searchTerm)
                        .WhereLessThan("FirstName", searchTerm + "\uf8ff")
                        .OrderBy("FirstName")
                        .Select("StudentID", "FirstName", "LastName", "YearLevel", "Status", "DateAdded"),


                    db.Collection("Member")
                        .WhereEqualTo("isArchived", false)
                        .WhereGreaterThanOrEqualTo("LastName", searchTerm)
                        .WhereLessThan("LastName", searchTerm + "\uf8ff")
                        .OrderBy("LastName")
                        .Select("StudentID", "FirstName", "LastName", "YearLevel", "Status", "DateAdded"),

                    db.Collection("Member")
                        .WhereEqualTo("isArchived", false)
                        .WhereGreaterThanOrEqualTo("StudentID", searchTerm)
                        .WhereLessThan("StudentID", searchTerm + "\uf8ff")
                        .OrderBy("StudentID")
                        .Select("StudentID", "FirstName", "LastName", "YearLevel", "Status", "DateAdded")         
                };

                    var searchTasks = queries.Select(q => q.GetSnapshotAsync());
                    var snapshots = await Task.WhenAll(searchTasks);
                        
                    var processedIds = new HashSet<string>();
                    
                    foreach (var snapshot in snapshots)
                    {
                        foreach (var document in snapshot.Documents)
                        {
                            if (processedIds.Add(document.Id))
                            {
                                var memberData = new MemberModel
                                {
                                    StudentID = document.GetValue<string>("StudentID"),
                                    FirstName = document.GetValue<string>("FirstName"),
                                    LastName = document.GetValue<string>("LastName"),
                                    YearLevel = document.GetValue<string>("YearLevel"),
                                };
                            result.Add(memberData);
                        }
                        }
                    }

                    return result.OrderBy(m => m.FirstName).ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error occurred while searching for members: " + ex);
                    return result;
                }
            }*/

        //RETRIEVE DATA BASED ON THE FILTERED DATA (Year Level)
        public async Task<(List<MemberModel>, DocumentSnapshot)> SearchStudentDataByYearLevelAsync(int pageSize, DocumentSnapshot lastVisible, string yearLevel)
        {
            try
            {
                if (string.IsNullOrEmpty(yearLevel))
                {
                    throw new ArgumentException("YearLevel must be provided.", nameof(yearLevel));
                }

                Query query = db.Collection("Member")
                                 .WhereEqualTo("isArchived", false)
                                 .WhereEqualTo("YearLevel", yearLevel)  
                                 .Limit(pageSize);

                if (lastVisible != null)
                {
                    query = query.StartAfter(lastVisible);
                }

                QuerySnapshot querySnapshot = await query.GetSnapshotAsync();

                List<MemberModel> members = new List<MemberModel>();
                foreach (DocumentSnapshot document in querySnapshot.Documents)
                {
                    if (document.Exists)
                    {
                        var memberModel = new MemberModel
                        {
                            StudentID = document.ContainsField("StudentID") ? document.GetValue<string>("StudentID") : null,
                            SchoolYearID = document.ContainsField("SchoolYearID") ? document.GetValue<string>("SchoolYearID") : null,
                            FirstName = document.ContainsField("FirstName") ? document.GetValue<string>("FirstName") : null,
                            LastName = document.ContainsField("LastName") ? document.GetValue<string>("LastName") : null,
                            YearLevel = document.ContainsField("YearLevel") ? document.GetValue<string>("YearLevel") : null,
                            Status = document.ContainsField("Status") ? document.GetValue<string>("Status") : null,
                            DateAdded = document.ContainsField("DateAdded") ? document.GetValue<DateTime?>("DateAdded") : null,
                            isArchived = document.ContainsField("isArchived") ? document.GetValue<bool>("isArchived") : false
                        };

                        members.Add(memberModel);
                    }
                }

                DocumentSnapshot lastDoc = querySnapshot.Documents.Count > 0 ? querySnapshot.Documents[querySnapshot.Documents.Count - 1] : null;
                return (members, lastDoc);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while searching for student data by YearLevel.", ex);
            }
        }
        //RETRIEVE ALL MEMBERS THAT ARE ARCHIVED BY THE SYSTEM
        public async Task<List<MemberModel>> RetrieveArchivedMembersBySchoolYearAsync(MemberModel member)
        {
            try
            {
                Query query = db.Collection("Member")
                                .WhereEqualTo("isArchived", true)
                                .WhereEqualTo("SchoolYearID", member.SchoolYearID);

                QuerySnapshot querySnapshot = await query.GetSnapshotAsync();

                List<MemberModel> OrgMembers = new List<MemberModel>();

                foreach (DocumentSnapshot document in querySnapshot.Documents)
                {
                    if (document.Exists)
                    {
                        var memberStudent = new MemberModel
                        {
                            StudentID = document.ContainsField("StudentID") ? document.GetValue<string>("StudentID") : null,
                            SchoolYearID = document.ContainsField("SchoolYearID") ? document.GetValue<string>("SchoolYearID") : null,
                            FirstName = document.ContainsField("FirstName") ? document.GetValue<string>("FirstName") : null,
                            LastName = document.ContainsField("LastName") ? document.GetValue<string>("LastName") : null,
                            YearLevel = document.ContainsField("YearLevel") ? document.GetValue<string>("YearLevel") : null,
                            Status = document.ContainsField("Status") ? document.GetValue<string>("Status") : null,
                            DateAdded = document.ContainsField("DateAdded") ? document.GetValue<DateTime?>("DateAdded") : null,
                        };

                        OrgMembers.Add(memberStudent);
                    }
                }

                return OrgMembers;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving archived members for the specified school year.", ex);
            }
        }
        public async Task<MemberModel> RetrieveMemberByID(string data)
        {
            var student = new MemberModel();
            try
            {
                if(data == null)
                    return student;

                DocumentReference docRef = db.Collection("Member").Document(data);
                DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

                if (!snapshot.Exists)
                {
                    throw new Exception($"Member with ID {data} does not exist.");
                }

                student = snapshot.ConvertTo<MemberModel>();
                return student;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving the member by ID.", ex);
            }
        }

        public async Task UpdateMember(MemberModel member)
        {
            try
            {
                QuerySnapshot querySnapshot = await db.Collection("Member")
                                                      .WhereEqualTo("StudentID", member.StudentID)
                                                      .GetSnapshotAsync();

                if (querySnapshot.Documents.Count == 0)
                {
                    MessageBox.Show("No matching member found.");
                    return;
                }

                DocumentReference docRef = querySnapshot.Documents[0].Reference;

                await docRef.SetAsync(member, SetOptions.MergeAll);

                MessageBox.Show("Member data updated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating member data: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }
        public async Task DeleteMember(MemberModel member)
        {
            try
            {
                QuerySnapshot querySnapshot = await db.Collection("Member")
                                                      .WhereEqualTo("StudentID", member.StudentID)
                                                      .GetSnapshotAsync();

                if (querySnapshot.Count > 0)
                {
                    DocumentReference docRef = querySnapshot.Documents[0].Reference;
                    await docRef.DeleteAsync();
                    MessageBox.Show("Member data deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Member not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting member data: {ex.Message}");
            }
        }

        public async Task ArchiveMember(MemberModel member)
        {
            try
            {
                DocumentReference docRef = db.Collection("Member").Document(member.StudentID);
                await docRef.UpdateAsync(new Dictionary<string, object>
                {
                    { "isArchived", true }
                });

                MessageBox.Show("Member data archived successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error archiving member data: {ex.Message}");
            }
        }
    }
}