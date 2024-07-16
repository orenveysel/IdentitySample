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
	public class FotografConfig:BaseConfig<Fotograf>
	{
		public override void Configure(EntityTypeBuilder<Fotograf> builder)
		{
			base.Configure(builder);
			builder.Property(p => p.FileType).HasMaxLength(20);
			builder.Property(p => p.ImageName).HasMaxLength(100);
			builder.Property(p => p.ImagePath).HasMaxLength(500);



		}
	}
}
