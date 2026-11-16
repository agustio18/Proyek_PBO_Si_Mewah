using System;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using SiMewah.Repositories;
using SiMewah.Controllers;

using ModelBurung = SiMewah.Models.Burung;
using ModelKandang = SiMewah.Models.Kandang;


namespace SiMewah.Views.Produksi.Perkawinan
{
    public partial class FormPerkawinan : Form
    {
        private readonly BurungController _burungController;

        private Guid? _idBurungJantan;
        private Guid? _idBurungBetina;

        public DateTime TanggalPerkawinan
        {
            get { return dtp_tanggal.Value.Date; }
        }

        public Guid IdBurungJantan
        {
            get { return _idBurungJantan ?? Guid.Empty; }
        }

        public Guid IdBurungBetina
        {
            get { return _idBurungBetina ?? Guid.Empty; }
        }

        public string BurungJantan
        {
            get { return cmb_jantan.Text; }
        }

        public string BurungBetina
        {
            get { return cmb_betina.Text; }
        }

        public FormPerkawinan()
        {
            InitializeComponent();

            IRepository<ModelBurung> burungRepository = new BurungRepository();
            IRepository<ModelKandang> kandangRepository = new KandangRepository();

            _burungController = new BurungController(
                burungRepository,
                kandangRepository
            );

            btn_simpan.Click += btn_simpan_Click;
            btn_batal.Click += btn_batal_Click;

            cmb_jantan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_betina.DropDownStyle = ComboBoxStyle.DropDownList;

            StartPosition = FormStartPosition.CenterParent;

            MuatDataBurung();
        }

        // Constructor untuk mengubah data
        public FormPerkawinan(
            DateTime tanggal,
            Guid idJantan,
            Guid idBetina
        ) : this()
        {
            dtp_tanggal.Value = tanggal;

            cmb_jantan.SelectedValue = idJantan;
            cmb_betina.SelectedValue = idBetina;

            lbl_judul.Text = "Ubah Data Perkawinan";
            Text = "Ubah Data Perkawinan";
        }

        private void MuatDataBurung()
        {
            try
            {
                List<ModelBurung> daftarBurung = _burungController.GetAll();

                var daftarJantan = daftarBurung
                    .Where(b => b.Status == "aktif" &&
                                b.JenisKelamin == "jantan")
                    .ToList();

                var daftarBetina = daftarBurung
                    .Where(b => b.Status == "aktif" &&
                                b.JenisKelamin == "betina")
                    .ToList();

                cmb_jantan.DataSource = daftarJantan;
                cmb_jantan.DisplayMember = "KodeBurung";
                cmb_jantan.ValueMember = "IdBurung";

                cmb_betina.DataSource = daftarBetina;
                cmb_betina.DisplayMember = "KodeBurung";
                cmb_betina.ValueMember = "IdBurung";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat data burung: " + ex.Message,
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btn_simpan_Click(object? sender, EventArgs e)
        {
            if (cmb_jantan.SelectedValue == null ||
                cmb_betina.SelectedValue == null)
            {
                MessageBox.Show(
                    "Burung jantan dan betina harus dipilih.",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            Guid idJantan = (Guid)cmb_jantan.SelectedValue;
            Guid idBetina = (Guid)cmb_betina.SelectedValue;

            if (idJantan == idBetina)
            {
                MessageBox.Show(
                    "Burung jantan dan betina tidak boleh sama.",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            _idBurungJantan = idJantan;
            _idBurungBetina = idBetina;

            DialogResult = DialogResult.OK;
            Close();
        }
        private void btn_batal_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
