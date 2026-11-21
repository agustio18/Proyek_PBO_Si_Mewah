
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using SiMewah.Models;

namespace SiMewah.Controllers
{
    public class AuthController
    {
        public bool Login(string username, string password)
        {
            // Menentukan lokasi file konfigurasi
            string lokasiData = Path.Combine(
                AppContext.BaseDirectory,
                "Data",
                "auth.json"
            );

            string lokasiRoot = Path.Combine(
                AppContext.BaseDirectory,
                "auth.json"
            );

            string lokasiFile;

            // Memeriksa lokasi file
            if (File.Exists(lokasiData))
            {
                lokasiFile = lokasiData;
            }
            else if (File.Exists(lokasiRoot))
            {
                lokasiFile = lokasiRoot;
            }
            else
            {
                throw new FileNotFoundException(
                    "File auth.json tidak ditemukan. Periksa lokasi file konfigurasi."
                );
            }

            // Membaca isi file JSON
            string json = File.ReadAllText(lokasiFile);

            // Mengubah JSON menjadi objek AuthConfig
            AuthConfig? akun =
                JsonSerializer.Deserialize<AuthConfig>(json);

            if (akun == null)
            {
                throw new InvalidOperationException(
                    "Konfigurasi akun tidak valid."
                );
            }

            // Mengubah password menjadi hash SHA-256
            string passwordHash = BuatHash(password);

            // Memeriksa username dan password
            return username == akun.Username &&
                   passwordHash == akun.PasswordHash;
        }

        private string BuatHash(string password)
        {
            byte[] data = Encoding.UTF8.GetBytes(password);

            byte[] hasilHash = SHA256.HashData(data);

            return Convert.ToHexString(hasilHash);
        }
    }
}
