using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISCAP.Models;

namespace ISCAP.ViewModel
{
    public class WriteConferenceScheduleViewModel
    {
        public Event Event { get; set; }
        public Slot Slot { get; set; }
        public Session Session { get; set; }
    }
}
