using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAMS_WebSys.Models
{
    public class SchoolYearModel
    {
        [FirestoreProperty]
        public string SchoolYearDocID { get; set; }
        [FirestoreProperty]
        public string SchoolYearID { get; set; }
        [FirestoreProperty]
        public bool isActive { get; set; }
        [FirestoreProperty]
        public DateTime? StartDate { get; set; }
        [FirestoreProperty]
        public DateTime? EndDate { get; set; }
    }
}
