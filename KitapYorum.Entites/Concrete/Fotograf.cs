using KitapYorum.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapYorum.Entites.Concrete
{
	public class Fotograf:BaseEntity
	{
        public string ImageName { get; set; }
		public string? ImagePath { get; set; }
        public string? FileType { get; set; }

        public int? KitapId { get; set; }
        public Kitap? Kitap { get; set; }

        public int? YazarId { get; set; }
        public Yazar? Yazar { get; set; }
    }
}
