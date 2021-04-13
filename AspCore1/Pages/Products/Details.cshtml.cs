using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AspCore1.Data;
using AspCore1.Models;

namespace AspCore1.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly AspCore1.Data.EntityContext _context;

        public DetailsModel(AspCore1.Data.EntityContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

			Product = await _context.products.AsNoTracking().FirstOrDefaultAsync(m => m.Id == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
