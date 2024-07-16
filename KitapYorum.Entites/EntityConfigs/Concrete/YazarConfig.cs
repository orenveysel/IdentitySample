using KitapYorum.Entites.Abstract;
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
    public class YazarConfig:BaseConfig<Yazar>
    {
        public override void Configure(EntityTypeBuilder<Yazar> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Ad).HasMaxLength(50);
            builder.Property(p => p.Soyad).HasMaxLength(50);
            builder.HasIndex(p => new { p.Ad,p.Soyad}).IsUnique();
        }
    }
}
