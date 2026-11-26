
using System;
using System.Drawing;
using System.Windows.Forms;
using SiMewah.Views.Produksi.Perkawinan;
using SiMewah.Views.Produksi.Telur;
using SiMewah.Views.Produksi.Penetasan;

namespace SiMewah.Views.FormProduksi
{
    public partial class FormProduksi : Form
    {
        public FormProduksi()
        {
            InitializeComponent();

            // Menghubungkan tombol dengan event Click
            btn_perkawinan.Click += btn_perkawinan_Click;
            btn_telur.Click += btn_telur_Click;
            btn_penetasan.Click += btn_penetasan_Click;
            btn_keluar.Click += btn_keluar_Click;

            TandaiMenuAktif(null);
        }

        private void btn_perkawinan_Click(object? sender, EventArgs e)
        {
            TandaiMenuAktif(btn_perkawinan);
            TampilkanKonten(new UcPerkawinan());
        }

        private void btn_telur_Click(object? sender, EventArgs e)
        {
            TandaiMenuAktif(btn_telur);
            TampilkanKonten(new UcTelur());
        }

        private void btn_penetasan_Click(object? sender, EventArgs e)
        {
            TandaiMenuAktif(btn_penetasan);
            TampilkanKonten(new UcPenetasan());
        }

        private void btn_keluar_Click(object? sender, EventArgs e)
        {
            // Menampilkan kembali Form Beranda
            if (Owner != null)
            {
                Owner.Show();
                Owner.Activate();
            }

            // Menutup FormProduksi
            this.Close();
        }

        private void TampilkanKonten(UserControl kontrol)
        {
            pnl_konten.Controls.Clear();

            kontrol.Dock = DockStyle.Fill;

            pnl_konten.Controls.Add(kontrol);
            kontrol.BringToFront();
        }

        private void TandaiMenuAktif(Button? aktif)
        {
            Button[] daftar = { btn_perkawinan, btn_telur, btn_penetasan };

            foreach (Button tombol in daftar)
            {
                tombol.BackColor = Color.White;
                tombol.ForeColor = Color.FromArgb(53, 92, 69);
            }

            if (aktif != null)
            {
                aktif.BackColor = Color.FromArgb(53, 92, 69);
                aktif.ForeColor = Color.White;
            }
        }
    }
}
