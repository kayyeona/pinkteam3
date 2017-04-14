using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ISCAP.Data;
using ISCAP.Models;

namespace ISCAP.Controllers
{
    public class PaperDetailsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PaperDetailsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: PaperDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.PaperDetails.ToListAsync());
        }

        // GET: PaperDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paperDetails = await _context.PaperDetails.SingleOrDefaultAsync(m => m.ID == id);
            if (paperDetails == null)
            {
                return NotFound();
            }

            return View(paperDetails);
        }

        // GET: PaperDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PaperDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,LastUpdate,PaperStatus,PaperTitle,TrackId")] PaperDetails paperDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(paperDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(paperDetails);
        }

        // GET: PaperDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paperDetails = await _context.PaperDetails.SingleOrDefaultAsync(m => m.ID == id);
            if (paperDetails == null)
            {
                return NotFound();
            }
            return View(paperDetails);
        }

        // POST: PaperDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,LastUpdate,PaperStatus,PaperTitle,TrackId")] PaperDetails paperDetails)
        {
            if (id != paperDetails.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(paperDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PaperDetailsExists(paperDetails.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(paperDetails);
        }

        // GET: PaperDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paperDetails = await _context.PaperDetails.SingleOrDefaultAsync(m => m.ID == id);
            if (paperDetails == null)
            {
                return NotFound();
            }

            return View(paperDetails);
        }

        // POST: PaperDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var paperDetails = await _context.PaperDetails.SingleOrDefaultAsync(m => m.ID == id);
            _context.PaperDetails.Remove(paperDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool PaperDetailsExists(int id)
        {
            return _context.PaperDetails.Any(e => e.ID == id);
        }
    }
}
