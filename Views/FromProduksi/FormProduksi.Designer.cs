namespace SiMewah.Views.FormProduksi
{
    partial class FormProduksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnl_header = new Panel();
            lbl_judul = new Label();
            pnl_sidebar = new Panel();
            btn_telur = new Button();
            btn_penetasan = new Button();
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
            pnl_header.Size = new Size(1182, 99);
            pnl_header.TabIndex = 0;
            // 
            // lbl_judul
            // 
            lbl_judul.AutoSize = true;
            lbl_judul.Font = new Font("Bodoni MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_judul.Location = new Point(502, 34);
            lbl_judul.Name = "lbl_judul";
            lbl_judul.Size = new Size(130, 23);
            lbl_judul.TabIndex = 0;
            lbl_judul.Text = "Data Produksi";
            // 
            // pnl_sidebar
            // 
            pnl_sidebar.Controls.Add(btn_telur);
            pnl_sidebar.Controls.Add(btn_penetasan);
            pnl_sidebar.Controls.Add(btn_perkawinan);
            pnl_sidebar.Dock = DockStyle.Left;
            pnl_sidebar.Location = new Point(0, 99);
            pnl_sidebar.Name = "pnl_sidebar";
            pnl_sidebar.Size = new Size(250, 604);
            pnl_sidebar.TabIndex = 1;
            // 
            // btn_telur
            // 
            btn_telur.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            btn_telur.Location = new Point(10, 105);
            btn_telur.Name = "btn_telur";
            btn_telur.Size = new Size(230, 55);
            btn_telur.TabIndex = 2;
            btn_telur.Text = "Data Telur";
            btn_telur.UseVisualStyleBackColor = true;
            // 
            // btn_penetasan
            // 
            btn_penetasan.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            btn_penetasan.Location = new Point(10, 185);
            btn_penetasan.Name = "btn_penetasan";
            btn_penetasan.Size = new Size(230, 55);
            btn_penetasan.TabIndex = 1;
            btn_penetasan.Text = "Data Penetasan";
            btn_penetasan.UseVisualStyleBackColor = true;
            // 
            // btn_perkawinan
            // 
            btn_perkawinan.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            btn_perkawinan.Location = new Point(10, 25);
            btn_perkawinan.Name = "btn_perkawinan";
            btn_perkawinan.Size = new Size(230, 55);
            btn_perkawinan.TabIndex = 0;
            btn_perkawinan.Text = "Data Perkawinan";
            btn_perkawinan.UseVisualStyleBackColor = true;
            // 
            // pnl_konten
            // 
            pnl_konten.Controls.Add(lbl_konten);
            pnl_konten.Dock = DockStyle.Fill;
            pnl_konten.Location = new Point(250, 99);
            pnl_konten.Name = "pnl_konten";
            pnl_konten.Size = new Size(932, 604);
            pnl_konten.TabIndex = 2;
            // 
            // lbl_konten
            // 
            lbl_konten.Dock = DockStyle.Fill;
            lbl_konten.Font = new Font("Bodoni MT", 10F, FontStyle.Bold);
            lbl_konten.Location = new Point(0, 0);
            lbl_konten.TextAlign = ContentAlignment.MiddleCenter;
            lbl_konten.Name = "lbl_konten";
            lbl_konten.Size = new Size(1000, 650);
            lbl_konten.TabIndex = 0;
            lbl_konten.Text = "Pilih menu Data Produksi";
            // 
            // FormProduksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 703);
            Controls.Add(pnl_konten);
            Controls.Add(pnl_sidebar);
            Controls.Add(pnl_header);
            MinimumSize = new Size(1000, 650);
            Name = "FormProduksi";
            Text = "Data Produksi";
            pnl_header.ResumeLayout(false);
            pnl_header.PerformLayout();
            pnl_sidebar.ResumeLayout(false);
            pnl_konten.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_header;
        private Panel pnl_sidebar;
        private Label lbl_judul;
        private Panel pnl_konten;
        private Button btn_perkawinan;
        private Button btn_telur;
        private Button btn_penetasan;
        private Label lbl_konten;
    }
}