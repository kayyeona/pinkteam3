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
            List<Slot> slotList = new List<Slot>();

            slotList = (from item in _context.Slot select item).ToList();

            slotList.Insert(0, new Slot { slotId = 0, title = "Select" });

            return View();
        }

        [HttpGet, Route("Form")]
        public IActionResult SlotContainer()
        {
            Slot sl = new Slot();

            return View();
        }
    }
}