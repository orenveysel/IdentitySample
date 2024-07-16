
using KtapYorum.TestConsole.PetShopEntites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtapYorum.TestConsole.PetShopEntites.Concrete
{
    public class Kategori:BaseEntity
    {
        public string KategoriAdi { get; set; }
        public string Aciklama { get; set; }

        public int? UstKategoriId { get; set; }
        public List<Stok> Stoklar { get; set; }
    }
}
