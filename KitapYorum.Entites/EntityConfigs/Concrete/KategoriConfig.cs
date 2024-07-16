using KitapYorum.Entites.Concrete;
using KitapYorum.Entites.EntityConfigs.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapYorum.Entites.EntityConfigs.Concrete
{
    public class KategoriConfig :BaseConfig<Kategori>
    {
        public override void Configure(EntityTypeBuilder<Kategori> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.KategoriAdi).HasMaxLength(50);
            builder.HasIndex(p => p.KategoriAdi).IsUnique();
           
        }
    }
}
