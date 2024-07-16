using KitapYorum.Entites.Concrete;
using KitapYorum.RazorPage.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KitapYorum.RazorPage.Pages.Users
{
    public class CreateModel(UserManager<MyUser> userManager,RoleManager<IdentityRole> roleManager) : PageModel
    {

        [BindProperty]
        public UserInsertVM CreateUser { get; set; }

        [BindProperty]
        public List<CheckBoxVM> Roller { get; set; } = new List<CheckBoxVM>();
        public void OnGet()
        {
            CreateUser = new ();
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
                Email=CreateUser.Email,
                UserName=CreateUser.Email,
                TcNo=CreateUser.TcNo
           };
            // olusturdugumuz myuser'i database 2 kaydediyoruz
            var result = await userManager.CreateAsync(myUser,CreateUser.Password);

            //Eger kullanici olustu ise bu defa secilen rolleri ekliyoruz
            if (result.Succeeded)
            {
                //userManager.AddToRolesAsync(myUser, Roller.Where(p => p.IsChecked == true).Select(p => p.LabelName).AsEnumerable());
                foreach (var item in Roller.Where(p=>p.IsChecked==true))
                {
                    await userManager.AddToRoleAsync(myUser, item.LabelName);
                }
            }
           
            return RedirectToPage("Index");
        }
    }
}
