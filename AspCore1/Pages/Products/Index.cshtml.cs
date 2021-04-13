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
    public class IndexModel : PageModel
    {
        private readonly AspCore1.Data.EntityContext _context;

        public IndexModel(AspCore1.Data.EntityContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            var minPrice=5;
            Product = await _context.products.FromSqlInterpolated($"Select * from products where price>{minPrice}").ToListAsync();
        }
    }
}
