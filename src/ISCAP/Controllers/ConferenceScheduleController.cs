using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ISCAP.Models;
using ISCAP.Data;

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
            var entireSchedule = db.ConferenceSchedule.ToList();
            return View(entireSchedule);
        }

        [HttpGet, Route("Schedule/{day}")]
        public ViewResult Schedule(string day)
        {
            var schedule = db.ConferenceSchedule.Where(s => s.Day == day).ToList();
            return View(schedule);
        }
    }
}