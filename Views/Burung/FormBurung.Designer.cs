
namespace SiMewah.Views.Burung
{
    partial class FormBurung
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblKode;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.Label lblJenisKelamin;
        private System.Windows.Forms.ComboBox cmbJenisKelamin;
        private System.Windows.Forms.Label lblTanggalLahir;
        private System.Windows.Forms.DateTimePicker dtpTanggalLahir;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblKandang;
        private System.Windows.Forms.ComboBox cmbKandang;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblJudul = new Label();
            lblKode = new Label();
            txtKode = new TextBox();
            lblJenisKelamin = new Label();
            cmbJenisKelamin = new ComboBox();
            lblTanggalLahir = new Label();
            dtpTanggalLahir = new DateTimePicker();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            lblKandang = new Label();
            cmbKandang = new ComboBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.BackColor = Color.Transparent;
            lblJudul.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.FromArgb(53, 92, 69);
            lblJudul.Location = new Point(35, 25);
            lblJudul.Margin = new Padding(4, 0, 4, 0);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(243, 48);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Form Burung";
            // 
            // lblKode
            // 
            lblKode.AutoSize = true;
            lblKode.BackColor = Color.Transparent;
            lblKode.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKode.ForeColor = Color.FromArgb(48, 56, 50);
            lblKode.Location = new Point(35, 100);
            lblKode.Margin = new Padding(4, 0, 4, 0);
            lblKode.Name = "lblKode";
            lblKode.Size = new Size(124, 25);
            lblKode.TabIndex = 1;
            lblKode.Text = "Kode Burung";
            // 
            // txtKode
            // 
            txtKode.BackColor = Color.White;
            txtKode.ForeColor = Color.FromArgb(48, 56, 50);
            txtKode.Location = new Point(35, 125);
            txtKode.Margin = new Padding(4, 5, 4, 5);
            txtKode.Name = "txtKode";
            txtKode.Size = new Size(480, 31);
            txtKode.TabIndex = 2;
            // 
            // lblJenisKelamin
            // 
            lblJenisKelamin.AutoSize = true;
            lblJenisKelamin.BackColor = Color.Transparent;
            lblJenisKelamin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJenisKelamin.ForeColor = Color.FromArgb(48, 56, 50);
            lblJenisKelamin.Location = new Point(35, 190);
            lblJenisKelamin.Margin = new Padding(4, 0, 4, 0);
            lblJenisKelamin.Name = "lblJenisKelamin";
            lblJenisKelamin.Size = new Size(128, 25);
            lblJenisKelamin.TabIndex = 3;
            lblJenisKelamin.Text = "Jenis Kelamin";
            // 
            // cmbJenisKelamin
            // 
            cmbJenisKelamin.BackColor = Color.White;
            cmbJenisKelamin.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJenisKelamin.ForeColor = Color.FromArgb(48, 56, 50);
            cmbJenisKelamin.FormattingEnabled = true;
            cmbJenisKelamin.Location = new Point(35, 215);
            cmbJenisKelamin.Margin = new Padding(4, 5, 4, 5);
            cmbJenisKelamin.Name = "cmbJenisKelamin";
            cmbJenisKelamin.Size = new Size(480, 33);
            cmbJenisKelamin.TabIndex = 4;
            // 
            // lblTanggalLahir
            // 
            lblTanggalLahir.AutoSize = true;
            lblTanggalLahir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTanggalLahir.ForeColor = Color.FromArgb(48, 56, 50);
            lblTanggalLahir.Location = new Point(35, 280);
            lblTanggalLahir.Margin = new Padding(4, 0, 4, 0);
            lblTanggalLahir.Name = "lblTanggalLahir";
            lblTanggalLahir.Size = new Size(126, 25);
            lblTanggalLahir.TabIndex = 5;
            lblTanggalLahir.Text = "Tanggal Lahir";
            // 
            // dtpTanggalLahir
            // 
            dtpTanggalLahir.Format = DateTimePickerFormat.Short;
            dtpTanggalLahir.Location = new Point(35, 305);
            dtpTanggalLahir.Margin = new Padding(4, 5, 4, 5);
            dtpTanggalLahir.Name = "dtpTanggalLahir";
            dtpTanggalLahir.Size = new Size(480, 31);
            dtpTanggalLahir.TabIndex = 6;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.FromArgb(48, 56, 50);
            lblStatus.Location = new Point(565, 100);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(65, 25);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = Color.White;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.ForeColor = Color.FromArgb(48, 56, 50);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(565, 125);
            cmbStatus.Margin = new Padding(4, 5, 4, 5);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(480, 33);
            cmbStatus.TabIndex = 8;
            // 
            // lblKandang
            // 
            lblKandang.AutoSize = true;
            lblKandang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKandang.ForeColor = Color.FromArgb(48, 56, 50);
            lblKandang.Location = new Point(569, 190);
            lblKandang.Margin = new Padding(4, 0, 4, 0);
            lblKandang.Name = "lblKandang";
            lblKandang.Size = new Size(88, 25);
            lblKandang.TabIndex = 9;
            lblKandang.Text = "Kandang";
            // 
            // cmbKandang
            // 
            cmbKandang.BackColor = Color.White;
            cmbKandang.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKandang.ForeColor = Color.FromArgb(48, 56, 50);
            cmbKandang.FormattingEnabled = true;
            cmbKandang.Location = new Point(565, 215);
            cmbKandang.Margin = new Padding(4, 5, 4, 5);
            cmbKandang.Name = "cmbKandang";
            cmbKandang.Size = new Size(480, 33);
            cmbKandang.TabIndex = 10;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(53, 92, 69);
            btnSimpan.Cursor = Cursors.Hand;
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(920, 590);
            btnSimpan.Margin = new Padding(4, 5, 4, 5);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(120, 38);
            btnSimpan.TabIndex = 11;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.White;
            btnBatal.Cursor = Cursors.Hand;
            btnBatal.FlatAppearance.BorderSize = 0;
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = Color.FromArgb(53, 92, 69);
            btnBatal.Location = new Point(790, 590);
            btnBatal.Margin = new Padding(4, 5, 4, 5);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(120, 38);
            btnBatal.TabIndex = 12;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            // 
            // FormBurung
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 245, 237);
            ClientSize = new Size(1078, 644);
            Controls.Add(lblJudul);
            Controls.Add(lblKode);
            Controls.Add(txtKode);
            Controls.Add(lblJenisKelamin);
            Controls.Add(cmbJenisKelamin);
            Controls.Add(lblTanggalLahir);
            Controls.Add(dtpTanggalLahir);
            Controls.Add(lblStatus);
            Controls.Add(cmbStatus);
            Controls.Add(lblKandang);
            Controls.Add(cmbKandang);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FormBurung";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form Burung";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
