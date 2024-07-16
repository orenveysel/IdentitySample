using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KitapYorum.RazorPage.Models
{
    public class LoginVm
    {

        [EmailAddress(ErrorMessage ="Geçerli formatta bir email adresi giriniz")]
        [Required(ErrorMessage ="email alani boş olamaz")]
        public string Email { get; set; }


        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Şifre Boş Olamaz")]
        public string Password { get; set; }

        [DisplayName("Beni Hatirla")]
        public bool RememberMe { get; set; }
    }
}
