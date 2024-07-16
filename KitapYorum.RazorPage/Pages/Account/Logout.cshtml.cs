using KitapYorum.Entites.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KitapYorum.RazorPage.Pages.Account
{
    public class LogoutModel(SignInManager<MyUser> signInManager) : PageModel
    {
        public async Task<IActionResult> OnGet()
        {
            await signInManager.SignOutAsync();
            return RedirectToPage("/Index");
        }
    }
}
