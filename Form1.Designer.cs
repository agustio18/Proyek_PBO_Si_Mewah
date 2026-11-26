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
            lblJudul.BackColor = Color.Transparent;
            lblJudul.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.FromArgb(53, 92, 69);
            lblJudul.Location = new Point(40, 35);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(273, 65);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "SI MEWAH";
            // 
            // lblDeskripsi
            // 
            lblDeskripsi.AutoSize = true;
            lblDeskripsi.BackColor = Color.Transparent;
            lblDeskripsi.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDeskripsi.ForeColor = Color.FromArgb(120, 128, 120);
            lblDeskripsi.Location = new Point(50, 90);
            lblDeskripsi.Name = "lblDeskripsi";
            lblDeskripsi.Size = new Size(549, 30);
            lblDeskripsi.TabIndex = 1;
            lblDeskripsi.Text = "Sistem Informasi Manajemen Peternakan Burung Kenari";
            // 
            // btnBurung
            // 
            btnBurung.BackColor = Color.FromArgb(53, 92, 69);
            btnBurung.Cursor = Cursors.Hand;
            btnBurung.FlatStyle = FlatStyle.Flat;
            btnBurung.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBurung.ForeColor = Color.White;
            btnBurung.Location = new Point(330, 200);
            btnBurung.Name = "btnBurung";
            btnBurung.Size = new Size(200, 55);
            btnBurung.TabIndex = 2;
            btnBurung.Text = "Data Burung";
            btnBurung.UseVisualStyleBackColor = false;
            btnBurung.Click += btnBurung_Click;
            // 
            // btnProduksi
            // 
            btnProduksi.BackColor = Color.FromArgb(53, 92, 69);
            btnProduksi.Cursor = Cursors.Hand;
            btnProduksi.FlatStyle = FlatStyle.Flat;
            btnProduksi.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProduksi.ForeColor = Color.White;
            btnProduksi.Location = new Point(570, 200);
            btnProduksi.Name = "btnProduksi";
            btnProduksi.Size = new Size(200, 55);
            btnProduksi.TabIndex = 3;
            btnProduksi.Text = "Data Produksi";
            btnProduksi.UseVisualStyleBackColor = false;
            btnProduksi.Click += btnProduksi_Click;
            // 
            // btnKandang
            // 
            btnKandang.BackColor = Color.FromArgb(53, 92, 69);
            btnKandang.Cursor = Cursors.Hand;
            btnKandang.FlatStyle = FlatStyle.Flat;
            btnKandang.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKandang.ForeColor = Color.White;
            btnKandang.Location = new Point(330, 280);
            btnKandang.Name = "btnKandang";
            btnKandang.Size = new Size(200, 55);
            btnKandang.TabIndex = 4;
            btnKandang.Text = "Data Kandang";
            btnKandang.UseVisualStyleBackColor = false;
            btnKandang.Click += btnKandang_Click;
            // 
            // btnPerawatan
            // 
            btnPerawatan.BackColor = Color.FromArgb(53, 92, 69);
            btnPerawatan.Cursor = Cursors.Hand;
            btnPerawatan.FlatStyle = FlatStyle.Flat;
            btnPerawatan.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPerawatan.ForeColor = Color.White;
            btnPerawatan.Location = new Point(570, 280);
            btnPerawatan.Name = "btnPerawatan";
            btnPerawatan.Size = new Size(200, 55);
            btnPerawatan.TabIndex = 5;
            btnPerawatan.Text = "Data Perawatan";
            btnPerawatan.UseVisualStyleBackColor = false;
            btnPerawatan.Click += btnPerawatan_Click;
            // 
            // btnRekomendasi
            // 
            btnRekomendasi.BackColor = Color.FromArgb(143, 175, 145);
            btnRekomendasi.Cursor = Cursors.Hand;
            btnRekomendasi.FlatStyle = FlatStyle.Flat;
            btnRekomendasi.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRekomendasi.ForeColor = Color.White;
            btnRekomendasi.Location = new Point(450, 360);
            btnRekomendasi.Margin = new Padding(4, 5, 4, 5);
            btnRekomendasi.Name = "btnRekomendasi";
            btnRekomendasi.Size = new Size(200, 55);
            btnRekomendasi.TabIndex = 6;
            btnRekomendasi.Text = "Rekomendasi";
            btnRekomendasi.UseVisualStyleBackColor = false;
            btnRekomendasi.Click += btnRekomendasi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 245, 237);
            ClientSize = new Size(1078, 644);
            Controls.Add(btnRekomendasi);
            Controls.Add(btnPerawatan);
            Controls.Add(btnKandang);
            Controls.Add(btnProduksi);
            Controls.Add(btnBurung);
            Controls.Add(lblDeskripsi);
            Controls.Add(lblJudul);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
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
