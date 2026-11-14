using SiMewah.Views.FormProduksi;
using SiMewah.Views.Burung;
using SiMewah.Views.Kandang;
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
            form.Show();
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
    }
}
