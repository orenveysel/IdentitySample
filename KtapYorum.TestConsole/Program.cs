using KitapYorum.DAL.Abstract;
using KitapYorum.Entites.Concrete;
using KitapYorum.Entites.Contexts;
using KitapYorum.DAL.Concrete;
using Microsoft.AspNetCore.Identity;
using System.Text;
using System.Security.Cryptography;
namespace KtapYorum.TestConsole
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            AppDbContext context = new AppDbContext();
            var salt = GenerateSalt();
            var result = HashPassword("AliVeli", salt);
            

            IRepository<AppDbContext, Kategori, int> repository = new Repository<AppDbContext, Kategori, int>(context);
            Kategori kategori1 = new Kategori()
            {
                KategoriAdi = "Tarih",
                MyUserId= "690e9b81-2419-423f-bb41-e1d830e264c1"
            };
            await repository.AddAsync(kategori1);
            Kategori kategori2 = new Kategori()
            {
                KategoriAdi = "Edebiyat",
                MyUserId = "690e9b81-2419-423f-bb41-e1d830e264c1"
            };
            await repository.AddAsync(kategori2);
            Kategori kategori3 = new Kategori()
            {
                KategoriAdi = "Felsefe",
                MyUserId = "690e9b81-2419-423f-bb41-e1d830e264c1"
            };
            await repository.AddAsync(kategori3);
            var kategoriler = await repository.GetAllAsync(null);

            foreach (var item in kategoriler)
            {
                Console.WriteLine(item.KategoriAdi);
            }
            Console.WriteLine("Hello, World!");
        }
       public static byte[] GenerateSalt()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[16]; // Adjust the size based on your security requirements
                rng.GetBytes(salt);
                return salt;
            }
        }
        public static string HashPassword(string password, byte[] salt)
        {
            using (var sha256 = new SHA256Managed())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] saltedPassword = new byte[passwordBytes.Length + salt.Length];

                // Concatenate password and salt
                Buffer.BlockCopy(passwordBytes, 0, saltedPassword, 0, passwordBytes.Length);
                Buffer.BlockCopy(salt, 0, saltedPassword, passwordBytes.Length, salt.Length);

                // Hash the concatenated password and salt
                byte[] hashedBytes = sha256.ComputeHash(saltedPassword);

                // Concatenate the salt and hashed password for storage
                byte[] hashedPasswordWithSalt = new byte[hashedBytes.Length + salt.Length];
                Buffer.BlockCopy(salt, 0, hashedPasswordWithSalt, 0, salt.Length);
                Buffer.BlockCopy(hashedBytes, 0, hashedPasswordWithSalt, salt.Length, hashedBytes.Length);

                return Convert.ToBase64String(hashedPasswordWithSalt);
            }
        }
    }
}
