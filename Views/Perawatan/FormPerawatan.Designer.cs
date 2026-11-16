namespace SiMewah.Views.Perawatan
{
    partial class FormPerawatan
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
            lblJudul = new Label();
            lblBurung = new Label();
            cmbBurung = new ComboBox();
            lblJenisPerawatan = new Label();
            cmbJenisPerawatan = new ComboBox();
            lblTanggalPerawatan = new Label();
            dtpTanggalPerawatan = new DateTimePicker();
            lblJumlahPerawatan = new Label();
            txtJumlahPerawatan = new TextBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.Location = new Point(131, 38);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(301, 38);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Form Data Perawatan";
            // 
            // lblBurung
            // 
            lblBurung.AutoSize = true;
            lblBurung.Location = new Point(140, 108);
            lblBurung.Name = "lblBurung";
            lblBurung.Size = new Size(106, 25);
            lblBurung.TabIndex = 1;
            lblBurung.Text = "Pilih Burung";
            // 
            // cmbBurung
            // 
            cmbBurung.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBurung.FormattingEnabled = true;
            cmbBurung.Location = new Point(140, 162);
            cmbBurung.Name = "cmbBurung";
            cmbBurung.Size = new Size(182, 33);
            cmbBurung.TabIndex = 2;
            // 
            // lblJenisPerawatan
            // 
            lblJenisPerawatan.AutoSize = true;
            lblJenisPerawatan.Location = new Point(431, 108);
            lblJenisPerawatan.Name = "lblJenisPerawatan";
            lblJenisPerawatan.Size = new Size(134, 25);
            lblJenisPerawatan.TabIndex = 3;
            lblJenisPerawatan.Text = "Jenis Perawatan";
            // 
            // cmbJenisPerawatan
            // 
            cmbJenisPerawatan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJenisPerawatan.FormattingEnabled = true;
            cmbJenisPerawatan.Location = new Point(431, 162);
            cmbJenisPerawatan.Name = "cmbJenisPerawatan";
            cmbJenisPerawatan.Size = new Size(182, 33);
            cmbJenisPerawatan.TabIndex = 4;
            // 
            // lblTanggalPerawatan
            // 
            lblTanggalPerawatan.AutoSize = true;
            lblTanggalPerawatan.Location = new Point(140, 249);
            lblTanggalPerawatan.Name = "lblTanggalPerawatan";
            lblTanggalPerawatan.Size = new Size(158, 25);
            lblTanggalPerawatan.TabIndex = 5;
            lblTanggalPerawatan.Text = "Tanggal Perawatan";
            // 
            // dtpTanggalPerawatan
            // 
            dtpTanggalPerawatan.Location = new Point(326, 249);
            dtpTanggalPerawatan.Name = "dtpTanggalPerawatan";
            dtpTanggalPerawatan.Size = new Size(300, 31);
            dtpTanggalPerawatan.TabIndex = 6;
            // 
            // lblJumlahPerawatan
            // 
            lblJumlahPerawatan.AutoSize = true;
            lblJumlahPerawatan.Location = new Point(140, 300);
            lblJumlahPerawatan.Name = "lblJumlahPerawatan";
            lblJumlahPerawatan.Size = new Size(152, 25);
            lblJumlahPerawatan.TabIndex = 7;
            lblJumlahPerawatan.Text = "Jumlah Perawatan";
            // 
            // txtJumlahPerawatan
            // 
            txtJumlahPerawatan.Location = new Point(326, 300);
            txtJumlahPerawatan.Name = "txtJumlahPerawatan";
            txtJumlahPerawatan.Size = new Size(300, 31);
            txtJumlahPerawatan.TabIndex = 8;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(514, 375);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(112, 34);
            btnSimpan.TabIndex = 9;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(377, 375);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(112, 34);
            btnBatal.TabIndex = 10;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            // 
            // FormPerawatan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(txtJumlahPerawatan);
            Controls.Add(lblJumlahPerawatan);
            Controls.Add(dtpTanggalPerawatan);
            Controls.Add(lblTanggalPerawatan);
            Controls.Add(cmbJenisPerawatan);
            Controls.Add(lblJenisPerawatan);
            Controls.Add(cmbBurung);
            Controls.Add(lblBurung);
            Controls.Add(lblJudul);
            Name = "FormPerawatan";
            Text = "FormPerawatan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJudul;
        private Label lblBurung;
        private ComboBox cmbBurung;
        private Label lblJenisPerawatan;
        private ComboBox cmbJenisPerawatan;
        private Label lblTanggalPerawatan;
        private DateTimePicker dtpTanggalPerawatan;
        private Label lblJumlahPerawatan;
        private TextBox txtJumlahPerawatan;
        private Button btnSimpan;
        private Button btnBatal;
    }
}