using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PROLab.Data;
using PROLab.Models.DataModels;
using PROLab.Models.ViewModels;

namespace PROLab.Controllers
{
    public class PhysicalSamplingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PhysicalSamplingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PhysicalSamplings
        public async Task<IActionResult> Index()
        {
            return View(await _context.PhysicalSampling.ToListAsync());
        }

        public IActionResult ListPHSamplings()
        {
            var mDSViewModel = new MDSViewModel()
            {
                PhysicalSamplings = _context.PhysicalSampling
                .ToList()
            };
            return View(mDSViewModel);
        }

        // GET: PhysicalSamplings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var physicalSampling = await _context.PhysicalSampling
                .FirstOrDefaultAsync(m => m.Id == id);
            if (physicalSampling == null)
            {
                return NotFound();
            }

            return View(physicalSampling);
        }

        // GET: PhysicalSamplings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PhysicalSamplings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DateTimeSampleTaken,BloodPressure,Oxygenation,BodyTemperature,Comment")] PhysicalSampling physicalSampling)
        {
            if (ModelState.IsValid)
            {
                _context.Add(physicalSampling);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ListPHSamplings));
            }
            return View(physicalSampling);
        }

        // GET: PhysicalSamplings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var physicalSampling = await _context.PhysicalSampling.FindAsync(id);
            if (physicalSampling == null)
            {
                return NotFound();
            }
            return View(physicalSampling);
        }

        // POST: PhysicalSamplings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DateTimeSampleTaken,BloodPressure,Oxygenation,BodyTemperature,Comment")] PhysicalSampling physicalSampling)
        {
            if (id != physicalSampling.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(physicalSampling);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhysicalSamplingExists(physicalSampling.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ListPHSamplings));
            }
            return View(physicalSampling);
        }

        // GET: PhysicalSamplings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var physicalSampling = await _context.PhysicalSampling
                .FirstOrDefaultAsync(m => m.Id == id);
            if (physicalSampling == null)
            {
                return NotFound();
            }

            return View(physicalSampling);
        }

        // POST: PhysicalSamplings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var physicalSampling = await _context.PhysicalSampling.FindAsync(id);
            _context.PhysicalSampling.Remove(physicalSampling);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ListPHSamplings));
        }

        private bool PhysicalSamplingExists(int id)
        {
            return _context.PhysicalSampling.Any(e => e.Id == id);
        }
    }
}
