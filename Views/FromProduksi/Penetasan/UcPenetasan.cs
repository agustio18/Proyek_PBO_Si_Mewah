
using System;
using System.Collections.Generic;
using System.Windows.Forms;

using SiMewah.Controllers;
using SiMewah.Repositories;

using ModelPenetasan = SiMewah.Models.Penetasan;
using ModelTelur = SiMewah.Models.Telur;

namespace SiMewah.Views.Produksi.Penetasan
{
    public partial class UcPenetasan : UserControl
    {
        private readonly PenetasanController _penetasanController;
        private readonly TelurController _telurController;

        public UcPenetasan()
        {
            InitializeComponent();

            _penetasanController = new PenetasanController(
                new PenetasanRepository(),
                new TelurRepository()
            );

            _telurController = new TelurController(
                new TelurRepository()
            );

            AturKolom();

            btnTambah.Click += btnTambah_Click;
            btnUbah.Click += btnUbah_Click;
            btnCari.Click += btnCari_Click;

            MuatDataPenetasan();
        }

        // Mengatur kolom DataGridView
        private void AturKolom()
        {
            dgvPenetasan.Columns[0].Name = "colTanggal";
            dgvPenetasan.Columns[0].HeaderText = "Tanggal Pencatatan";

            dgvPenetasan.Columns[1].Name = "colTelur";
            dgvPenetasan.Columns[1].HeaderText = "Kelompok Telur";

            dgvPenetasan.Columns[2].Name = "colMenetas";
            dgvPenetasan.Columns[2].HeaderText = "Jumlah Menetas";

            dgvPenetasan.Columns[3].Name = "colGagal";
            dgvPenetasan.Columns[3].HeaderText = "Jumlah Gagal";

            dgvPenetasan.Columns[4].Name = "colId";
            dgvPenetasan.Columns[4].Visible = false;

            dgvPenetasan.Columns[5].Name = "colIdTelur";
            dgvPenetasan.Columns[5].Visible = false;

            dgvPenetasan.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        // Memuat data dari database
        private void MuatDataPenetasan()
        {
            try
            {
                dgvPenetasan.Rows.Clear();

                var daftarTelur = _telurController.GetAll();
                var daftarPenetasan = _penetasanController.GetAll();

                var daftarKeteranganTelur = new Dictionary<Guid, string>();

                foreach (ModelTelur telur in daftarTelur)
                {
                    daftarKeteranganTelur[telur.IdTelur] =
                        $"{telur.TanggalTelur:dd/MM/yyyy} | {telur.JumlahTelur} telur";
                }

                foreach (ModelPenetasan penetasan in daftarPenetasan)
                {
                    string keteranganTelur = daftarKeteranganTelur.ContainsKey(penetasan.IdTelur)
                        ? daftarKeteranganTelur[penetasan.IdTelur]
                        : "Data telur tidak ditemukan";

                    dgvPenetasan.Rows.Add(
                        penetasan.TanggalPencatatan.ToDateTime(TimeOnly.MinValue),
                        keteranganTelur,
                        penetasan.JumlahMenetas,
                        penetasan.JumlahGagal,
                        penetasan.IdPenetasan,
                        penetasan.IdTelur
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat data penetasan: " + ex.Message,
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Tombol Tambah
        private void btnTambah_Click(object? sender, EventArgs e)
        {
            using (FormPenetasan form = new FormPenetasan())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ModelPenetasan penetasan = new ModelPenetasan(
                            DateOnly.FromDateTime(form.TanggalPencatatan),
                            form.JumlahMenetas,
                            form.JumlahGagal,
                            form.IdTelur
                        );

                        _penetasanController.Tambah(penetasan);

                        MuatDataPenetasan();

                        MessageBox.Show("Data penetasan berhasil ditambahkan.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "Gagal menambahkan data: " + ex.Message,
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
            if (dgvPenetasan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data penetasan yang ingin diubah.");
                return;
            }

            try
            {
                Guid idPenetasan = Guid.Parse(
                    dgvPenetasan.SelectedRows[0].Cells["colId"].Value.ToString()!
                );

                ModelPenetasan dataLama = _penetasanController.GetById(idPenetasan);

                using (FormPenetasan form = new FormPenetasan(
                    dataLama.TanggalPencatatan.ToDateTime(TimeOnly.MinValue),
                    dataLama.JumlahMenetas,
                    dataLama.JumlahGagal,
                    dataLama.IdTelur
                ))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        ModelPenetasan dataBaru = new ModelPenetasan(
                            dataLama.IdPenetasan,
                            dataLama.TanggalPencatatan,
                            form.JumlahMenetas,
                            form.JumlahGagal,
                            dataLama.IdTelur
                        );

                        _penetasanController.Ubah(dataBaru);

                        MuatDataPenetasan();

                        MessageBox.Show("Data penetasan berhasil diubah.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal mengubah data: " + ex.Message,
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

            foreach (DataGridViewRow baris in dgvPenetasan.Rows)
            {
                if (baris.IsNewRow) continue;

                bool cocok = false;

                for (int i = 0; i < 4; i++)
                {
                    string nilai = baris.Cells[i].Value?.ToString() ?? "";

                    if (nilai.Contains(
                        kataKunci,
                        StringComparison.OrdinalIgnoreCase))
                    {
                        cocok = true;
                        break;
                    }
                }

                baris.Visible = cocok;
            }
        }
    }
}
