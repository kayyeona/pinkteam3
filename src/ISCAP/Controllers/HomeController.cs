using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ISCAP.ViewModel;
using ISCAP.Models;
using ISCAP.Data;


namespace ISCAP.Controllers
{

    public class HomeController : Controller
    {
        public ApplicationDbContext db;

        public HomeController(ApplicationDbContext db)
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
        public IActionResult Index()
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

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
