namespace SiMewah
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblJudul = new Label();
            lblDeskripsi = new Label();
            btnBurung = new Button();
            btnProduksi = new Button();
            btnKandang = new Button();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Palatino Linotype", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.Location = new Point(59, 50);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(167, 38);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "SI MEWAH";
            // 
            // lblDeskripsi
            // 
            lblDeskripsi.AutoSize = true;
            lblDeskripsi.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeskripsi.Location = new Point(59, 98);
            lblDeskripsi.Name = "lblDeskripsi";
            lblDeskripsi.Size = new Size(634, 32);
            lblDeskripsi.TabIndex = 1;
            lblDeskripsi.Text = "Sistem Informasi Manajemen Peternakan Burung Kenari";
            // 
            // btnBurung
            // 
            btnBurung.Location = new Point(129, 181);
            btnBurung.Name = "btnBurung";
            btnBurung.Size = new Size(160, 64);
            btnBurung.TabIndex = 2;
            btnBurung.Text = "Data Burung";
            btnBurung.UseVisualStyleBackColor = true;
            btnBurung.Click += btnBurung_Click;
            // 
            // btnProduksi
            // 
            btnProduksi.Location = new Point(410, 184);
            btnProduksi.Name = "btnProduksi";
            btnProduksi.Size = new Size(145, 61);
            btnProduksi.TabIndex = 3;
            btnProduksi.Text = "Data Produksi";
            btnProduksi.UseVisualStyleBackColor = true;
            btnProduksi.Click += btnProduksi_Click;
            // 
            // btnKandang
            // 
            btnKandang.Location = new Point(133, 296);
            btnKandang.Name = "btnKandang";
            btnKandang.Size = new Size(156, 61);
            btnKandang.TabIndex = 4;
            btnKandang.Text = "Data Kandang";
            btnKandang.UseVisualStyleBackColor = true;
            btnKandang.Click += btnKandang_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKandang);
            Controls.Add(btnProduksi);
            Controls.Add(btnBurung);
            Controls.Add(lblDeskripsi);
            Controls.Add(lblJudul);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJudul;
        private Label lblDeskripsi;
        private Button btnBurung;
        private Button btnProduksi;
        private Button btnKandang;
    }
}
