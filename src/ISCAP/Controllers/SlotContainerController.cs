using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ISCAP.Models;
using ISCAP.Data;

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

        [HttpGet, Route("Form")]
        public IActionResult SlotContainer()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SaveSlot([Bind("slotId,conference,title,authors,slotTime")] Slot slot)
        {
            /*Slot sl = new Slot();
            sl.title = HttpContext.Request.Form["txtTitle"].ToString();
            sl.conference = HttpContext.Request.Form["txtConference"].ToString();
            sl.authors = HttpContext.Request.Form["txtAuthors"].ToString();
            sl.slotTime = Convert.ToInt32(HttpContext.Request.Form["txtSlotTime"]);*/

            if (ModelState.IsValid)
            {
                _context.Add(slot);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(slot);
        }
    }
}