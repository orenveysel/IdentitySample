using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KitapYorum.RazorPage.Pages.Roller
{
    public class CreateModel(RoleManager<IdentityRole> roleManager) : PageModel
    {
        [BindProperty]
        public IdentityRole Role { get; set; }
        public void OnGet()
        {
            Role = new();
        }
        public async Task<IActionResult> OnPost()
        {
           var result =  await roleManager.CreateAsync(Role);
            
            if (result.Succeeded)
            {
                return RedirectToPage("Index");

            }
            return Page();
        }
    }
}
