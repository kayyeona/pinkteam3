using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISCAP.Models;

namespace ISCAP.ViewModel
{
    public class ReadConferenceScheduleViewModel
    {
        public List<Event> Event { get; set; }
        public List<Room> Room { get; set; }
    }
}
