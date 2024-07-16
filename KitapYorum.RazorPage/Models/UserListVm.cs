namespace KitapYorum.RazorPage.Models
{
    public class UserListVm
    {

        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string TcNo { get; set; }
        public bool? Cinsiyet { get; set; }
        public List<string> Roles { get; set; }=new List<string>();
        public string RoleName { get; set; } = string.Empty;    
    }
}
