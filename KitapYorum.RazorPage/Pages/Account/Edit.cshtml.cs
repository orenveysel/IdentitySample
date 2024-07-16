using KitapYorum.Entites.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KitapYorum.RazorPage.Pages.Account
{
    public class EditModel(UserManager<MyUser> userManager) : PageModel
    {
        [BindProperty]
        public EditProfile  Profile { get; set; }
        public async Task OnGet(string id)
        {
           var myUSer = await userManager.FindByIdAsync(id);
            Profile = new EditProfile()
            {
                About=myUSer.About,
                Cinsiyet=myUSer.Cinsiyet,
                DogumTarihi=myUSer.DogumTarihi,
                Email=myUSer.Email,
                Id=id,
                PhoneNumber=myUSer.PhoneNumber,
                ImagePath=myUSer.ImagePath,
                TcNo=myUSer.TcNo,
                UserName=myUSer.UserName
                

            };
        }

        public async Task<IActionResult> OnPost()
        {
            return Page();
        }

        public class EditProfile : MyUser
        {
            public IFormFile? File { get; set; }
        }
    }
}
