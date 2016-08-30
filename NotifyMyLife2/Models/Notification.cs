using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifyMyLife2.Models {
    class Notification {
        public bool IsActive { get; set; }
        public string Message { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int RepPeriod { get; set; } // in minues


        public Notification() {
            IsActive = true;
            Message = "Default Notification Message";
            StartTime = DateTime.Now.TimeOfDay;
            EndTime = StartTime.Add(new TimeSpan(00,30,00));
            RepPeriod = 1;

        }
    }
}
