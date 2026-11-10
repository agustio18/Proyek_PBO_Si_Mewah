using System;
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
        }

        private void btn_perkawinan_Click(object sender, EventArgs e)
        {
            TampilkanKonten(new UcPerkawinan());
        }

        private void btn_telur_Click(object sender, EventArgs e)
        {
            TampilkanKonten(new UcTelur());
        }

        private void btn_penetasan_Click(object sender, EventArgs e)
        {
            TampilkanKonten(new UcPenetasan());
        }

        private void TampilkanKonten(UserControl kontrol)
        {
            pnl_konten.Controls.Clear();

            kontrol.Dock = DockStyle.Fill;

            pnl_konten.Controls.Add(kontrol);
            kontrol.BringToFront();
        }
    }
}


