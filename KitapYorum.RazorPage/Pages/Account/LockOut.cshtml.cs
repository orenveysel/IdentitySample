using KitapYorum.Entites.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KitapYorum.RazorPage.Pages.Account
{
    public class LockoutModel(SignInManager<MyUser> signInManager) : PageModel
    {
        public void OnGet()
        {
           

        }
    }
}
