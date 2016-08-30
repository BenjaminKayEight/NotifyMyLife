using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifyMyLife2.Models {
    class Notification {
        public bool IsActive { get; set; }
        public string Message { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int RepPeriod { get; set; } // in minues


        public Notification() {
            IsActive = true;
            Message = "Default Notification Message";
            StartTime = DateTime.Now;
            EndTime = DateTime.Now.AddMinutes(10);
            RepPeriod = 1;

        }
    }
}
