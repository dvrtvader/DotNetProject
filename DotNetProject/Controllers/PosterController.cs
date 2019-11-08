using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetProject.Data;
using DotNetProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNetProject.Controllers
{
    public class PosterController : Controller
    {
        private readonly BooksContext _context;

        public PosterController(BooksContext context)
        {
            _context = context;
        }

        // GET: Poster
        public async Task<IActionResult> Index()
        {
            return View(await _context.Poster.ToListAsync());
        }

        [HttpPost]
        public JsonResult validatePosterName(string name)
        {
            return Json(!_context.Poster.Any(poster => poster.name == name));
        }

        // GET: Poster/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poster = await _context.Poster
                .FirstOrDefaultAsync(m => m.id == id);
            if (poster == null)
            {
                return NotFound();
            }

            return View(poster);
        }

        // GET: Poster/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Poster/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,name")] Poster poster)
        {
            if (ModelState.IsValid)
            {
                _context.Add(poster);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(poster);
        }

        // GET: Poster/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poster = await _context.Poster.FindAsync(id);
            if (poster == null)
            {
                return NotFound();
            }
            return View(poster);
        }

        // POST: Poster/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,name")] Poster poster)
        {
            if (id != poster.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(poster);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PosterExists(poster.id))
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
            return View(poster);
        }

        // GET: Poster/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poster = await _context.Poster
                .FirstOrDefaultAsync(m => m.id == id);
            if (poster == null)
            {
                return NotFound();
            }

            return View(poster);
        }

        // POST: Poster/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var poster = await _context.Poster.FindAsync(id);
            _context.Poster.Remove(poster);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PosterExists(int id)
        {
            return _context.Poster.Any(e => e.id == id);
        }
    }
}