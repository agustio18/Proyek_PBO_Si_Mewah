using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SiMewah.Controllers;
using PerawatanModel = SiMewah.Models.Perawatan;
using BurungModel = SiMewah.Models.Burung;

namespace SiMewah.Views.Perawatan
{
    public partial class FormPerawatan : Form
    {
        private readonly PerawatanController _controller;
        private readonly PerawatanModel? _dataLama;

        public FormPerawatan(
            PerawatanController controller,
            List<BurungModel> daftarBurung,
            PerawatanModel? dataLama = null)
        {
            InitializeComponent();

            _controller = controller;
            _dataLama = dataLama;

            StartPosition = FormStartPosition.CenterParent;

            cmbJenisPerawatan.Items.Clear();
            cmbJenisPerawatan.Items.Add("Pemberian Pakan");
            cmbJenisPerawatan.Items.Add("Pemberian Vitamin");

            cmbBurung.Items.Clear();

            foreach (BurungModel burung in daftarBurung)
            {
                cmbBurung.Items.Add(
                    new BurungItem(burung.IdBurung, burung.KodeBurung));
            }

            cmbBurung.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJenisPerawatan.DropDownStyle = ComboBoxStyle.DropDownList;

            dtpTanggalPerawatan.Format = DateTimePickerFormat.Short;
            dtpTanggalPerawatan.MaxDate = DateTime.Today;

            btnSimpan.Click += btnSimpan_Click;
            btnBatal.Click += btnBatal_Click;

            if (_dataLama == null)
            {
                Text = "Tambah Data Perawatan";
                lblJudul.Text = "Tambah Data Perawatan";
                dtpTanggalPerawatan.Value = DateTime.Today;
            }
            else
            {
                Text = "Ubah Data Perawatan";
                lblJudul.Text = "Ubah Data Perawatan";

                cmbJenisPerawatan.SelectedItem = _dataLama.JenisPerawatan;
                dtpTanggalPerawatan.Value =
                    _dataLama.TanggalPerawatan.ToDateTime(TimeOnly.MinValue);
                txtJumlahPerawatan.Text =
                    _dataLama.JumlahPerawatan.ToString();

                foreach (BurungItem item in cmbBurung.Items)
                {
                    if (item.IdBurung == _dataLama.IdBurung)
                    {
                        cmbBurung.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        private void btnSimpan_Click(object? sender, EventArgs e)
        {
            try
            {
                if (cmbBurung.SelectedItem == null)
                {
                    MessageBox.Show("Silakan pilih burung terlebih dahulu.");
                    return;
                }

                if (cmbJenisPerawatan.SelectedItem == null)
                {
                    MessageBox.Show("Silakan pilih jenis perawatan.");
                    return;
                }

                if (!int.TryParse(txtJumlahPerawatan.Text, out int jumlah))
                {
                    MessageBox.Show("Jumlah perawatan harus berupa angka.");
                    return;
                }

                BurungItem burung = (BurungItem)cmbBurung.SelectedItem;
                string jenis = cmbJenisPerawatan.SelectedItem.ToString()!;
                DateOnly tanggal =
                    DateOnly.FromDateTime(dtpTanggalPerawatan.Value);

                if (_dataLama == null)
                {
                    PerawatanModel data = new PerawatanModel(
                        jenis, tanggal, jumlah, burung.IdBurung);

                    _controller.Tambah(data);
                }
                else
                {
                    PerawatanModel data = new PerawatanModel(
                        _dataLama.IdPerawatan,
                        jenis,
                        tanggal,
                        jumlah,
                        burung.IdBurung,
                        _dataLama.IsDelete);

                    _controller.Ubah(data);
                }

                MessageBox.Show("Data perawatan berhasil disimpan.");

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Gagal Menyimpan Data",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private class BurungItem
        {
            public Guid IdBurung { get; set; }
            private string KodeBurung { get; set; }

            public BurungItem(Guid idBurung, string kodeBurung)
            {
                IdBurung = idBurung;
                KodeBurung = kodeBurung;
            }

            public override string ToString()
            {
                return KodeBurung;
            }
        }
    }
}