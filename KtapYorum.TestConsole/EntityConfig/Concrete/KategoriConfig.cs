
using KtapYorum.TestConsole.EntityConfig.Abstract;
using KtapYorum.TestConsole.EntityConfig.Concrete;
using KtapYorum.TestConsole.PetShopEntites.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtapYorum.TestConsole.EntityConfig.Concrete
{
    public class KategoriConfig : BaseConfig<Kategori>
    {
        public override void Configure(EntityTypeBuilder<Kategori> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.KategoriAdi).HasMaxLength(50);
            builder.HasIndex(p => p.KategoriAdi).IsUnique();
        }
    }
}
