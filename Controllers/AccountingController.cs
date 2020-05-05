using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PROLab.Data;
using PROLab.Models.DataModels;

namespace PROLab.Controllers
{
    public class AccountingController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountingController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Accounting
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Accounting
                .Include(a => a.Account)
                .Include(a => a.Transaction);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Accounting/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accounting = await _context.Accounting
                .Include(a => a.Account)
                .Include(a => a.Transaction)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (accounting == null)
            {
                return NotFound();
            }

            return View(accounting);
        }

        // GET: Accounting/Create
        public IActionResult Create()
        {
            ViewData["AccountId"] = new SelectList(_context.Account, "Id", "Id");
            ViewData["TransactionId"] = new SelectList(_context.Transaction, "Id", "Id");
            return View();
        }

        // POST: Accounting/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AccountId,TransactionId,ReferensNumber")] Accounting accounting)
        {
            if (ModelState.IsValid)
            {
                _context.Add(accounting);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AccountId"] = new SelectList(_context.Account, "Id", "Id", accounting.AccountId);
            ViewData["TransactionId"] = new SelectList(_context.Transaction, "Id", "Id", accounting.TransactionId);
            return View(accounting);
        }

        // GET: Accounting/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accounting = await _context.Accounting.FindAsync(id);
            if (accounting == null)
            {
                return NotFound();
            }
            ViewData["AccountId"] = new SelectList(_context.Account, "Id", "Id", accounting.AccountId);
            ViewData["TransactionId"] = new SelectList(_context.Transaction, "Id", "Id", accounting.TransactionId);
            return View(accounting);
        }

        // POST: Accounting/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AccountId,TransactionId,ReferensNumber")] Accounting accounting)
        {
            if (id != accounting.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(accounting);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountingExists(accounting.Id))
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
            ViewData["AccountId"] = new SelectList(_context.Account, "Id", "Id", accounting.AccountId);
            ViewData["TransactionId"] = new SelectList(_context.Transaction, "Id", "Id", accounting.TransactionId);
            return View(accounting);
        }

        // GET: Accounting/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accounting = await _context.Accounting
                .Include(a => a.Account)
                .Include(a => a.Transaction)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (accounting == null)
            {
                return NotFound();
            }

            return View(accounting);
        }

        // POST: Accounting/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var accounting = await _context.Accounting.FindAsync(id);
            _context.Accounting.Remove(accounting);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccountingExists(int id)
        {
            return _context.Accounting.Any(e => e.Id == id);
        }
    }
}
