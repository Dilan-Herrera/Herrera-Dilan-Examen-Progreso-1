using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Herrera_Dilan_Examen_Progreso_1.Data;
using Herrera_Dilan_Examen_Progreso_1.Models;

namespace Herrera_Dilan_Examen_Progreso_1.Controllers
{
    public class HerrerasController : Controller
    {
        private readonly Herrera_Dilan_Examen_Progreso_1Context _context;

        public HerrerasController(Herrera_Dilan_Examen_Progreso_1Context context)
        {
            _context = context;
        }

        // GET: Herreras
        public async Task<IActionResult> Index()
        {
            var herrera_Dilan_Examen_Progreso_1Context = _context.Herrera.Include(h => h.Celular);
            return View(await herrera_Dilan_Examen_Progreso_1Context.ToListAsync());
        }

        // GET: Herreras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var herrera = await _context.Herrera
                .Include(h => h.Celular)
                .FirstOrDefaultAsync(m => m.Cedula == id);
            if (herrera == null)
            {
                return NotFound();
            }

            return View(herrera);
        }

        // GET: Herreras/Create
        public IActionResult Create()
        {
            ViewData["IdCelular"] = new SelectList(_context.Set<Celular>(), "Id", "Modelo");
            return View();
        }

        // POST: Herreras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Cedula,PesoKg,Nombre,Estudiante,FechaNacimiento,IdCelular")] Herrera herrera)
        {
            if (ModelState.IsValid)
            {
                _context.Add(herrera);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCelular"] = new SelectList(_context.Set<Celular>(), "Id", "Modelo", herrera.IdCelular);
            return View(herrera);
        }

        // GET: Herreras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var herrera = await _context.Herrera.FindAsync(id);
            if (herrera == null)
            {
                return NotFound();
            }
            ViewData["IdCelular"] = new SelectList(_context.Set<Celular>(), "Id", "Modelo", herrera.IdCelular);
            return View(herrera);
        }

        // POST: Herreras/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Cedula,PesoKg,Nombre,Estudiante,FechaNacimiento,IdCelular")] Herrera herrera)
        {
            if (id != herrera.Cedula)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(herrera);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HerreraExists(herrera.Cedula))
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
            ViewData["IdCelular"] = new SelectList(_context.Set<Celular>(), "Id", "Modelo", herrera.IdCelular);
            return View(herrera);
        }

        // GET: Herreras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var herrera = await _context.Herrera
                .Include(h => h.Celular)
                .FirstOrDefaultAsync(m => m.Cedula == id);
            if (herrera == null)
            {
                return NotFound();
            }

            return View(herrera);
        }

        // POST: Herreras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var herrera = await _context.Herrera.FindAsync(id);
            if (herrera != null)
            {
                _context.Herrera.Remove(herrera);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HerreraExists(int id)
        {
            return _context.Herrera.Any(e => e.Cedula == id);
        }
    }
}
