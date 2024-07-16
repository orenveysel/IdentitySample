using KitapYorum.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapYorum.Entites.Concrete
{
    public class Yazar :BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public bool? Cinsiyet { get; set; }
        public ICollection<Kitap> Kitaplar { get; set; }

		public ICollection<Fotograf>? Fotograflar { get; set; }
	}
}
