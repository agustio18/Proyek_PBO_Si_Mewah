using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SiMewah.Controllers;
using SiMewah.Repositories;
using PerawatanModel = SiMewah.Models.Perawatan;
using BurungModel = SiMewah.Models.Burung;

namespace SiMewah.Views.Perawatan
{
    public partial class UcPerawatan : Form
    {
        private readonly PerawatanController _controller;
        private List<PerawatanModel> _daftarPerawatan =
            new List<PerawatanModel>();

        private List<BurungModel> _daftarBurung =
            new List<BurungModel>();

        public UcPerawatan()
            : this(new PerawatanController(
                new PerawatanRepository(),
                new BurungRepository()))
        {
        }

        public UcPerawatan(PerawatanController controller)
        {
            _controller = controller;

            InitializeComponent();

            Text = "Data Perawatan";
            StartPosition = FormStartPosition.CenterParent;

            btnCari.Click += btnCari_Click;
            btnTambah.Click += btnTambah_Click;
            btnUbah.Click += btnUbah_Click;
            btnHapus.Click += btnHapus_Click;
            txtPencarian.KeyDown += txtPencarian_KeyDown;
            dgvPerawatan.CellDoubleClick += dgvPerawatan_CellDoubleClick;

            Load += (s, e) => MuatData();
        }

        public void MuatData()
        {
            try
            {
                _daftarPerawatan = _controller.GetAll();
                _daftarBurung = _controller.GetAllBurung();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data perawatan: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                _daftarPerawatan = new List<PerawatanModel>();
                _daftarBurung = new List<BurungModel>();
            }

            TampilkanGrid(_daftarPerawatan);
        }

        private void TampilkanGrid(List<PerawatanModel> daftar)
        {
            dgvPerawatan.Rows.Clear();

            foreach (PerawatanModel perawatan in daftar)
            {
                dgvPerawatan.Rows.Add(
                    KodeBurung(perawatan.IdBurung),
                    perawatan.JenisPerawatan,
                    perawatan.TanggalPerawatan.ToString("dd/MM/yyyy"),
                    perawatan.JumlahPerawatan,
                    perawatan.IdPerawatan);
            }
        }

        private string KodeBurung(Guid idBurung)
        {
            BurungModel? burung = _daftarBurung
                .FirstOrDefault(b => b.IdBurung == idBurung);

            if (burung == null)
            {
                return "-";
            }

            return burung.KodeBurung;
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
            string kataKunci = txtPencarian.Text.Trim();

            if (kataKunci.Length == 0)
            {
                TampilkanGrid(_daftarPerawatan);
                return;
            }

            List<PerawatanModel> hasil = _daftarPerawatan
                .Where(p =>
                    KodeBurung(p.IdBurung).Contains(
                        kataKunci, StringComparison.OrdinalIgnoreCase) ||
                    p.JenisPerawatan.Contains(
                        kataKunci, StringComparison.OrdinalIgnoreCase))
                .ToList();

            TampilkanGrid(hasil);
        }

        private void btnTambah_Click(object? sender, EventArgs e)
        {
            FormPerawatan form = new FormPerawatan(
                _controller,
                _daftarBurung);

            if (form.ShowDialog() == DialogResult.OK)
            {
                MuatData();
            }
        }

        private void btnUbah_Click(object? sender, EventArgs e)
        {
            if (dgvPerawatan.CurrentRow == null)
            {
                MessageBox.Show("Pilih data yang ingin diubah.");
                return;
            }

            Guid id = Guid.Parse(
                dgvPerawatan.CurrentRow.Cells["colId"].Value.ToString()!);

            PerawatanModel? data = _controller.GetById(id);

            if (data == null)
            {
                MessageBox.Show("Data perawatan tidak ditemukan.");
                return;
            }

            FormPerawatan form = new FormPerawatan(
                _controller,
                _daftarBurung,
                data);

            if (form.ShowDialog() == DialogResult.OK)
            {
                MuatData();
            }
        }

        private void btnHapus_Click(object? sender, EventArgs e)
        {
            if (dgvPerawatan.CurrentRow == null)
            {
                MessageBox.Show("Pilih data yang ingin dihapus.");
                return;
            }

            Guid id = Guid.Parse(
                dgvPerawatan.CurrentRow.Cells["colId"].Value.ToString()!);

            DialogResult konfirmasi = MessageBox.Show(
                "Apakah kamu yakin ingin menghapus data ini?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    _controller.Hapus(id);

                    MessageBox.Show("Data berhasil dihapus.");

                    MuatData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Gagal Menghapus",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void dgvPerawatan_CellDoubleClick(
            object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnUbah_Click(sender, e);
            }
        }
    }
}
