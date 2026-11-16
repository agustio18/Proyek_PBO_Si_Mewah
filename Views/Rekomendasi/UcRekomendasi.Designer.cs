namespace SiMewah.Views.Rekomendasi
{
    partial class UcRekomendasi
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
            cmbBurung = new ComboBox();
            btnAnalisis = new Button();
            lblhasil = new Label();
            lblketerangan = new Label();
            dgvRiwayat = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).BeginInit();
            SuspendLayout();
            // 
            // cmbBurung
            // 
            cmbBurung.FormattingEnabled = true;
            cmbBurung.Location = new Point(148, 36);
            cmbBurung.Name = "cmbBurung";
            cmbBurung.Size = new Size(121, 23);
            cmbBurung.TabIndex = 0;
            // 
            // btnAnalisis
            // 
            btnAnalisis.Location = new Point(309, 34);
            btnAnalisis.Name = "btnAnalisis";
            btnAnalisis.Size = new Size(75, 23);
            btnAnalisis.TabIndex = 1;
            btnAnalisis.Text = "Analisis";
            btnAnalisis.UseVisualStyleBackColor = true;
            btnAnalisis.Click += btnAnalisis_Click;
            // 
            // lblhasil
            // 
            lblhasil.AutoSize = true;
            lblhasil.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblhasil.Location = new Point(58, 27);
            lblhasil.Name = "lblhasil";
            lblhasil.Size = new Size(58, 30);
            lblhasil.TabIndex = 2;
            lblhasil.Text = "Hasil";
            // 
            // lblketerangan
            // 
            lblketerangan.AutoSize = true;
            lblketerangan.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblketerangan.Location = new Point(56, 125);
            lblketerangan.Name = "lblketerangan";
            lblketerangan.Size = new Size(107, 30);
            lblketerangan.TabIndex = 3;
            lblketerangan.Text = "Keteragan";
            // 
            // dgvRiwayat
            // 
            dgvRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRiwayat.Location = new Point(383, 127);
            dgvRiwayat.Name = "dgvRiwayat";
            dgvRiwayat.Size = new Size(240, 150);
            dgvRiwayat.TabIndex = 4;
            // 
            // UcRekomendasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvRiwayat);
            Controls.Add(lblketerangan);
            Controls.Add(lblhasil);
            Controls.Add(btnAnalisis);
            Controls.Add(cmbBurung);
            Name = "UcRekomendasi";
            Text = "UcRekomendasi";
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBurung;
        private Button btnAnalisis;
        private Label lblhasil;
        private Label lblketerangan;
        private DataGridView dgvRiwayat;
    }
}