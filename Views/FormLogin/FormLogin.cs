
using SiMewah.Controllers;

namespace SiMewah.Views
{
    public partial class FormLogin : Form
    {
        private readonly AuthController authController;

        public FormLogin()
        {
            InitializeComponent();

            authController = new AuthController();

            btnLogin.Click += btnLogin_Click;
        }

        private void btnLogin_Click(object? sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                lblPesan.Text = "Username dan password harus diisi.";
                return;
            }

            try
            {
                bool berhasil = authController.Login(username, password);

                if (berhasil)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    lblPesan.Text = "Username atau password salah.";
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Terjadi kesalahan saat proses login.\n" + ex.Message,
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
