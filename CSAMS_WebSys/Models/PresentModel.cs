using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAMS_WebSys.Models
{
    public class PresentModel
    {
        public string StudentID { get; set; } = string.Empty;
        public DateTime? TimeIn { get; set; } = null;
        public DateTime? TimeOut { get; set; } = null;
    }
}
