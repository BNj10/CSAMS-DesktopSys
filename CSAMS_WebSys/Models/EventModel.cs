using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSAMS_WebSys.Models.enums;

namespace CSAMS_WebSys.Models
{
    public class EventModel
    {
        public string EventID { get; set; }
        public string EventName { get; set; }
        public string EventDescription { get; set; }
        public EventStatus Status { get; set; }
        public DateTime? DateAdded { get; set; } = DateTime.Now;
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public bool IsArchived { get; set; } = false;
    }
}
