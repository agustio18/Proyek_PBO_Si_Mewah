
namespace SiMewah.Views.FormProduksi
{
    partial class FormProduksi
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnl_header = new Panel();
            lbl_judul = new Label();
            pnl_sidebar = new Panel();
            btn_keluar = new Button();
            btn_penetasan = new Button();
            btn_telur = new Button();
            btn_perkawinan = new Button();
            pnl_konten = new Panel();
            lbl_konten = new Label();

            pnl_header.SuspendLayout();
            pnl_sidebar.SuspendLayout();
            pnl_konten.SuspendLayout();
            SuspendLayout();

            // 
            // pnl_header
            // 
            pnl_header.BackColor = Color.FromArgb(53, 92, 69);
            pnl_header.Controls.Add(lbl_judul);
            pnl_header.Dock = DockStyle.Top;
            pnl_header.Location = new Point(0, 0);
            pnl_header.Name = "pnl_header";
            pnl_header.Size = new Size(1100, 70);
            pnl_header.TabIndex = 0;

            // 
            // lbl_judul
            // 
            lbl_judul.Dock = DockStyle.Fill;
            lbl_judul.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lbl_judul.ForeColor = Color.White;
            lbl_judul.Location = new Point(0, 0);
            lbl_judul.Name = "lbl_judul";
            lbl_judul.Size = new Size(1100, 70);
            lbl_judul.TabIndex = 0;
            lbl_judul.Text = "DATA PRODUKSI";
            lbl_judul.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // pnl_sidebar
            // 
            pnl_sidebar.BackColor = Color.FromArgb(247, 245, 237);
            pnl_sidebar.Controls.Add(btn_keluar);
            pnl_sidebar.Controls.Add(btn_penetasan);
            pnl_sidebar.Controls.Add(btn_telur);
            pnl_sidebar.Controls.Add(btn_perkawinan);
            pnl_sidebar.Dock = DockStyle.Left;
            pnl_sidebar.Location = new Point(0, 70);
            pnl_sidebar.Name = "pnl_sidebar";
            pnl_sidebar.Size = new Size(220, 630);
            pnl_sidebar.TabIndex = 1;

            // 
            // btn_perkawinan
            // 
            btn_perkawinan.BackColor = Color.White;
            btn_perkawinan.Cursor = Cursors.Hand;
            btn_perkawinan.FlatAppearance.BorderColor = Color.FromArgb(227, 231, 225);
            btn_perkawinan.FlatStyle = FlatStyle.Flat;
            btn_perkawinan.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btn_perkawinan.ForeColor = Color.FromArgb(53, 92, 69);
            btn_perkawinan.Location = new Point(24, 28);
            btn_perkawinan.Name = "btn_perkawinan";
            btn_perkawinan.Size = new Size(172, 38);
            btn_perkawinan.TabIndex = 0;
            btn_perkawinan.Text = "Data Perkawinan";
            btn_perkawinan.UseVisualStyleBackColor = false;

            // 
            // btn_telur
            // 
            btn_telur.BackColor = Color.White;
            btn_telur.Cursor = Cursors.Hand;
            btn_telur.FlatAppearance.BorderColor = Color.FromArgb(227, 231, 225);
            btn_telur.FlatStyle = FlatStyle.Flat;
            btn_telur.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btn_telur.ForeColor = Color.FromArgb(53, 92, 69);
            btn_telur.Location = new Point(24, 80);
            btn_telur.Name = "btn_telur";
            btn_telur.Size = new Size(172, 38);
            btn_telur.TabIndex = 1;
            btn_telur.Text = "Data Telur";
            btn_telur.UseVisualStyleBackColor = false;

            // 
            // btn_penetasan
            // 
            btn_penetasan.BackColor = Color.White;
            btn_penetasan.Cursor = Cursors.Hand;
            btn_penetasan.FlatAppearance.BorderColor = Color.FromArgb(227, 231, 225);
            btn_penetasan.FlatStyle = FlatStyle.Flat;
            btn_penetasan.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btn_penetasan.ForeColor = Color.FromArgb(53, 92, 69);
            btn_penetasan.Location = new Point(24, 132);
            btn_penetasan.Name = "btn_penetasan";
            btn_penetasan.Size = new Size(172, 38);
            btn_penetasan.TabIndex = 2;
            btn_penetasan.Text = "Data Penetasan";
            btn_penetasan.UseVisualStyleBackColor = false;

            // 
            // btn_keluar
            // 
            btn_keluar.BackColor = Color.White;
            btn_keluar.Cursor = Cursors.Hand;
            btn_keluar.FlatAppearance.BorderColor = Color.FromArgb(227, 231, 225);
            btn_keluar.FlatStyle = FlatStyle.Flat;
            btn_keluar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btn_keluar.ForeColor = Color.FromArgb(53, 92, 69);
            btn_keluar.Location = new Point(24, 564);
            btn_keluar.Name = "btn_keluar";
            btn_keluar.Size = new Size(172, 38);
            btn_keluar.TabIndex = 3;
            btn_keluar.Text = "Kembali ke Beranda";
            btn_keluar.UseVisualStyleBackColor = false;

            // 
            // pnl_konten
            // 
            pnl_konten.BackColor = Color.FromArgb(247, 245, 237);
            pnl_konten.Controls.Add(lbl_konten);
            pnl_konten.Dock = DockStyle.Fill;
            pnl_konten.Location = new Point(220, 70);
            pnl_konten.Name = "pnl_konten";
            pnl_konten.Padding = new Padding(20);
            pnl_konten.Size = new Size(880, 630);
            pnl_konten.TabIndex = 2;

            // 
            // lbl_konten
            // 
            lbl_konten.Dock = DockStyle.Fill;
            lbl_konten.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            lbl_konten.ForeColor = Color.FromArgb(120, 128, 120);
            lbl_konten.Location = new Point(20, 20);
            lbl_konten.Name = "lbl_konten";
            lbl_konten.Size = new Size(840, 590);
            lbl_konten.TabIndex = 0;
            lbl_konten.Text = "Silakan pilih menu Data Produksi";
            lbl_konten.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // FormProduksi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 245, 237);
            ClientSize = new Size(1100, 700);
            Controls.Add(pnl_konten);
            Controls.Add(pnl_sidebar);
            Controls.Add(pnl_header);
            Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormProduksi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data Produksi";

            pnl_header.ResumeLayout(false);
            pnl_sidebar.ResumeLayout(false);
            pnl_konten.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_header;
        private Label lbl_judul;
        private Panel pnl_sidebar;
        private Button btn_perkawinan;
        private Button btn_telur;
        private Button btn_penetasan;
        private Button btn_keluar;
        private Panel pnl_konten;
        private Label lbl_konten;
    }
}
