using DocumentFormat.OpenXml.Office2010.Excel;
using Firebase.Auth;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAMS_WebSys.Models
{
    [FirestoreData]
    public class MemberModel : IEquatable<MemberModel>
    {
        [FirestoreProperty]
        public string StudentID { get; set; }
        [FirestoreProperty]
        public string SchoolYearID { get; set; }
        [FirestoreProperty]
        public string FirstName { get; set; }
        [FirestoreProperty]
        public string LastName { get; set; }
        [FirestoreProperty]
        public string YearLevel { get; set; }
        [FirestoreProperty]
        public  string Status { get; set; }
        [FirestoreProperty]
        public List<string> FingerprintData { get; set; } = new List<string>();
        [FirestoreProperty]
        public DateTime? DateAdded { get; set; }
        [FirestoreProperty]
        public bool isArchived { get; set; } = false;
        [FirestoreProperty]
        public DateTime? TimeIn { get; set; } = null;
        [FirestoreProperty]
        public DateTime? TimeOut { get; set; } = null;
        [FirestoreProperty]
        public bool BiometricsAdded { get; set; }

        public bool Equals(MemberModel other)
        {
            if (other == null) return false; 
            return this.StudentID == other.StudentID;   
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;
            return Equals((MemberModel)obj);
        }

        public override int GetHashCode()
        {
            return StudentID?.GetHashCode() ?? 0; // Use Id's hash code
        }
    }
}
