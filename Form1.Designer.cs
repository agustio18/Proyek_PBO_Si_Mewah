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
            btnPerawatan = new Button();
            btnRekomendasi = new Button();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Palatino Linotype", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.Location = new Point(41, 30);
            lblJudul.Margin = new Padding(2, 0, 2, 0);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(115, 26);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "SI MEWAH";
            // 
            // lblDeskripsi
            // 
            lblDeskripsi.AutoSize = true;
            lblDeskripsi.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeskripsi.Location = new Point(41, 59);
            lblDeskripsi.Margin = new Padding(2, 0, 2, 0);
            lblDeskripsi.Name = "lblDeskripsi";
            lblDeskripsi.Size = new Size(433, 22);
            lblDeskripsi.TabIndex = 1;
            lblDeskripsi.Text = "Sistem Informasi Manajemen Peternakan Burung Kenari";
            // 
            // btnBurung
            // 
            btnBurung.Location = new Point(90, 109);
            btnBurung.Margin = new Padding(2, 2, 2, 2);
            btnBurung.Name = "btnBurung";
            btnBurung.Size = new Size(112, 38);
            btnBurung.TabIndex = 2;
            btnBurung.Text = "Data Burung";
            btnBurung.UseVisualStyleBackColor = true;
            btnBurung.Click += btnBurung_Click;
            // 
            // btnProduksi
            // 
            btnProduksi.Location = new Point(287, 110);
            btnProduksi.Margin = new Padding(2, 2, 2, 2);
            btnProduksi.Name = "btnProduksi";
            btnProduksi.Size = new Size(102, 37);
            btnProduksi.TabIndex = 3;
            btnProduksi.Text = "Data Produksi";
            btnProduksi.UseVisualStyleBackColor = true;
            btnProduksi.Click += btnProduksi_Click;
            // 
            // btnKandang
            // 
            btnKandang.Location = new Point(93, 178);
            btnKandang.Margin = new Padding(2, 2, 2, 2);
            btnKandang.Name = "btnKandang";
            btnKandang.Size = new Size(109, 37);
            btnKandang.TabIndex = 4;
            btnKandang.Text = "Data Kandang";
            btnKandang.UseVisualStyleBackColor = true;
            btnKandang.Click += btnKandang_Click;
            // 
            // btnPerawatan
            // 
            btnPerawatan.Location = new Point(287, 182);
            btnPerawatan.Margin = new Padding(2, 2, 2, 2);
            btnPerawatan.Name = "btnPerawatan";
            btnPerawatan.Size = new Size(102, 32);
            btnPerawatan.TabIndex = 5;
            btnPerawatan.Text = "Data Perawatan";
            btnPerawatan.UseVisualStyleBackColor = true;
            btnPerawatan.Click += btnPerawatan_Click;
            // 
            // btnRekomendasi
            // 
            btnRekomendasi.Location = new Point(196, 235);
            btnRekomendasi.Name = "btnRekomendasi";
            btnRekomendasi.Size = new Size(98, 39);
            btnRekomendasi.TabIndex = 6;
            btnRekomendasi.Text = "Rekomendasi";
            btnRekomendasi.UseVisualStyleBackColor = true;
            btnRekomendasi.Click += btnRekomendasi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 318);
            Controls.Add(btnRekomendasi);
            Controls.Add(btnPerawatan);
            Controls.Add(btnKandang);
            Controls.Add(btnProduksi);
            Controls.Add(btnBurung);
            Controls.Add(lblDeskripsi);
            Controls.Add(lblJudul);
            Margin = new Padding(2, 2, 2, 2);
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
        private Button btnPerawatan;
        private Button btnRekomendasi;
    }
}
