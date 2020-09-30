using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using simple_stock_manager.Data;
using simple_stock_manager.Models;

namespace simple_stock_manager.Controllers
{
    public class ShoppingController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShoppingController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Shopping
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Shopping.Include(s => s.Customer).Include(s => s.Product);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Shopping/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopping = await _context.Shopping
                .Include(s => s.Customer)
                .Include(s => s.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shopping == null)
            {
                return NotFound();
            }

            return View(shopping);
        }

        // GET: Shopping/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Name");
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name");
            return View();
        }

        // POST: Shopping/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,ProductId,Amount,PurchasePrice,PurchaseDate,Id")] Shopping shopping)
        {
            if (ModelState.IsValid)
            {
                shopping.Id = Guid.NewGuid();
                _context.Add(shopping);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Document", shopping.CustomerId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Description", shopping.ProductId);
            return View(shopping);
        }

        // GET: Shopping/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopping = await _context.Shopping.FindAsync(id);
            if (shopping == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Document", shopping.CustomerId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Description", shopping.ProductId);
            return View(shopping);
        }

        // POST: Shopping/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CustomerId,ProductId,Amount,PurchasePrice,PurchaseDate,Id")] Shopping shopping)
        {
            if (id != shopping.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shopping);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShoppingExists(shopping.Id))
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
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Document", shopping.CustomerId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Description", shopping.ProductId);
            return View(shopping);
        }

        // GET: Shopping/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopping = await _context.Shopping
                .Include(s => s.Customer)
                .Include(s => s.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shopping == null)
            {
                return NotFound();
            }

            return View(shopping);
        }

        // POST: Shopping/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var shopping = await _context.Shopping.FindAsync(id);
            _context.Shopping.Remove(shopping);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShoppingExists(Guid id)
        {
            return _context.Shopping.Any(e => e.Id == id);
        }
    }
}
