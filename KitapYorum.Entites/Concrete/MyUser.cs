using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapYorum.Entites.Concrete
{
    public class MyUser:IdentityUser
    {
        public string TcNo { get; set; }
        public bool? Cinsiyet { get; set; }

        public DateTime? DogumTarihi { get; set; }

        [NotMapped] // Burasi Database'e yansimayacaktir
        public int? Yas { get; set; }

        public string? ImagePath { get; set; }
        public string? About { get; set; }

        public ICollection<Yorum>? Yorumlar { get; set; }
        public MyUser()
        {
            if(DogumTarihi.HasValue)
                Yas = DateTime.Now.Year-DogumTarihi.Value.Year;
        }
    }
}
