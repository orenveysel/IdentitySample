using KtapYorum.TestConsole.EntityConfig.Abstract;
using KtapYorum.TestConsole.PetShopEntites.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtapYorum.TestConsole.EntityConfig.Concrete
{
    public class StokConfig : BaseConfig<Stok>
    {
        public override void Configure(EntityTypeBuilder<Stok> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.StokKod).HasMaxLength(50);
            builder.HasIndex(p=> p.StokKod).IsUnique();
        }
    }
}
