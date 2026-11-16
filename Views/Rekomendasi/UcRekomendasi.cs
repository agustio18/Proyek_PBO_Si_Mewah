using System;
using System.Windows.Forms;
using SiMewah.Controllers;
using SiMewah.Models;

namespace SiMewah.Views.Rekomendasi
{
    public partial class UcRekomendasi : Form
    {
        private readonly RekomendasiController _controller;

        public UcRekomendasi()
        {
            InitializeComponent();
            _controller = new RekomendasiController();
            LoadDaftarBurung();
        }

        private void LoadDaftarBurung()
        {
            var daftar = _controller.GetDaftarBetina();
            cmbBurung.DataSource = new BindingSource(daftar, null);
            cmbBurung.DisplayMember = "Value";
            cmbBurung.ValueMember = "Key";
        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            if (cmbBurung.SelectedValue == null)
            {
                MessageBox.Show("Pilih burung betina terlebih dahulu.");
                return;
            }

            Guid idBurung = (Guid)cmbBurung.SelectedValue;
            Models.Rekomendasi hasil = _controller.AnalisisKelayakan(idBurung);
            lblhasil.Text = "Hasil: " + hasil.HasilRekomendasi;
            lblketerangan.Text = hasil.Keterangan;

            dgvRiwayat.DataSource = _controller.GetRiwayatRekomendasi(idBurung);
        }
    }
}