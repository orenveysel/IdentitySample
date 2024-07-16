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
    public class KitapConfig:BaseConfig<Kitap>
    {
        public override void Configure(EntityTypeBuilder<Kitap> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.KitapAdi).HasMaxLength(100);
            builder.Property(p=>p.Cevirmen).HasMaxLength(100);
            
        }
    }
}
