using Microsoft.Build.Execution;
using System.ComponentModel.DataAnnotations;

namespace KitapYorum.RazorPage.Models
{
    public class UserInsertVM
    {
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(11,ErrorMessage ="11 haneli olmak zorundadir")]
        public string TcNo { get; set; }


        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Şifreler ayni olamk zorundadir")]
        public string RePassword { get; set; }

       
    }
}
