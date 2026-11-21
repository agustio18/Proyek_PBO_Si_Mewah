
using SiMewah.Views;

namespace SiMewah
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Tampilkan Form Login terlebih dahulu
            using (FormLogin login = new FormLogin())
            {
                // Jika login berhasil, tampilkan beranda
                if (login.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new Form1());
                }
            }
        }
    }
}
