using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SiMewah.Controllers;
using SiMewah.Repositories;
using BurungModel = SiMewah.Models.Burung;
using KandangModel = SiMewah.Models.Kandang;

namespace SiMewah.Views.Burung
{
    public partial class UcBurung : Form
    {
        private readonly BurungController _controller;
        private List<BurungModel> _daftarBurung = new List<BurungModel>();
        private List<KandangModel> _daftarKandang = new List<KandangModel>();

        public UcBurung()
            : this(new BurungController(new BurungRepository(), new KandangRepository()))
        {
        }

        public UcBurung(BurungController controller)
        {
            _controller = controller;

            InitializeComponent();

            Text = "Data Burung";
            StartPosition = FormStartPosition.CenterParent;

            btnCari.Click += btnCari_Click;
            btnTambah.Click += btnTambah_Click;
            btnUbah.Click += btnUbah_Click;
            txtPencarian.KeyDown += txtPencarian_KeyDown;
            dgvBurung.CellDoubleClick += dgvBurung_CellDoubleClick;
            Load += (s, e) => MuatData();
        }

        public void MuatData()
        {
            try
            {
                _daftarBurung = _controller.GetAll();
                _daftarKandang = _controller.GetAllKandang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data burung: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _daftarBurung = new List<BurungModel>();
                _daftarKandang = new List<KandangModel>();
            }

            TampilkanGrid(_daftarBurung);
        }

        private void TampilkanGrid(List<BurungModel> daftar)
        {
            dgvBurung.Rows.Clear();

            foreach (BurungModel burung in daftar)
            {
                dgvBurung.Rows.Add(
                    burung.KodeBurung,
                    burung.JenisKelamin,
                    burung.TanggalLahir.ToString("dd/MM/yyyy"),
                    burung.Status,
                    NamaKandang(burung),
                    burung.IdBurung);
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
                TampilkanGrid(_daftarBurung);
                return;
            }

            List<BurungModel> hasil = _daftarBurung
                .Where(b =>
                    Memuat(b.KodeBurung, kataKunci) ||
                    Memuat(b.JenisKelamin, kataKunci) ||
                    Memuat(b.Status, kataKunci) ||
                    Memuat(NamaKandang(b), kataKunci))
                .ToList();

            TampilkanGrid(hasil);
        }

        private static bool Memuat(string? nilai, string kataKunci)
        {
            return nilai != null &&
                   nilai.Contains(kataKunci, StringComparison.OrdinalIgnoreCase);
        }

        private string NamaKandang(BurungModel burung)
        {
            KandangModel? kandang = _daftarKandang
                .FirstOrDefault(k => k.IdKandang == burung.IdKandang);

            if (kandang == null)
            {
                return "-";
            }

            if (string.IsNullOrWhiteSpace(kandang.Keterangan))
            {
                return kandang.JenisKandang;
            }

            return kandang.JenisKandang + " - " + kandang.Keterangan;
        }

        private void btnTambah_Click(object? sender, EventArgs e)
        {
            using FormBurung form = new FormBurung(_controller, _daftarKandang);

            if (form.ShowDialog(FindForm()) == DialogResult.OK)
            {
                MuatData();
            }
        }

        private void btnUbah_Click(object? sender, EventArgs e)
        {
            if (dgvBurung.CurrentRow == null)
            {
                MessageBox.Show("Pilih data burung yang ingin diubah terlebih dahulu.",
                    "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvBurung.CurrentRow.Cells["colId"].Value is not Guid id)
            {
                MessageBox.Show("Data burung yang dipilih tidak valid.",
                    "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                BurungModel? burung = _controller.GetById(id);
                if (burung == null)
                {
                    MessageBox.Show("Data burung tidak ditemukan.",
                        "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using FormBurung form = new FormBurung(_controller, _daftarKandang, burung);

                if (form.ShowDialog(FindForm()) == DialogResult.OK)
                {
                    MuatData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data burung: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvBurung_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnUbah_Click(sender, e);
            }
        }
    }
}
