
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using SiMewah.Controllers;
using SiMewah.Repositories;
using SiMewah.Models;

using ModelBurung = SiMewah.Models.Burung;
using ModelKandang = SiMewah.Models.Kandang;
using ModelPerkawinan = SiMewah.Models.Perkawinan;

namespace SiMewah.Views.Produksi.Perkawinan
{
    public partial class UcPerkawinan : UserControl
    {
        private readonly PerkawinanController _controller;
        private readonly BurungController _burungController;

        private Dictionary<Guid, string> _kodeBurung = new();

        public UcPerkawinan()
        {
            InitializeComponent();

            _controller = new PerkawinanController(
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

            btn_tambah_perkawinan.Click += btn_tambah_perkawinan_Click;
            btn_ubah.Click += btn_ubah_Click;
            btn_pencarian.Click += btn_pencarian_Click;

            MuatDataBurung();
            MuatDataPerkawinan();
        }

        // Mengambil data burung untuk menampilkan kode burung
        private void MuatDataBurung()
        {
            try
            {
                var daftarBurung = _burungController.GetAll();

                _kodeBurung = daftarBurung.ToDictionary(
                    b => b.IdBurung,
                    b => b.KodeBurung
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat data burung: " + ex.Message
                );
            }
        }

        // Mengambil data perkawinan dari PostgreSQL
        private void MuatDataPerkawinan()
        {
            try
            {
                dg_perkawinan.Rows.Clear();

                List<ModelPerkawinan> daftar =
                    _controller.GetAll();

                foreach (var data in daftar)
                {
                    string kodeJantan =
                        _kodeBurung.TryGetValue(
                            data.IdBurungJantan,
                            out string? jantan
                        ) ? jantan : "Tidak ditemukan";

                    string kodeBetina =
                        _kodeBurung.TryGetValue(
                            data.IdBurungBetina,
                            out string? betina
                        ) ? betina : "Tidak ditemukan";

                    dg_perkawinan.Rows.Add(
                        data.TanggalPerkawinan.ToDateTime(
                            TimeOnly.MinValue
                        ),
                        data.IdPerkawinan,
                        kodeJantan,
                        kodeBetina,
                        data.IdBurungJantan,
                        data.IdBurungBetina
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat data perkawinan: " + ex.Message
                );
            }
        }

        // Tombol Tambah
        private void btn_tambah_perkawinan_Click(
            object? sender,
            EventArgs e)
        {
            using (FormPerkawinan form = new FormPerkawinan())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ModelPerkawinan data = new ModelPerkawinan(
                            DateOnly.FromDateTime(form.TanggalPerkawinan),
                            form.IdBurungJantan,
                            form.IdBurungBetina
                        );

                        _controller.Tambah(data);

                        MessageBox.Show(
                            "Data perkawinan berhasil disimpan."
                        );

                        MuatDataPerkawinan();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "Gagal menyimpan data: " + ex.Message
                        );
                    }
                }
            }
        }

        // Tombol Ubah
        private void btn_ubah_Click(
            object? sender,
            EventArgs e)
        {
            if (dg_perkawinan.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Pilih data yang ingin diubah."
                );
                return;
            }

            DataGridViewRow baris =
                dg_perkawinan.SelectedRows[0];

            try
            {
                Guid idPerkawinan = Guid.Parse(
                    baris.Cells["col_id"].Value.ToString()!
                );

                DateTime tanggal = Convert.ToDateTime(
                    baris.Cells["col_tanggal"].Value
                );

                Guid idJantan = Guid.Parse(
                    baris.Cells["col_id_jantan"].Value.ToString()!
                );

                Guid idBetina = Guid.Parse(
                    baris.Cells["col_id_betina"].Value.ToString()!
                );

                using (FormPerkawinan form = new FormPerkawinan(
                    tanggal,
                    idJantan,
                    idBetina
                ))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        ModelPerkawinan data = new ModelPerkawinan(
                            idPerkawinan,
                            DateOnly.FromDateTime(
                                form.TanggalPerkawinan
                            ),
                            form.IdBurungJantan,
                            form.IdBurungBetina
                        );

                        _controller.Ubah(data);

                        MessageBox.Show(
                            "Data perkawinan berhasil diubah."
                        );

                        MuatDataPerkawinan();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal mengubah data: " + ex.Message
                );
            }
        }

        private void UcPerkawinan_Load(object sender, EventArgs e)
        {

        }


        private void btn_pencarian_Click(object? sender, EventArgs e)
        {
            string kataKunci = tb_pencarian.Text.Trim();

            foreach (DataGridViewRow baris in dg_perkawinan.Rows)
            {
                if (baris.IsNewRow)
                    continue;

                string tanggal = Convert.ToDateTime(
                    baris.Cells["col_tanggal"].Value
                ).ToString("dd/MM/yyyy");

                string jantan = Convert.ToString(
                    baris.Cells["col_jantan"].Value
                ) ?? "";

                string betina = Convert.ToString(
                    baris.Cells["col_betina"].Value
                ) ?? "";

                bool cocok =
                    tanggal.Contains(kataKunci,
                        StringComparison.OrdinalIgnoreCase) ||
                    jantan.Contains(kataKunci,
                        StringComparison.OrdinalIgnoreCase) ||
                    betina.Contains(kataKunci,
                        StringComparison.OrdinalIgnoreCase);

                baris.Visible = cocok;
            }
        }

    }
}
