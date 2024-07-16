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
    public class YorumConfig:BaseConfig<Yorum>
    {
        public override void Configure(EntityTypeBuilder<Yorum> builder)
        {
            base.Configure(builder);
           
        }
    }
}
