using KitapYorum.Entites.Concrete;
using KitapYorum.RazorPage.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KitapYorum.RazorPage.Pages.Account
{
    public class LoginModel(SignInManager<MyUser> _signInManager ,UserManager<MyUser> userManager) : PageModel
    {
        [BindProperty]
        public LoginVm  LoginVm { get; set; }
        public void OnGet()
        {
            LoginVm=new LoginVm();
        }

        public async  Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Email yada þifre hatalidir");
                return Page();
            }
            else
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                //var myuser = await userManager.FindByEmailAsync(LoginVm.Email);
                var result = await _signInManager.PasswordSignInAsync( LoginVm.Email, LoginVm.Password, LoginVm.RememberMe, lockoutOnFailure: false);
                //var result = await _signInManager.PasswordSignInAsync(myuser, LoginVm.Password,LoginVm.RememberMe,false);
                if (result.Succeeded)
                {
                  
                    return RedirectToPage("/Index");
                }
               
                if (result.IsLockedOut)
                {
                  
                    return RedirectToPage("./Lockout");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Email yada password yanlis olabilir");
                    return Page();
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
