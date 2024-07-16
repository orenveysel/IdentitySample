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
    public class IndexModel : PageModel
    {
        private readonly KitapYorum.Entites.Contexts.AppDbContext _context;

        public IndexModel(KitapYorum.Entites.Contexts.AppDbContext context)
        {
            _context = context;
        }

        public IList<Kategori> Kategori { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Kategori = await _context.Kategoriler
                .Include(k => k.MyUser).ToListAsync();
        }
    }
}
