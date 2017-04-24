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
    public class ReviewerPaperController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReviewerPaperController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: ReviewerPaper
        public async Task<IActionResult> Index()
        {
            return View(await _context.ReviewerPaper.ToListAsync());
        }

        // GET: ReviewerPaper/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reviewerPaper = await _context.ReviewerPaper.SingleOrDefaultAsync(m => m.ID == id);
            if (reviewerPaper == null)
            {
                return NotFound();
            }

            return View(reviewerPaper);
        }

        // GET: ReviewerPaper/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ReviewerPaper/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,LastUpdate,PaperStatus,PaperTitle,TrackId")] ReviewerPaper reviewerPaper)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reviewerPaper);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(reviewerPaper);
        }

        // GET: ReviewerPaper/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reviewerPaper = await _context.ReviewerPaper.SingleOrDefaultAsync(m => m.ID == id);
            if (reviewerPaper == null)
            {
                return NotFound();
            }
            return View(reviewerPaper);
        }

        // POST: ReviewerPaper/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,LastUpdate,PaperStatus,PaperTitle,TrackId")] ReviewerPaper reviewerPaper)
        {
            if (id != reviewerPaper.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reviewerPaper);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReviewerPaperExists(reviewerPaper.ID))
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
            return View(reviewerPaper);
        }

        // GET: ReviewerPaper/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reviewerPaper = await _context.ReviewerPaper.SingleOrDefaultAsync(m => m.ID == id);
            if (reviewerPaper == null)
            {
                return NotFound();
            }

            return View(reviewerPaper);
        }

        // POST: ReviewerPaper/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reviewerPaper = await _context.ReviewerPaper.SingleOrDefaultAsync(m => m.ID == id);
            _context.ReviewerPaper.Remove(reviewerPaper);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ReviewerPaperExists(int id)
        {
            return _context.ReviewerPaper.Any(e => e.ID == id);
        }
    }
}
