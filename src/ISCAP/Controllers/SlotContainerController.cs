using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ISCAP.Models;
using ISCAP.Data;
using static ISCAP.Models.GetConString;

namespace ISCAP.Controllers
{
    public class SlotContainerController : Controller
    {
        public ApplicationDbContext _context { get; set; }

        public SlotContainerController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        /*public IActionResult PanelDropDown(Panel Panel)
        {
            if (Panel.panelId == 0)
            {
                ModelState.AddModelError("", "Select Panel");
            }

            int SelectValue = Panel.panelId;

            ViewBag.SelectedValue = Panel.panelId;

            List<Panel> panelList = new List<Panel>();

            panelList = (from block in _context.Panel select block).ToList();

            panelList.Insert(0, new Panel { panelId = 0, panelTitle = "Select" });

            ViewBag.ListOfPanels = panelList;
            return View();
        }

        public IActionResult WorkShopDropDown(Workshop Workshop)
        {
            if (Workshop.workShopId == 0)
            {
                ModelState.AddModelError("", "Select Workshop");
            }

            int SelectValue = Workshop.workShopId;

            ViewBag.SelectedValue = Workshop.workShopId;

            List<Workshop> workShopList = new List<Workshop>();

            workShopList = (from block in _context.WorkShop select block).ToList();

            workShopList.Insert(0, new Workshop { workShopId = 0, workShoptitle = "Select" });

            ViewBag.ListOfWorkShops = workShopList;
            return View();
        }

        public IActionResult EventDropDown(Event Event)
        {
            if (Event.eventID == 0)
            {
                ModelState.AddModelError("", "Select Event");
            }

            int SelectValue = Event.eventID;

            ViewBag.SelectedValue = Event.eventID;

            List<Event> eventList = new List<Event>();

            eventList = (from block in _context.Event select block).ToList();

            eventList.Insert(0, new Event { eventID = 0, EventName = "Select" });

            ViewBag.ListOfEvents = eventList;
            return View();
        }

        public IActionResult AbstractDropDown(Abstract Abstract)
        {
            if (Abstract.AbstractID == 0)
            {
                ModelState.AddModelError("", "Select Abstract");
            }

            int SelectValue = Abstract.AbstractID;

            ViewBag.SelectedValue = Abstract.AbstractID;

            List<Abstract> abstractList = new List<Abstract>();

            abstractList = (from block in _context.Abstract select block).ToList();

            abstractList.Insert(0, new Abstract { AbstractID = 0, Title = "Select" });

            ViewBag.ListOfEvents = abstractList;
            return View();
        }*/

        public IActionResult Slot()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetDetails()
        {
            Slot slot = new Slot();
            slot.title = HttpContext.Request.Form["txtTitle"].ToString();
            slot.conference = HttpContext.Request.Form["txtConference"].ToString();
            slot.authors = HttpContext.Request.Form["txtAuthors"].ToString();
            slot.slotTime = Convert.ToInt32(HttpContext.Request.Form["txtSlot Time"]);

            int result = slot.SaveDetails();
            if (result > 0)
            {
                ViewBag.Result = "Data Saved Successfully";
            }
            else
            {
                ViewBag.Result = "Something Went Wrong";
            }
            return View("Index");
        }
    }
}