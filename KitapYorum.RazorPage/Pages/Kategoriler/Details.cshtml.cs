using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KitapYorum.Entites.Concrete;
using KitapYorum.Entites.Contexts;

namespace KitapYorum.RazorPage.Pages.Kategoriler
{
    public class DetailsModel : PageModel
    {
        private readonly KitapYorum.Entites.Contexts.AppDbContext _context;

        public DetailsModel(KitapYorum.Entites.Contexts.AppDbContext context)
        {
            _context = context;
        }

        public Kategori Kategori { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kategori = await _context.Kategoriler.FirstOrDefaultAsync(m => m.Id == id);
            if (kategori == null)
            {
                return NotFound();
            }
            else
            {
                Kategori = kategori;
            }
            return Page();
        }
    }
}
