using SiMewah.Views.FormProduksi;
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
    }
}
