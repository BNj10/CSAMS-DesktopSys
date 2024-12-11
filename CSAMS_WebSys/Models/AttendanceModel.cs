using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAMS_WebSys.Models.enums
{
    public class AttendanceModel
    {
        public string AttendanceID { get; set; }
        public string SchoolYearID { get; set; }
        public string EventName { get; set; }
        public DateTime? DateStart { get; set; }
        public int TotalAttendees { get; set; } = 0;
        public DateTime? TimeInStart { get; set; } = null;
        public DateTime? TimeInEnd { get; set; } = null;
        public DateTime? TimeOutStart { get; set; } = null;
        public DateTime? TimeOutEnd { get; set; } = null;
        public string PresentSubCollectionPath => $"Attendance/{AttendanceID}/Present";
    }
}
