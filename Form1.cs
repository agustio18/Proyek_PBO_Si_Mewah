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
            FormBurung form = new FormBurung();
            form.Show();
            this.Hide();
        }

        private void btnKandang_Click(object sender, EventArgs e)
        {
            FormKandang form = new FormKandang();
            form.Show();
            this.Hide();
        }
    }
}
