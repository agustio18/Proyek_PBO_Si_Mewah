using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SiMewah.Controllers;
using SiMewah.Repositories;
using KandangModel = SiMewah.Models.Kandang;

namespace SiMewah.Views.Kandang
{
    public partial class UcKandang : Form
    {
        private readonly KandangController _controller;
        private List<KandangModel> _daftarKandang = new List<KandangModel>();

        public UcKandang()
            : this(new KandangController(new KandangRepository()))
        {
        }

        public UcKandang(KandangController controller)
        {
            _controller = controller;

            InitializeComponent();

            Text = "Data Kandang";
            StartPosition = FormStartPosition.CenterParent;

            btnCari.Click += btnCari_Click;
            btnTambah.Click += btnTambah_Click;
            btnUbah.Click += btnUbah_Click;
            txtPencarian.KeyDown += txtPencarian_KeyDown;
            dgvKandang.CellDoubleClick += dgvKandang_CellDoubleClick;
            Load += (s, e) => MuatData();
        }

        public void MuatData()
        {
            try
            {
                _daftarKandang = _controller.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data kandang: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _daftarKandang = new List<KandangModel>();
            }

            TampilkanGrid(_daftarKandang);
        }

        private void TampilkanGrid(List<KandangModel> daftar)
        {
            dgvKandang.Rows.Clear();

            foreach (KandangModel kandang in daftar)
            {
                dgvKandang.Rows.Add(
                    kandang.JenisKandang,
                    kandang.Keterangan ?? string.Empty,
                    kandang.IdKandang);
            }
        }

        private void btnCari_Click(object? sender, EventArgs e)
        {
            CariData();
        }

        private void txtPencarian_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                CariData();
            }
        }

        private void CariData()
        {
            string kataKunci = (txtPencarian.Text ?? string.Empty).Trim();

            if (kataKunci.Length == 0)
            {
                TampilkanGrid(_daftarKandang);
                return;
            }

            List<KandangModel> hasil = _daftarKandang
                .Where(k =>
                    Memuat(k.JenisKandang, kataKunci) ||
                    Memuat(k.Keterangan, kataKunci))
                .ToList();

            TampilkanGrid(hasil);
        }

        private static bool Memuat(string? nilai, string kataKunci)
        {
            return nilai != null &&
                   nilai.Contains(kataKunci, StringComparison.OrdinalIgnoreCase);
        }

        private void btnTambah_Click(object? sender, EventArgs e)
        {
            using FormKandang form = new FormKandang(_controller);

            if (form.ShowDialog(FindForm()) == DialogResult.OK)
            {
                MuatData();
            }
        }

        private void btnUbah_Click(object? sender, EventArgs e)
        {
            if (dgvKandang.CurrentRow == null)
            {
                MessageBox.Show("Pilih data kandang yang ingin diubah terlebih dahulu.",
                    "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvKandang.CurrentRow.Cells["colId"].Value is not Guid id)
            {
                MessageBox.Show("Data kandang yang dipilih tidak valid.",
                    "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                KandangModel? kandang = _controller.GetById(id);
                if (kandang == null)
                {
                    MessageBox.Show("Data kandang tidak ditemukan.",
                        "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using FormKandang form = new FormKandang(_controller, kandang);

                if (form.ShowDialog(FindForm()) == DialogResult.OK)
                {
                    MuatData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data kandang: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvKandang_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnUbah_Click(sender, e);
            }
        }
    }
}
