using KitapYorum.BL.Abstract;
using KitapYorum.Entites.Concrete;
using KitapYorum.Entites.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NuGet.ProjectModel;

namespace KitapYorum.RazorPage.Pages.Yazarlar
{
    public class IndexModel : PageModel
    {
        private readonly IYazarManager<AppDbContext, Yazar, int> yazarManager;

        public IEnumerable<Yazar> Yazarlar { get; set; }=new List<Yazar>();

        public IndexModel(IYazarManager<AppDbContext,Yazar,int> yazarManager)
        {
            this.yazarManager = yazarManager;
        }
        public async Task OnGet()
        {
            Yazarlar = await yazarManager.GetAllAsync(null);
        }

        public void OnPost() 
        { 
        
        }
    }
}
