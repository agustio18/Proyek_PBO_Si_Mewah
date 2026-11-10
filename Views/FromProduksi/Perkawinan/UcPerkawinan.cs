
using System;
using System.Windows.Forms;

namespace SiMewah.Views.Produksi.Perkawinan
{
    public partial class UcPerkawinan : UserControl
    {
        public UcPerkawinan()
        {
            InitializeComponent();

            btn_tambah_perkawinan.Click += btn_tambah_perkawinan_Click;
            btn_ubah.Click += btn_ubah_Click;
        }

        // Tombol Tambah
        private void btn_tambah_perkawinan_Click(object sender, EventArgs e)
        {
            using (FormPerkawinan form = new FormPerkawinan())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string id = Guid.NewGuid().ToString();

                    dg_perkawinan.Rows.Add(
                        form.TanggalPerkawinan,
                        id,
                        form.BurungJantan,
                        form.BurungBetina
                    );
                }
            }
        }

        // Tombol Ubah
        private void btn_ubah_Click(object sender, EventArgs e)
        {
            if (dg_perkawinan.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Pilih data perkawinan yang ingin diubah.",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DataGridViewRow baris = dg_perkawinan.SelectedRows[0];

            DateTime tanggal = Convert.ToDateTime(
                baris.Cells["col_tanggal"].Value
            );

            string jantan = Convert.ToString(
                baris.Cells["col_jantan"].Value
            ) ?? "";

            string betina = Convert.ToString(
                baris.Cells["col_betina"].Value
            ) ?? "";

            using (FormPerkawinan form = new FormPerkawinan(
                tanggal,
                jantan,
                betina
            ))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    baris.Cells["col_tanggal"].Value =
                        form.TanggalPerkawinan;

                    baris.Cells["col_jantan"].Value =
                        form.BurungJantan;

                    baris.Cells["col_betina"].Value =
                        form.BurungBetina;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Tidak ada aksi ketika judul diklik.
        }
    }
}
