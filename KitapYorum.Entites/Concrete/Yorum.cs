using KitapYorum.Entites.Abstract;

namespace KitapYorum.Entites.Concrete
{
   public enum YorumTipi:byte
    {
        Kitap=1,
        Yazar
    }

    public  class Yorum :BaseEntity
    {
        public string Aciklama { get; set; }

        public byte? Yildiz { get; set; }
        public int KitapId { get; set; }
        public Kitap Kitap { get; set; }

        public YorumTipi YorumTipi { get; set; }

    }
}