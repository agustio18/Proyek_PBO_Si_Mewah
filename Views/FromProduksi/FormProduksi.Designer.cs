
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
            pnl_header.Controls.Add(lbl_judul);
            pnl_header.Dock = DockStyle.Top;
            pnl_header.Location = new Point(0, 0);
            pnl_header.Name = "pnl_header";
            pnl_header.Size = new Size(1000, 75);
            pnl_header.TabIndex = 0;

            // 
            // lbl_judul
            // 
            lbl_judul.Dock = DockStyle.Fill;
            lbl_judul.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold);
            lbl_judul.Location = new Point(0, 0);
            lbl_judul.Name = "lbl_judul";
            lbl_judul.Size = new Size(1000, 75);
            lbl_judul.TabIndex = 0;
            lbl_judul.Text = "DATA PRODUKSI";
            lbl_judul.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // pnl_sidebar
            // 
            pnl_sidebar.Controls.Add(btn_keluar);
            pnl_sidebar.Controls.Add(btn_penetasan);
            pnl_sidebar.Controls.Add(btn_telur);
            pnl_sidebar.Controls.Add(btn_perkawinan);
            pnl_sidebar.Dock = DockStyle.Left;
            pnl_sidebar.Location = new Point(0, 75);
            pnl_sidebar.Name = "pnl_sidebar";
            pnl_sidebar.Size = new Size(220, 525);
            pnl_sidebar.TabIndex = 1;

            // 
            // btn_perkawinan
            // 
            btn_perkawinan.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            btn_perkawinan.Location = new Point(15, 30);
            btn_perkawinan.Name = "btn_perkawinan";
            btn_perkawinan.Size = new Size(190, 50);
            btn_perkawinan.TabIndex = 0;
            btn_perkawinan.Text = "Data Perkawinan";
            btn_perkawinan.UseVisualStyleBackColor = true;

            // 
            // btn_telur
            // 
            btn_telur.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            btn_telur.Location = new Point(15, 100);
            btn_telur.Name = "btn_telur";
            btn_telur.Size = new Size(190, 50);
            btn_telur.TabIndex = 1;
            btn_telur.Text = "Data Telur";
            btn_telur.UseVisualStyleBackColor = true;

            // 
            // btn_penetasan
            // 
            btn_penetasan.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            btn_penetasan.Location = new Point(15, 170);
            btn_penetasan.Name = "btn_penetasan";
            btn_penetasan.Size = new Size(190, 50);
            btn_penetasan.TabIndex = 2;
            btn_penetasan.Text = "Data Penetasan";
            btn_penetasan.UseVisualStyleBackColor = true;

            // 
            // btn_keluar
            // 
            btn_keluar.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            btn_keluar.Location = new Point(15, 250);
            btn_keluar.Name = "btn_keluar";
            btn_keluar.Size = new Size(190, 45);
            btn_keluar.TabIndex = 3;
            btn_keluar.Text = "Kembali ke Beranda";
            btn_keluar.UseVisualStyleBackColor = true;

            // 
            // pnl_konten
            // 
            pnl_konten.Controls.Add(lbl_konten);
            pnl_konten.Dock = DockStyle.Fill;
            pnl_konten.Location = new Point(220, 75);
            pnl_konten.Name = "pnl_konten";
            pnl_konten.Padding = new Padding(15);
            pnl_konten.Size = new Size(780, 525);
            pnl_konten.TabIndex = 2;

            // 
            // lbl_konten
            // 
            lbl_konten.Dock = DockStyle.Fill;
            lbl_konten.Font = new Font("Palatino Linotype", 14F);
            lbl_konten.Location = new Point(15, 15);
            lbl_konten.Name = "lbl_konten";
            lbl_konten.Size = new Size(750, 495);
            lbl_konten.TabIndex = 0;
            lbl_konten.Text = "Silakan pilih menu Data Produksi";
            lbl_konten.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // FormProduksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(pnl_konten);
            Controls.Add(pnl_sidebar);
            Controls.Add(pnl_header);
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
