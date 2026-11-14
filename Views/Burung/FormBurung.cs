using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SiMewah.Controllers;
using BurungModel = SiMewah.Models.Burung;
using KandangModel = SiMewah.Models.Kandang;

namespace SiMewah.Views.Burung
{
    public partial class FormBurung : Form
    {
        private readonly BurungController _controller;
        private readonly List<KandangModel> _daftarKandang;
        private readonly BurungModel? _dataLama;

        public FormBurung(BurungController controller, List<KandangModel> daftarKandang)
            : this(controller, daftarKandang, null)
        {
        }

        public FormBurung(
            BurungController controller,
            List<KandangModel> daftarKandang,
            BurungModel? dataLama)
        {
            _controller = controller;
            _daftarKandang = daftarKandang;
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
            cmbJenisKelamin.Items.Clear();
            cmbJenisKelamin.Items.Add("jantan");
            cmbJenisKelamin.Items.Add("betina");

            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("aktif");
            cmbStatus.Items.Add("terjual");
            cmbStatus.Items.Add("mati");

            cmbKandang.Items.Clear();
            foreach (KandangModel kandang in _daftarKandang)
            {
                cmbKandang.Items.Add(new KandangItem(kandang.IdKandang, TampilanKandang(kandang)));
            }

            if (_dataLama == null)
            {
                cmbJenisKelamin.SelectedIndex = 0;
                cmbStatus.SelectedIndex = 0;
                dtpTanggalLahir.Value = DateTime.Today;
            }
            else
            {
                IsiForm(_dataLama);
            }

            if (cmbKandang.Items.Count > 0 && cmbKandang.SelectedIndex < 0)
            {
                cmbKandang.SelectedIndex = 0;
            }
        }

        private void IsiForm(BurungModel burung)
        {
            txtKode.Text = burung.KodeBurung;
            cmbJenisKelamin.SelectedItem = burung.JenisKelamin;
            dtpTanggalLahir.Value = burung.TanggalLahir.ToDateTime(TimeOnly.MinValue);
            cmbStatus.SelectedItem = burung.Status;

            for (int i = 0; i < cmbKandang.Items.Count; i++)
            {
                if (cmbKandang.Items[i] is KandangItem item && item.Id == burung.IdKandang)
                {
                    cmbKandang.SelectedIndex = i;
                    break;
                }
            }

            lblJudul.Text = "Ubah Data Burung";
            Text = "Ubah Data Burung";
        }

        private void btnSimpan_Click(object? sender, EventArgs e)
        {
            string kode = txtKode.Text.Trim();

            if (kode.Length == 0)
            {
                MessageBox.Show("Kode burung harus diisi.",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKode.Focus();
                return;
            }

            if (cmbJenisKelamin.SelectedItem == null)
            {
                MessageBox.Show("Jenis kelamin harus dipilih.",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Status harus dipilih.",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbKandang.SelectedItem is not KandangItem kandang)
            {
                MessageBox.Show("Kandang harus dipilih.",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string jenisKelamin = cmbJenisKelamin.SelectedItem.ToString()!;
            string status = cmbStatus.SelectedItem.ToString()!;
            DateOnly tanggalLahir = DateOnly.FromDateTime(dtpTanggalLahir.Value);

            try
            {
                if (_dataLama == null)
                {
                    BurungModel burungBaru = new BurungModel(
                        Guid.NewGuid(),
                        kode,
                        jenisKelamin,
                        tanggalLahir,
                        status,
                        kandang.Id);
                    _controller.Tambah(burungBaru);
                }
                else
                {
                    BurungModel burungUbah = new BurungModel(
                        _dataLama.IdBurung,
                        kode,
                        jenisKelamin,
                        tanggalLahir,
                        status,
                        kandang.Id);
                    _controller.Ubah(burungUbah);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data burung: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private static string TampilanKandang(KandangModel kandang)
        {
            if (string.IsNullOrWhiteSpace(kandang.Keterangan))
            {
                return kandang.JenisKandang;
            }

            return kandang.JenisKandang + " - " + kandang.Keterangan;
        }

        private sealed class KandangItem
        {
            public Guid Id { get; }
            private readonly string _tampilan;

            public KandangItem(Guid id, string tampilan)
            {
                Id = id;
                _tampilan = tampilan;
            }

            public override string ToString()
            {
                return _tampilan;
            }
        }
    }
}
