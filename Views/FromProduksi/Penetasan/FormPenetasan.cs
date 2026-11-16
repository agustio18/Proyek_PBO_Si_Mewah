
using System;
using System.Linq;
using System.Windows.Forms;
using SiMewah.Controllers;
using SiMewah.Repositories;
using System.Collections.Generic;

using ModelTelur = SiMewah.Models.Telur;

namespace SiMewah.Views.Produksi.Penetasan
{
    public partial class FormPenetasan : Form
    {
        private readonly TelurController _telurController;
        private readonly PenetasanController _penetasanController;
        private readonly PerkawinanController _perkawinanController;
        private readonly BurungController _burungController;

        public DateTime TanggalPencatatan
        {
            get { return dtpTanggal.Value.Date; }
        }

        public int JumlahMenetas
        {
            get { return (int)numMenetas.Value; }
        }

        public int JumlahGagal
        {
            get { return (int)numGagal.Value; }
        }

        public Guid IdTelur
        {
            get
            {
                return cmbTelur.SelectedValue == null
                    ? Guid.Empty
                    : (Guid)cmbTelur.SelectedValue;
            }
        }

        public FormPenetasan()
        {
            InitializeComponent();

            _telurController = new TelurController(
                new TelurRepository()
            );

            _penetasanController = new PenetasanController(
                new PenetasanRepository(),
                new TelurRepository()
            );

            _perkawinanController = new PerkawinanController(
                new PerkawinanRepository()
            );

            _burungController = new BurungController(
                new BurungRepository(),
                new KandangRepository()
            );
            btnSimpan.Click += btnSimpan_Click;
            btnBatal.Click += btnBatal_Click;

            cmbTelur.SelectedIndexChanged += cmbTelur_SelectedIndexChanged;

            MuatDataTelur(null);
        }

        // Constructor untuk mengubah data penetasan
        public FormPenetasan(
            DateTime tanggal,
            int jumlahMenetas,
            int jumlahGagal,
            Guid idTelur
        )
        {
            InitializeComponent();

            _telurController = new TelurController(
                new TelurRepository()
            );

            _penetasanController = new PenetasanController(
                new PenetasanRepository(),
                new TelurRepository()
            );

            btnSimpan.Click += btnSimpan_Click;
            btnBatal.Click += btnBatal_Click;

            cmbTelur.SelectedIndexChanged += cmbTelur_SelectedIndexChanged;

            MuatDataTelur(idTelur);

            dtpTanggal.Value = tanggal;
            numMenetas.Value = jumlahMenetas;
            numGagal.Value = jumlahGagal;

            dtpTanggal.Enabled = false;
            cmbTelur.Enabled = false;

            lblJudul.Text = "Ubah Data Penetasan";
            Text = "Ubah Data Penetasan";
        }


        private class PilihanTelur
        {
            public Guid IdTelur { get; set; }
            public int JumlahTelur { get; set; }
            public string Keterangan { get; set; } = "";

            public override string ToString()
            {
                return Keterangan;
            }
        }

        private void MuatDataTelur(Guid? idTelurSaatIni)
        {
            var daftarTelur = _telurController.GetAll();
            var daftarPenetasan = _penetasanController.GetAll();
            var daftarPerkawinan = _perkawinanController.GetAll();
            var daftarBurung = _burungController.GetAll();

            var pilihanTelur = new List<PilihanTelur>();

            foreach (var telur in daftarTelur)
            {
                bool sudahAdaPenetasan = daftarPenetasan.Any(
                    p => p.IdTelur == telur.IdTelur
                );

                // Lewati kelompok telur yang sudah memiliki data penetasan,
                // kecuali kelompok telur yang sedang diedit.
                if (sudahAdaPenetasan && telur.IdTelur != idTelurSaatIni)
                    continue;

                var perkawinan = daftarPerkawinan.FirstOrDefault(
                    p => p.IdPerkawinan == telur.IdPerkawinan
                );

                if (perkawinan == null)
                    continue;

                var jantan = daftarBurung.FirstOrDefault(
                    b => b.IdBurung == perkawinan.IdBurungJantan
                );

                var betina = daftarBurung.FirstOrDefault(
                    b => b.IdBurung == perkawinan.IdBurungBetina
                );

                if (jantan == null || betina == null)
                    continue;

                string keterangan =
                    $"{perkawinan.TanggalPerkawinan:dd/MM/yyyy} | " +
                    $"{jantan.KodeBurung} - {betina.KodeBurung}";

                pilihanTelur.Add(new PilihanTelur
                {
                    IdTelur = telur.IdTelur,
                    JumlahTelur = telur.JumlahTelur,
                    Keterangan = keterangan
                });
            }

            cmbTelur.DataSource = null;
            cmbTelur.DisplayMember = "Keterangan";
            cmbTelur.ValueMember = "IdTelur";
            cmbTelur.DataSource = pilihanTelur;

            TampilkanJumlahTelur();
        }


        // Menampilkan jumlah telur berdasarkan pilihan
        private void cmbTelur_SelectedIndexChanged(
            object? sender,
            EventArgs e
        )
        {
            TampilkanJumlahTelur();
        }
        private void TampilkanJumlahTelur()
        {
            if (cmbTelur.SelectedItem is not PilihanTelur pilihan)
            {
                txtTotalTelur.Text = "0";
                return;
            }

            txtTotalTelur.Text = pilihan.JumlahTelur.ToString();

            numMenetas.Maximum = pilihan.JumlahTelur;
            numGagal.Maximum = pilihan.JumlahTelur;
        }

        // Tombol Simpan
        private void btnSimpan_Click(object? sender, EventArgs e)
        {
            if (cmbTelur.SelectedValue == null)
            {
                MessageBox.Show("Pilih kelompok telur terlebih dahulu.");
                return;
            }

            int totalTelur = int.Parse(txtTotalTelur.Text);

            if (JumlahMenetas + JumlahGagal > totalTelur)
            {
                MessageBox.Show(
                    "Jumlah menetas dan gagal tidak boleh melebihi jumlah telur."
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
