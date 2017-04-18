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
    public class ReviewerPapersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReviewerPapersController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: ReviewerPapers
        public async Task<IActionResult> Index()
        {
            return View(await _context.ReviewerPapers.ToListAsync());
        }

        // GET: ReviewerPapers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reviewerPapers = await _context.ReviewerPapers.SingleOrDefaultAsync(m => m.ID == id);
            if (reviewerPapers == null)
            {
                return NotFound();
            }

            return View(reviewerPapers);
        }

        // GET: ReviewerPapers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ReviewerPapers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,LastUpdate,PaperStatus,PaperTitle,TrackId")] ReviewerPapers reviewerPapers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reviewerPapers);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(reviewerPapers);
        }

        // GET: ReviewerPapers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reviewerPapers = await _context.ReviewerPapers.SingleOrDefaultAsync(m => m.ID == id);
            if (reviewerPapers == null)
            {
                return NotFound();
            }
            return View(reviewerPapers);
        }

        // POST: ReviewerPapers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,LastUpdate,PaperStatus,PaperTitle,TrackId")] ReviewerPapers reviewerPapers)
        {
            if (id != reviewerPapers.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reviewerPapers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReviewerPapersExists(reviewerPapers.ID))
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
            return View(reviewerPapers);
        }

        // GET: ReviewerPapers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reviewerPapers = await _context.ReviewerPapers.SingleOrDefaultAsync(m => m.ID == id);
            if (reviewerPapers == null)
            {
                return NotFound();
            }

            return View(reviewerPapers);
        }

        // POST: ReviewerPapers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reviewerPapers = await _context.ReviewerPapers.SingleOrDefaultAsync(m => m.ID == id);
            _context.ReviewerPapers.Remove(reviewerPapers);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ReviewerPapersExists(int id)
        {
            return _context.ReviewerPapers.Any(e => e.ID == id);
        }
    }
}
