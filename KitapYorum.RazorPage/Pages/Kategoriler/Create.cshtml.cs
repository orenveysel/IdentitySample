using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using KitapYorum.Entites.Concrete;
using KitapYorum.Entites.Contexts;

namespace KitapYorum.RazorPage.Pages.Kategoriler
{
    public class CreateModel : PageModel
    {
        private readonly KitapYorum.Entites.Contexts.AppDbContext _context;

        public CreateModel(KitapYorum.Entites.Contexts.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["MyUserId"] = new SelectList(_context.Users, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Kategori Kategori { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Kategoriler.Add(Kategori);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
