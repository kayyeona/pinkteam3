using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ISCAP.Data;
using ISCAP.Models;

namespace ISCAP.Controllers
{
    public class SlotBlockController : Controller
    {
        public readonly ApplicationDbContext _context;
        
        public SlotBlockController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(Slot Slot)
        {
            if(Slot.slotId == 0)
            {
                ModelState.AddModelError("", "Select Slot");
            }

            int SelectValue = Slot.slotId;

            ViewBag.SelectedValue = Slot.slotId;

            List<Slot> slotList = new List<Slot>();

            slotList = (from block in _context.Slot select block).ToList();

            slotList.Insert(0, new Slot { slotId = 0, title = "Select" });

            ViewBag.ListOfSlots = slotList;
            return View();
        }

        /*[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SaveSlotBlock([Bind("slotBlockId,title")] SlotBlock slotBlock)
        {
            if (ModelState.IsValid)
            {

                _context.Add(slotBlock);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(slotBlock);
        }*/
    }
}