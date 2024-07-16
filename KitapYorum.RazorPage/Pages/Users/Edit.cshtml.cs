using KitapYorum.Entites.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KitapYorum.RazorPage.Pages.Users
{
    public class EditModel(UserManager<MyUser> userManager) : PageModel
    {

        public MyUser myUser { get; set; }
        public async Task OnGet(string id)
        {
           var  myUser = await userManager.FindByIdAsync(id);
        }
    }
}
