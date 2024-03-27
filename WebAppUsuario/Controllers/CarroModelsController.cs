using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppUsuario.Data;
using WebAppUsuario.Models;

namespace WebAppUsuario.Controllers
{
    public class CarroModelsController : Controller
    {
        private readonly WebAppUsuarioContext _context;

        public CarroModelsController(WebAppUsuarioContext context)
        {
            _context = context;
        }

        // GET: CarroModels
        public async Task<IActionResult> Index()
        {
              return _context.CarroModel != null ? 
                          View(await _context.CarroModel.ToListAsync()) :
                          Problem("Entity set 'WebAppUsuarioContext.CarroModel'  is null.");
        }

        // GET: CarroModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CarroModel == null)
            {
                return NotFound();
            }

            var carroModel = await _context.CarroModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carroModel == null)
            {
                return NotFound();
            }

            return View(carroModel);
        }

        // GET: CarroModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CarroModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Marca,Modelo,DataFabricacao")] CarroModel carroModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carroModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carroModel);
        }

        // GET: CarroModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CarroModel == null)
            {
                return NotFound();
            }

            var carroModel = await _context.CarroModel.FindAsync(id);
            if (carroModel == null)
            {
                return NotFound();
            }
            return View(carroModel);
        }

        // POST: CarroModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Marca,Modelo,DataFabricacao")] CarroModel carroModel)
        {
            if (id != carroModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carroModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarroModelExists(carroModel.Id))
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
            return View(carroModel);
        }

        // GET: CarroModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CarroModel == null)
            {
                return NotFound();
            }

            var carroModel = await _context.CarroModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carroModel == null)
            {
                return NotFound();
            }

            return View(carroModel);
        }

        // POST: CarroModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CarroModel == null)
            {
                return Problem("Entity set 'WebAppUsuarioContext.CarroModel'  is null.");
            }
            var carroModel = await _context.CarroModel.FindAsync(id);
            if (carroModel != null)
            {
                _context.CarroModel.Remove(carroModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarroModelExists(int id)
        {
          return (_context.CarroModel?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
