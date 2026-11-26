
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblJudul = new Label();
            lblDeskripsi = new Label();
            cmbBurung = new ComboBox();
            btnAnalisis = new Button();
            lblhasil = new Label();
            lblketerangan = new Label();
            dgvRiwayat = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).BeginInit();
            SuspendLayout();

            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblJudul.ForeColor = Color.FromArgb(53, 92, 69);
            lblJudul.Location = new Point(24, 24);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(184, 41);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Rekomendasi";

            // 
            // lblDeskripsi
            // 
            lblDeskripsi.AutoSize = true;
            lblDeskripsi.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblDeskripsi.ForeColor = Color.FromArgb(120, 128, 120);
            lblDeskripsi.Location = new Point(24, 62);
            lblDeskripsi.Name = "lblDeskripsi";
            lblDeskripsi.Size = new Size(316, 23);
            lblDeskripsi.TabIndex = 1;
            lblDeskripsi.Text = "Analisis kelayakan burung betina";

            // 
            // cmbBurung
            // 
            cmbBurung.BackColor = Color.White;
            cmbBurung.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            cmbBurung.ForeColor = Color.FromArgb(48, 56, 50);
            cmbBurung.FormattingEnabled = true;
            cmbBurung.Location = new Point(24, 110);
            cmbBurung.Name = "cmbBurung";
            cmbBurung.Size = new Size(300, 34);
            cmbBurung.TabIndex = 2;

            // 
            // btnAnalisis
            // 
            btnAnalisis.BackColor = Color.FromArgb(53, 92, 69);
            btnAnalisis.Cursor = Cursors.Hand;
            btnAnalisis.FlatAppearance.BorderSize = 0;
            btnAnalisis.FlatStyle = FlatStyle.Flat;
            btnAnalisis.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAnalisis.ForeColor = Color.White;
            btnAnalisis.Location = new Point(336, 108);
            btnAnalisis.Name = "btnAnalisis";
            btnAnalisis.Size = new Size(120, 38);
            btnAnalisis.TabIndex = 3;
            btnAnalisis.Text = "Analisis";
            btnAnalisis.UseVisualStyleBackColor = false;
            btnAnalisis.Click += btnAnalisis_Click;

            // 
            // lblhasil
            // 
            lblhasil.AutoSize = true;
            lblhasil.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblhasil.ForeColor = Color.FromArgb(53, 92, 69);
            lblhasil.Location = new Point(24, 180);
            lblhasil.Name = "lblhasil";
            lblhasil.Size = new Size(68, 28);
            lblhasil.TabIndex = 4;
            lblhasil.Text = "Hasil";

            // 
            // lblketerangan
            // 
            lblketerangan.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblketerangan.ForeColor = Color.FromArgb(48, 56, 50);
            lblketerangan.Location = new Point(24, 224);
            lblketerangan.Name = "lblketerangan";
            lblketerangan.Size = new Size(1050, 84);
            lblketerangan.TabIndex = 5;
            lblketerangan.Text = "Keterangan";

            // 
            // dgvRiwayat
            // 
            dgvRiwayat.AllowUserToAddRows = false;
            dgvRiwayat.AllowUserToDeleteRows = false;
            dgvRiwayat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRiwayat.BackgroundColor = Color.White;
            dgvRiwayat.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(53, 92, 69);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(53, 92, 69);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRiwayat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRiwayat.ColumnHeadersHeight = 40;
            dgvRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(48, 56, 50);
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(143, 175, 145);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(48, 56, 50);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRiwayat.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRiwayat.EnableHeadersVisualStyles = false;
            dgvRiwayat.GridColor = Color.FromArgb(227, 231, 225);
            dgvRiwayat.Location = new Point(24, 330);
            dgvRiwayat.MultiSelect = false;
            dgvRiwayat.Name = "dgvRiwayat";
            dgvRiwayat.ReadOnly = true;
            dgvRiwayat.RowHeadersVisible = false;
            dgvRiwayat.RowTemplate.Height = 36;
            dgvRiwayat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRiwayat.Size = new Size(1052, 346);
            dgvRiwayat.TabIndex = 6;

            // 
            // UcRekomendasi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 245, 237);
            ClientSize = new Size(1100, 700);
            Controls.Add(dgvRiwayat);
            Controls.Add(lblketerangan);
            Controls.Add(lblhasil);
            Controls.Add(btnAnalisis);
            Controls.Add(cmbBurung);
            Controls.Add(lblDeskripsi);
            Controls.Add(lblJudul);
            Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UcRekomendasi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rekomendasi";
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJudul;
        private Label lblDeskripsi;
        private ComboBox cmbBurung;
        private Button btnAnalisis;
        private Label lblhasil;
        private Label lblketerangan;
        private DataGridView dgvRiwayat;
    }
}
