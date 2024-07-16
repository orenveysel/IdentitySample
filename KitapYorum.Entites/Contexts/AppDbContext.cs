using KitapYorum.Entites.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KitapYorum.Entites.Contexts
{
    public class AppDbContext : IdentityDbContext<MyUser,IdentityRole,string>
    {
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Yorum> Yorumlar { get; set; }

        public DbSet<Fotograf> Fotograflar { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=KitapYorum;Trusted_Connection=true;TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public AppDbContext()
        {
            
        }
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
    }
}
