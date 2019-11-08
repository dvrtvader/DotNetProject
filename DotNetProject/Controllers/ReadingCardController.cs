using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetProject.Data;
using DotNetProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace DotNetProject.Controllers
{
    public class ReadingCardController : Controller
    {
        private readonly BooksContext _context;

        public ReadingCardController(BooksContext context)
        {
            _context = context;
        }

        // GET: ReadingCard
        public async Task<IActionResult> Index()
        {
            var bookContext = _context.ReadingCard.Include(s => s.user);
            return View(await bookContext.ToListAsync());
        }

        // GET: ReadingCard/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var readingCard = await _context.ReadingCard
                .Include(s => s.user)
                .FirstOrDefaultAsync(m => m.id == id);
            if (readingCard == null)
            {
                return NotFound();
            }

            return View(readingCard);
        }

        // GET: ReadingCard/Create
        public IActionResult Create()
        {
            ViewData["userId"] = new SelectList(_context.User, "id", "id");
            return View();
        }

        // POST: ReadingCard/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,userId")] ReadingCard readingCard)
        {
            if (ModelState.IsValid)
            {
                _context.Add(readingCard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["userId"] = new SelectList(_context.User, "id", "id", readingCard.userId);
            return View(readingCard);
        }

        // GET: ReadingCard/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var readingCard = await _context.ReadingCard.FindAsync(id);
            if (readingCard == null)
            {
                return NotFound();
            }
            ViewData["userId"] = new SelectList(_context.User, "id", "id", readingCard.userId);
            return View(readingCard);
        }

        // POST: ReadingCard/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,userId")] ReadingCard readingCard)
        {
            if (id != readingCard.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(readingCard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReadingCardExists(readingCard.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["userId"] = new SelectList(_context.User, "id", "id", readingCard.userId);
            return View(readingCard);
        }

        // GET: ReadingCard/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var readingCard = await _context.ReadingCard
                .Include(s => s.user)
                .FirstOrDefaultAsync(m => m.id == id);
            if (readingCard == null)
            {
                return NotFound();
            }

            return View(readingCard);
        }

        // POST: ReadingCard/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shoppingCart = await _context.ReadingCard.FindAsync(id);
            _context.ReadingCard.Remove(shoppingCart);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReadingCardExists(int id)
        {
            return _context.ReadingCard.Any(e => e.id == id);
        }
    }
}