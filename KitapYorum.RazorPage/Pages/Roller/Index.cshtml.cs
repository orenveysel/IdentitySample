using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KitapYorum.RazorPage.Pages.Roller
{
    public class IndexModel(RoleManager<IdentityRole> roleManager) : PageModel
    {
        [BindProperty]
        public List<string> MyList { get; set; }=new List<string>();

        [BindProperty]
        public string MyProp { get; set; } = "Test";

        public List<IdentityRole> Roller { get; set; } = new() ;
        public async Task  OnGet()
        {
           Roller = roleManager.Roles.ToList() ;
        }
        public async Task OnPost()
        {

        }
    }
}
