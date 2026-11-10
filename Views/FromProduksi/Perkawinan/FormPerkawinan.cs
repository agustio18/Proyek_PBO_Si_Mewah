
using System;
using System.Windows.Forms;

namespace SiMewah.Views.Produksi.Perkawinan
{
    public partial class FormPerkawinan : Form
    {
        public DateTime TanggalPerkawinan
        {
            get { return dtp_tanggal.Value.Date; }
        }

        public string BurungJantan
        {
            get { return cmb_jantan.Text.Trim(); }
        }

        public string BurungBetina
        {
            get { return cmb_betina.Text.Trim(); }
        }

        public FormPerkawinan()
        {
            InitializeComponent();

            btn_simpan.Click += btn_simpan_Click;
            btn_batal.Click += btn_batal_Click;

            StartPosition = FormStartPosition.CenterParent;
        }

        // Constructor untuk mengisi data ketika melakukan Ubah
        public FormPerkawinan(DateTime tanggal, string jantan, string betina)
            : this()
        {
            dtp_tanggal.Value = tanggal;
            cmb_jantan.Text = jantan;
            cmb_betina.Text = betina;

            lbl_judul.Text = "Ubah Data Perkawinan";
            Text = "Ubah Data Perkawinan";
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BurungJantan) ||
                string.IsNullOrWhiteSpace(BurungBetina))
            {
                MessageBox.Show(
                    "Burung jantan dan betina harus diisi.",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (BurungJantan == BurungBetina)
            {
                MessageBox.Show(
                    "Burung jantan dan betina tidak boleh sama.",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
