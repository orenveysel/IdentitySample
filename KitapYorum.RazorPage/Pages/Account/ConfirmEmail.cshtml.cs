using KitapYorum.Entites.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KitapYorum.RazorPage.Models;
namespace KitapYorum.RazorPage.Pages.Account
{
   
    public class ConfirmEmail(UserManager<MyUser> userManager) : PageModel
    {
        //public void OnGet()
        //{
        //}
       
        public async Task<IActionResult> OnGet(string uid, string code)
        {
            ConfirmEmailModel model = new ConfirmEmailModel();
            // model = new ;
            if (!string.IsNullOrEmpty(uid) && !string.IsNullOrEmpty(code))
            {
                var user = await userManager.FindByIdAsync(uid);
                code = code.Replace(' ', '+');
                model.Email = user.Email;
                var result = await userManager.ConfirmEmailAsync(user, code);

                if (result.Succeeded)
                {
                    return RedirectToPage("Index");
                }
                else
                {
                    var error = result.Errors.FirstOrDefault();
                    model.ErrorDescription = error.Description;
                    model.HasError = true;
                    ModelState.AddModelError("", error.Description);
                    return Page();
                }
            }
           
            return Page();
        }
    }
}
