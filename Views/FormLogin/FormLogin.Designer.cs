
namespace SiMewah.Views
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblJudul = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblPesan = new Label();

            SuspendLayout();

            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Palatino Linotype", 20F, FontStyle.Bold);
            lblJudul.Location = new Point(120, 35);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(210, 45);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "LOGIN SiMewah";

            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Palatino Linotype", 11F);
            lblUsername.Location = new Point(55, 115);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(87, 24);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";

            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Palatino Linotype", 11F);
            txtUsername.Location = new Point(55, 145);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(330, 32);
            txtUsername.TabIndex = 2;

            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Palatino Linotype", 11F);
            lblPassword.Location = new Point(55, 195);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(82, 24);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";

            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Palatino Linotype", 11F);
            txtPassword.Location = new Point(55, 225);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(330, 32);
            txtPassword.TabIndex = 4;

            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Palatino Linotype", 11F, FontStyle.Bold);
            btnLogin.Location = new Point(55, 295);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(330, 45);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;

            // 
            // lblPesan
            // 
            lblPesan.Font = new Font("Palatino Linotype", 9F);
            lblPesan.ForeColor = Color.Red;
            lblPesan.Location = new Point(55, 265);
            lblPesan.Name = "lblPesan";
            lblPesan.Size = new Size(330, 25);
            lblPesan.TabIndex = 6;
            lblPesan.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // FormLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 390);
            Controls.Add(lblJudul);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPesan);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login SiMewah";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJudul;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblPesan;
    }
}
