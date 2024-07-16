using KitapYorum.BL.Abstract;
using KitapYorum.BL.Concrete;
using KitapYorum.Entites.Concrete;
using KitapYorum.Entites.Contexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebSockets;
using Microsoft.EntityFrameworkCore;

namespace KitapYorum.RazorPage.Extensions
{
    public static  class MyExtensions
    {

        public static IServiceCollection AddKitapYorumService
            (this IServiceCollection services)
        {
            
            services.AddScoped(typeof(IManager<,,>), typeof(Manager<,,>));
            services.AddScoped(typeof(IYazarManager<,,>), typeof(YazarManager<,,>));

            return services;
        
        }
        public static IServiceCollection IdentityAyarlariEkle(this IServiceCollection services)
        {
            services.AddIdentity<MyUser, IdentityRole>(options =>
            {

                //Şifreleme ile ilgili kurallar
                options.Password.RequireDigit = false;//Şifre icerisinde sayisal alan olsunmu 
                options.Password.RequireLowercase = false;//Kucuk harf olsun mu 
                options.Password.RequireUppercase = false;//Buyuk Harf olsun mu 
                options.Password.RequiredLength = 3;//En az kac karakter olsun
                options.Password.RequireNonAlphanumeric = false; //Alphanumeric karakter olsun mu


                options.User.RequireUniqueEmail = true;//Email alani uniqe olsun mu
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;//5 kere yanlis giris yaparsa hesabi gecici olarak blokla
                options.SignIn.RequireConfirmedPhoneNumber = false; // 
                options.SignIn.RequireConfirmedEmail = false; //Onay mail'i olsun mu
                options.SignIn.RequireConfirmedAccount = false;//Account onayli olsun mu ?
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();//Email Token alabilmek icin buranin eklenemsi gerekiyor

            return services;
        }
    }
}
