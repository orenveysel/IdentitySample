using KitapYorum.Entites.Abstract;
using System.Security.Principal;

namespace KitapYorum.Entites.Concrete
{
    public class Kitap:BaseEntity
    {
        public string KitapAdi { get; set; }
        public string? Aciklama { get; set; }

        public ushort? SayfaSayisi { get; set; }
        public string?  Cevirmen { get; set; }

        public DateTime? YayinTarihi { get; set; }

        public double? ListeFiyati { get; set; }

        public int YazarId { get; set; }
        public Yazar Yazar { get; set; }

        public ICollection<Kategori> Kategoriler { get; set; } = new HashSet<Kategori>();

        public ICollection<Yorum>? Yorumlar { get; set; }

        public ICollection<Fotograf>? Fotograflar { get; set; }

    }
}