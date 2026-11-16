
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using SiMewah.Controllers;
using SiMewah.Repositories;

using ModelBurung = SiMewah.Models.Burung;
using ModelKandang = SiMewah.Models.Kandang;

namespace SiMewah.Views.Produksi.Telur
{
    public partial class UcTelur : UserControl
    {
        private readonly TelurController _telurController;
        private readonly PerkawinanController _perkawinanController;
        private readonly BurungController _burungController;

        private Dictionary<Guid, string> _daftarPerkawinan = new();

        public UcTelur()
        {
            InitializeComponent();

            _telurController = new TelurController(
                new TelurRepository()
            );

            _perkawinanController = new PerkawinanController(
                new PerkawinanRepository()
            );

            IRepository<ModelBurung> burungRepository =
                new BurungRepository();

            IRepository<ModelKandang> kandangRepository =
                new KandangRepository();

            _burungController = new BurungController(
                burungRepository,
                kandangRepository
            );

            btnTambah.Click += btnTambah_Click;
            btnUbah.Click += btnUbah_Click;
            btnCari.Click += btnCari_Click;

            MuatDataTelur();
        }

        // Memuat data perkawinan untuk keterangan di tabel
        private void MuatDataPerkawinan()
        {
            _daftarPerkawinan.Clear();

            var daftarPerkawinan = _perkawinanController.GetAll();
            var daftarBurung = _burungController.GetAll();

            foreach (var perkawinan in daftarPerkawinan)
            {
                string jantan = daftarBurung
                    .FirstOrDefault(b => b.IdBurung == perkawinan.IdBurungJantan)
                    ?.KodeBurung ?? "Tidak ditemukan";

                string betina = daftarBurung
                    .FirstOrDefault(b => b.IdBurung == perkawinan.IdBurungBetina)
                    ?.KodeBurung ?? "Tidak ditemukan";

                string keterangan =
                    $"{perkawinan.TanggalPerkawinan:dd/MM/yyyy} | {jantan} - {betina}";

                _daftarPerkawinan[perkawinan.IdPerkawinan] = keterangan;
            }
        }

        // Memuat data telur ke DataGridView
        private void MuatDataTelur()
        {
            try
            {
                MuatDataPerkawinan();

                dgvTelur.Rows.Clear();

                var daftarTelur = _telurController.GetAll();

                foreach (var telur in daftarTelur)
                {
                    string perkawinan =
                        _daftarPerkawinan.TryGetValue(
                            telur.IdPerkawinan,
                            out string? keterangan
                        )
                        ? keterangan
                        : "Tidak ditemukan";

                    dgvTelur.Rows.Add(
                        telur.TanggalTelur.ToDateTime(TimeOnly.MinValue),
                        telur.JumlahTelur,
                        perkawinan,
                        telur.IdTelur
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat data telur: " + ex.Message,
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Tombol Tambah
        private void btnTambah_Click(object? sender, EventArgs e)
        {
            using (FormTelur form = new FormTelur())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var data = new SiMewah.Models.Telur(
                            DateOnly.FromDateTime(form.TanggalTelur),
                            form.JumlahTelur,
                            form.IdPerkawinan
                        );

                        _telurController.Tambah(data);

                        MuatDataTelur();

                        MessageBox.Show("Data telur berhasil ditambahkan.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "Gagal menambahkan data telur: " + ex.Message,
                            "Kesalahan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
        }

        // Tombol Ubah
        private void btnUbah_Click(object? sender, EventArgs e)
        {
            if (dgvTelur.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data telur yang ingin diubah.");
                return;
            }

            try
            {
                Guid idTelur = Guid.Parse(
                    dgvTelur.SelectedRows[0]
                    .Cells["colId"].Value.ToString()!
                );

                var dataLama = _telurController.GetById(idTelur);

                if (dataLama == null)
                {
                    MessageBox.Show("Data telur tidak ditemukan.");
                    return;
                }

                using (FormTelur form = new FormTelur(
                    dataLama.TanggalTelur.ToDateTime(TimeOnly.MinValue),
                    dataLama.JumlahTelur,
                    dataLama.IdPerkawinan
                ))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        var dataBaru = new SiMewah.Models.Telur(
                            dataLama.IdTelur,
                            dataLama.TanggalTelur,
                            form.JumlahTelur,
                            dataLama.IdPerkawinan
                        );

                        _telurController.Ubah(dataBaru);

                        MuatDataTelur();

                        MessageBox.Show("Data telur berhasil diubah.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal mengubah data telur: " + ex.Message,
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Tombol Cari
        private void btnCari_Click(object? sender, EventArgs e)
        {
            string kataKunci = txtPencarian.Text.Trim();

            foreach (DataGridViewRow row in dgvTelur.Rows)
            {
                string tanggal = row.Cells["colTanggal"].Value?
                    .ToString() ?? "";

                string jumlah = row.Cells["colJumlah"].Value?
                    .ToString() ?? "";

                string perkawinan = row.Cells["colPerkawinan"].Value?
                    .ToString() ?? "";

                row.Visible =
                    tanggal.Contains(kataKunci, StringComparison.OrdinalIgnoreCase) ||
                    jumlah.Contains(kataKunci, StringComparison.OrdinalIgnoreCase) ||
                    perkawinan.Contains(kataKunci, StringComparison.OrdinalIgnoreCase);
            }
        }
    }
}
