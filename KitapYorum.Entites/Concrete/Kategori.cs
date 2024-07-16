using KitapYorum.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapYorum.Entites.Concrete
{
    public class Kategori:BaseEntity
    {
        public string KategoriAdi { get; set; }

        public ICollection<Kitap> Kitaplar { get; set; } = new HashSet<Kitap>();
    }
}
