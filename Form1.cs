using SiMewah.Views.FormProduksi;
using SiMewah.Views.Burung;
using SiMewah.Views.Kandang;
using SiMewah.Views.Perawatan;
using SiMewah.Views.Rekomendasi;
namespace SiMewah
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnProduksi_Click(object sender, EventArgs e)
        {
            FormProduksi form = new FormProduksi();

            form.Show(this);

            this.Hide();
        }

        private void btnBurung_Click(object sender, EventArgs e)
        {
            using UcBurung form = new UcBurung();
            form.ShowDialog(this);
        }

        private void btnKandang_Click(object sender, EventArgs e)
        {
            using UcKandang form = new UcKandang();
            form.ShowDialog(this);
        }

        private void btnPerawatan_Click(object sender, EventArgs e)
        {
            using UcPerawatan form = new UcPerawatan();
            form.ShowDialog(this);
        }

        private void btnRekomendasi_Click(object sender, EventArgs e)
        {
            using UcRekomendasi form = new UcRekomendasi();
            form.ShowDialog(this);
        }
    }
}
