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
                Session ts = new Session();
                for (var i = 0; i < cs.Slot.Session.Count; i++)
                {
                    ts.conference = cs.Slot.Session[i].conference;
                    ts.title = cs.Slot.Session[i].title;
                    ts.authors = cs.Slot.Session[i].authors;


                    db.Session.Add(ts);
                }
                db.Slot.Add(cs.Slot);                
            }
            db.Event.Add(cs.Event);

            db.SaveChanges();

            return Redirect("http://localhost:9459/ConferenceSchedule/Schedule");
        }

        [HttpGet, Route("Schedule")]
        public ViewResult Schedule()
        {
            ReadConferenceScheduleViewModel cs = new ReadConferenceScheduleViewModel();
            cs.Event = db.Event.ToList();
            cs.Slot = db.Slot.ToList();
            cs.Session = db.Session.ToList();

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