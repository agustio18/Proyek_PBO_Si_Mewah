using System;
using System.Windows.Forms;
using SiMewah.Controllers;
using KandangModel = SiMewah.Models.Kandang;

namespace SiMewah.Views.Kandang
{
    public partial class FormKandang : Form
    {
        private readonly KandangController _controller;
        private readonly KandangModel? _dataLama;

        public FormKandang(KandangController controller)
            : this(controller, null)
        {
        }

        public FormKandang(KandangController controller, KandangModel? dataLama)
        {
            _controller = controller;
            _dataLama = dataLama;

            InitializeComponent();

            btnSimpan.Click += btnSimpan_Click;
            btnBatal.Click += btnBatal_Click;
            AcceptButton = btnSimpan;
            CancelButton = btnBatal;

            IsiPilihan();
        }

        private void IsiPilihan()
        {
            cmbJenis.Items.Clear();
            cmbJenis.Items.Add("indukan");
            cmbJenis.Items.Add("anakan");
            cmbJenis.Items.Add("penjodohan");

            if (_dataLama == null)
            {
                cmbJenis.SelectedIndex = 0;
            }
            else
            {
                cmbJenis.SelectedItem = _dataLama.JenisKandang;
                txtKeterangan.Text = _dataLama.Keterangan ?? string.Empty;

                lblJudul.Text = "Ubah Data Kandang";
                Text = "Ubah Data Kandang";
            }
        }

        private void btnSimpan_Click(object? sender, EventArgs e)
        {
            if (cmbJenis.SelectedItem == null)
            {
                MessageBox.Show("Jenis kandang harus dipilih.",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string jenis = cmbJenis.SelectedItem.ToString()!;
            string? keterangan = txtKeterangan.Text.Trim();

            if (keterangan.Length == 0)
            {
                keterangan = null;
            }

            try
            {
                if (_dataLama == null)
                {
                    KandangModel kandangBaru = new KandangModel(jenis, keterangan);
                    _controller.Tambah(kandangBaru);
                }
                else
                {
                    KandangModel kandangUbah = new KandangModel(
                        _dataLama.IdKandang,
                        jenis,
                        keterangan);
                    _controller.Ubah(kandangUbah);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data kandang: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
