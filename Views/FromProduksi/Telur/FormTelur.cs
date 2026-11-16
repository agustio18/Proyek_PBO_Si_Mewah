
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using SiMewah.Controllers;
using SiMewah.Repositories;

using ModelBurung = SiMewah.Models.Burung;
using ModelKandang = SiMewah.Models.Kandang;
using ModelPerkawinan = SiMewah.Models.Perkawinan;

namespace SiMewah.Views.Produksi.Telur
{
    public partial class FormTelur : Form
    {
        private readonly PerkawinanController _perkawinanController;
        private readonly BurungController _burungController;

        public DateTime TanggalTelur
        {
            get { return dtpTanggal.Value.Date; }
        }

        public int JumlahTelur
        {
            get { return (int)numJumlah.Value; }
        }

        public Guid IdPerkawinan
        {
            get
            {
                return cmbPerkawinan.SelectedValue == null
                    ? Guid.Empty
                    : (Guid)cmbPerkawinan.SelectedValue;
            }
        }

        public FormTelur()
        {
            InitializeComponent();

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

            btnSimpan.Click += btnSimpan_Click;
            btnBatal.Click += btnBatal_Click;

            cmbPerkawinan.DropDownStyle =
                ComboBoxStyle.DropDownList;

            MuatDataPerkawinan();
        }

        // Constructor untuk mengubah data telur
        public FormTelur(
            DateTime tanggal,
            int jumlah,
            Guid idPerkawinan
        ) : this()
        {
            dtpTanggal.Value = tanggal;
            numJumlah.Value = jumlah;

            cmbPerkawinan.SelectedValue = idPerkawinan;

            // Tanggal dan perkawinan tidak diubah saat edit
            dtpTanggal.Enabled = false;
            cmbPerkawinan.Enabled = false;

            lblJudul.Text = "Ubah Data Telur";
            Text = "Ubah Data Telur";
        }

        // Memuat pilihan perkawinan dari database
        private void MuatDataPerkawinan()
        {
            try
            {
                var daftarPerkawinan =
                    _perkawinanController.GetAll();

                var daftarBurung =
                    _burungController.GetAll();

                var pilihan = daftarPerkawinan.Select(p =>
                {
                    string jantan = daftarBurung
                        .FirstOrDefault(b =>
                            b.IdBurung == p.IdBurungJantan)
                        ?.KodeBurung ?? "Tidak ditemukan";

                    string betina = daftarBurung
                        .FirstOrDefault(b =>
                            b.IdBurung == p.IdBurungBetina)
                        ?.KodeBurung ?? "Tidak ditemukan";

                    return new
                    {
                        IdPerkawinan = p.IdPerkawinan,
                        Keterangan =
                            $"{p.TanggalPerkawinan:dd/MM/yyyy} | " +
                            $"{jantan} - {betina}"
                    };
                }).ToList();

                cmbPerkawinan.DataSource = pilihan;
                cmbPerkawinan.DisplayMember = "Keterangan";
                cmbPerkawinan.ValueMember = "IdPerkawinan";

                if (pilihan.Count == 0)
                {
                    btnSimpan.Enabled = false;

                    MessageBox.Show(
                        "Belum ada data perkawinan. " +
                        "Tambahkan data perkawinan terlebih dahulu."
                    );
                }
            }
            catch (Exception ex)
            {
                btnSimpan.Enabled = false;

                MessageBox.Show(
                    "Gagal memuat data perkawinan: " + ex.Message,
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Tombol Simpan
        private void btnSimpan_Click(object? sender, EventArgs e)
        {
            if (cmbPerkawinan.SelectedValue == null)
            {
                MessageBox.Show(
                    "Pilih data perkawinan terlebih dahulu."
                );
                return;
            }

            if (numJumlah.Value <= 0)
            {
                MessageBox.Show(
                    "Jumlah telur harus lebih dari 0."
                );
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        // Tombol Batal
        private void btnBatal_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
