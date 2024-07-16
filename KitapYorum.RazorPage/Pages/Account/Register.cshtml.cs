using KitapYorum.Entites.Concrete;
using KitapYorum.RazorPage.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text;

namespace KitapYorum.RazorPage.Pages.Account
{
    public class RegisterModel(UserManager<MyUser> userManager,RoleManager<IdentityRole> roleManager) : PageModel
    {
        [BindProperty]
        public UserInsertVM CreateUser { get; set; }

        [BindProperty]
        public List<CheckBoxVM> Roller { get; set; } = new List<CheckBoxVM>();
        public void OnGet()
        {
            CreateUser = new();
            var rols = roleManager.Roles.ToList();
            foreach (var item in rols)
            {
                CheckBoxVM check = new CheckBoxVM();
                check.Id = item.Id;
                check.LabelName = item.Name;
                Roller.Add(check);
            }
        }
        public async Task<IActionResult> OnPost()
        {
            // MyUser 'dan instance alip gerekli alanlari  dolduruyoruz
            MyUser myUser = new MyUser()
            {
                Email = CreateUser.Email,
                UserName = CreateUser.Email,
                TcNo = CreateUser.TcNo
            };
            // olusturdugumuz myuser'i database 2 kaydediyoruz
            var result = await userManager.CreateAsync(myUser, CreateUser.Password);

            //Eger kullanici olustu ise bu defa secilen rolleri ekliyoruz
            if (result.Succeeded)
            {
                //userManager.AddToRolesAsync(myUser, Roller.Where(p => p.IsChecked == true).Select(p => p.LabelName).AsEnumerable());
               
                    await userManager.AddToRoleAsync(myUser,"Uye");

                var code = await userManager.GenerateEmailConfirmationTokenAsync(myUser);
            
                StringBuilder message = new StringBuilder();
                message.AppendLine("<html>");
                message.AppendLine("<Head>");
                message.AppendLine("<meta charset='UTF-8' />");

                message.AppendLine("</Head>");
                message.AppendLine("<body>");

                message.AppendLine($"<p> Merhaba {myUser.UserName}  </p> <br>");

                message.AppendLine("<p> Uyelik islemlerini tamamlamak icin asagidaki linki tiklayin </p>");

                message.AppendLine($"<a href='https://localhost:7214/ConfirmEmail?uid={myUser.Id}&code={code}'> Onaylayin </a>");


                message.AppendLine("</body>");


                message.AppendLine("</html>");

                EmailHelper email = new EmailHelper();

                bool sonuc = email.SendEmail(myUser.Email, message.ToString());

                if (sonuc)
                {
                    return RedirectToPage("/Index");

                }
                else
                {
                    ModelState.AddModelError("", "Mail Goderiminde hata olustu");
                    return Page();
                }

            }
            else
            {
                var error = result.Errors.FirstOrDefault();
                ModelState.AddModelError("", error.Description);
                return Page();
            }

            return RedirectToPage("Index");
        }
    }
}
