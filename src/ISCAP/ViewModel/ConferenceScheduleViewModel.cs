using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISCAP.Models;

namespace ISCAP.ViewModel
{
    public class ConferenceScheduleViewModel
    {
        public List<ConferenceSchedule> ConferenceSchedule { get; set; }
        public List<SessionDetail> SessionDetail { get; set; }
        public List<Session> Session { get; set; }
    }
}
