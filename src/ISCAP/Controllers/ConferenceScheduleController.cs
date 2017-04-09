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
            return View();
        }

        [HttpGet, Route("SessionForm")]
        public ViewResult SessionForm()
        {
            SessionDetail sd = new SessionDetail();
            sd.number = 0;
            return View(sd);
        }

        [HttpPost, Route("SessionForm")]
        public ViewResult SessionForm(SessionDetail sd)
        {
            return View(sd);
        }

        [HttpPost, Route("SessionSaveForm")]
        public ContentResult SessionSaveForm(SessionDetail form)
        {
            
            Session tSession = new Session();
            for (var i = 0; i < form.Session.Count; i++)
            {
                tSession.conference = form.Session[i].conference;
                tSession.title = form.Session[i].title;
                tSession.authors = form.Session[i].authors;
                

                db.Session.Add(tSession);
            }

            db.SessionDetail.Add(form);
            db.SaveChanges();


            return Content("SessionSaveForm Works!");
        }


        [HttpPost, Route("SaveForm")]
        public ContentResult SaveChange(ConferenceSchedule form)
        {
            db.ConferenceSchedule.Add(form);

            db.SaveChanges();

            return Content("all data saved.");
        }

        [HttpGet, Route("Schedule")]
        public ViewResult Schedule()
        {
            ConferenceScheduleViewModel cs = new ConferenceScheduleViewModel();
            cs.ConferenceSchedule = db.ConferenceSchedule.ToList();
            cs.SessionDetail = db.SessionDetail.ToList();
            cs.Session = db.Session.ToList();
            
            return View(cs);
        }

        [HttpGet, Route("Schedule/{day}")]
        public ViewResult Schedule(string day)
        {
            var schedule = db.ConferenceSchedule.Where(s => s.Day == day).ToList();
            return View(schedule);
        }
    }
}