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
                db.Room.Add(cs.Room);
            }
            db.Event.Add(cs.Event);

            db.SaveChanges();

            return Redirect("http://localhost:9459/ConferenceSchedule/Schedule");
        }

        [HttpGet, Route("Schedule")]
        public ViewResult Schedule()
        {
            List<Slot> Slot;
            ReadConferenceScheduleViewModel cs = new ReadConferenceScheduleViewModel();

            cs.Event = db.Event.ToList();
            cs.Room = db.Room.ToList();

            Slot = db.Slot.ToList();

            for (var i = 0; i > cs.Room.Count; i++)
            {
                for (var x = 0; x > Slot.Count; x++)
                {
                    if (cs.Room[i].roomId == Slot[x].roomId)
                    {
                        cs.Room[i].Slot.Add(Slot[x]);
                    }
                }
            }

            return View(cs);
        }

        [HttpGet, Route("PanelForm")]
        public ViewResult PanelForm()
        {

            return View();
        }

        [HttpPost, Route("PanelSave")]
        public ContentResult PanelSave(Panel p)
        {
            db.Panel.Add(p);

            return Content("Abstract Data Saved");
        }
        [HttpGet, Route("WorkShopForm")]
        public ViewResult WorkShopForm()
        {

            return View();
        }
        [HttpPost, Route("WorkShopSave")]
        public ContentResult WorkShopSave(Workshop w)
        {
            db.WorkShop.Add(w);

            return Content("WorkShop Data Saved");
        }

        [HttpGet, Route("AbstractForm")]
        public ViewResult AbstractForm()
        {

            return View();
        }

        [HttpPost, Route("AbstractSave")]
        public ContentResult AbstractSave(Abstract a)
        {
            db.Abstract.Add(a);

            return Content("Abstract Data Saved");
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