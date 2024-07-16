using KitapYorum.Entites.Concrete;
using KitapYorum.Entites.Contexts;
using KitapYorum.RazorPage.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace KitapYorum.RazorPage.Pages.Users
{
    public class IndexModel(UserManager<MyUser> userManager) : PageModel
    {
        public List<UserListVm> Kullanicilar { get; set; } = new List<UserListVm>();
        public void OnGet()
        {

            // Butun User'lari Aliyoruz
            var users = userManager.Users.ToList();


            foreach (var user in users)
            {
                UserListVm listVm = new UserListVm();
                listVm.UserId = user.Id;
                listVm.UserName = user.UserName;
                listVm.TcNo= user.TcNo;
                listVm.Cinsiyet= user.Cinsiyet;
                listVm.Email = user.Email;
                var roller = userManager.GetRolesAsync(user).Result;
                foreach (var item in roller)
                {
                    listVm.Roles.Add(item);
                    listVm.RoleName += item + " ";
                }
                Kullanicilar.Add(listVm);
            }


           
          

            string str = "";

        }
    }
}
