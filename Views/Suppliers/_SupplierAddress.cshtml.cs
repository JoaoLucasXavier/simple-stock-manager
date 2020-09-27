using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using simple_stock_manager.Data;
using simple_stock_manager.Models;

namespace simple_stock_manager.Views_Suppliers
{
    public class _SupplierAddressModel : PageModel
    {
        private readonly simple_stock_manager.Data.ApplicationDbContext _context;

        public _SupplierAddressModel(simple_stock_manager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["SupplierId"] = new SelectList(_context.Suppliers, "Id", "Document");
            return Page();
        }

        [BindProperty]
        public SupplierAddress SupplierAddress { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.SuppliersAddress.Add(SupplierAddress);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
