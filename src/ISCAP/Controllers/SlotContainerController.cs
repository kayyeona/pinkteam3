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

        public IActionResult Index(Slot Slot)
        {
            int SelectValue = Slot.slotId;

            ViewBag.SelectedValue = Slot.slotId;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SaveSlot([Bind("slotId,conference,title,authors,slotTime")] Slot slot)
        {
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