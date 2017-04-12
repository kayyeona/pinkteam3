using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ISCAP.Models;
using ISCAP.Data;
using ISCAP.ViewModel;


namespace ISCAP.Controllers
{
    [Route("ConferenceSchedule")]
    public class ConferenceScheduleController : Controller
    {
        public ApplicationDbContext db;

        public ConferenceScheduleController(ApplicationDbContext db)
        {
            this.db = db;
        }

        [HttpGet, Route("Form")]
        public ViewResult Form()
        {
            WriteConferenceScheduleViewModel cs = new WriteConferenceScheduleViewModel();
            cs.Event = new Event();
            return View(cs);
        }       

        [HttpPost, Route("Save")]
        public RedirectResult Save(WriteConferenceScheduleViewModel cs)
        {
            if (cs.Event.EventName == "Session")
            {
                db.Slot.Add(cs.Slot);                
            }
            db.Event.Add(cs.Event);

            db.SaveChanges();

            return Redirect("http://localhost:9459/ConferenceSchedule/Schedule");
        }

        [HttpGet, Route("Schedule")]
        public ViewResult Schedule()
        {
            List<Session> Session;
            ReadConferenceScheduleViewModel cs = new ReadConferenceScheduleViewModel();

            cs.Event = db.Event.ToList();
            cs.Slot = db.Slot.ToList();

            Session = db.Session.ToList();

            for (var i = 0; i > cs.Slot.Count; i++)
            {
                for (var x = 0; x > Session.Count; x++)
                {
                    if (cs.Slot[i].slotId == Session[x].slotId)
                    {
                        cs.Slot[i].Session.Add(Session[x]);
                    }
                }
            }

            return View(cs);
        }

        // For Filtering by days..not done yet...old version
        //[HttpGet, Route("Schedule/{day}")]
        //public ViewResult Schedule(string day)
        //{
        //    var schedule = db.ConferenceSchedule.Where(s => s.Day == day).ToList();
        //    return View(schedule);
        //}
    }
}