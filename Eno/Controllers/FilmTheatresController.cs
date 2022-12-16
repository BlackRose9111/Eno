using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Eno.Data;
using Eno.Models;

namespace Eno.Controllers
{
    public class FilmTheatresController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FilmTheatresController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FilmTheatres
        public async Task<IActionResult> Index()
        {
            
              return View(await _context.FilmTheatre.ToListAsync());
        }

        // GET: FilmTheatres/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.FilmTheatre == null)
            {
                return NotFound();
            }

            var filmTheatre = await _context.FilmTheatre
                .FirstOrDefaultAsync(m => m.Id == id);
            if (filmTheatre == null)
            {
                return NotFound();
            }

            return View(filmTheatre);
        }

        // GET: FilmTheatres/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FilmTheatres/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] FilmTheatres filmTheatre)
        {
            if (ModelState.IsValid)
            {
                _context.Add(filmTheatre);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(filmTheatre);
        }

        // GET: FilmTheatres/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.FilmTheatre == null)
            {
                return NotFound();
            }

            var filmTheatre = await _context.FilmTheatre.FindAsync(id);
            if (filmTheatre == null)
            {
                return NotFound();
            }
            return View(filmTheatre);
        }

        // POST: FilmTheatres/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] FilmTheatres filmTheatre)
        {
            if (id != filmTheatre.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(filmTheatre);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FilmTheatreExists(filmTheatre.Id))
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
            return View(filmTheatre);
        }

        // GET: FilmTheatres/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.FilmTheatre == null)
            {
                return NotFound();
            }

            var filmTheatre = await _context.FilmTheatre
                .FirstOrDefaultAsync(m => m.Id == id);
            if (filmTheatre == null)
            {
                return NotFound();
            }

            return View(filmTheatre);
        }

        // POST: FilmTheatres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.FilmTheatre == null)
            {
                return Problem("Entity set 'ApplicationDbContext.FilmTheatre'  is null.");
            }
            var filmTheatre = await _context.FilmTheatre.FindAsync(id);
            if (filmTheatre != null)
            {
                _context.FilmTheatre.Remove(filmTheatre);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FilmTheatreExists(int id)
        {
          return _context.FilmTheatre.Any(e => e.Id == id);
        }
    }
}
