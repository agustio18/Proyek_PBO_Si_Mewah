
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
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblKode = new System.Windows.Forms.Label();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.lblJenisKelamin = new System.Windows.Forms.Label();
            this.cmbJenisKelamin = new System.Windows.Forms.ComboBox();
            this.lblTanggalLahir = new System.Windows.Forms.Label();
            this.dtpTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblKandang = new System.Windows.Forms.Label();
            this.cmbKandang = new System.Windows.Forms.ComboBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // lblJudul
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font(
                "Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblJudul.Location = new System.Drawing.Point(25, 20);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(108, 21);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Form Burung";

            // lblKode
            this.lblKode.AutoSize = true;
            this.lblKode.Location = new System.Drawing.Point(25, 70);
            this.lblKode.Name = "lblKode";
            this.lblKode.Size = new System.Drawing.Size(70, 15);
            this.lblKode.TabIndex = 1;
            this.lblKode.Text = "Kode Burung";

            // txtKode
            this.txtKode.Location = new System.Drawing.Point(25, 90);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(380, 23);
            this.txtKode.TabIndex = 2;

            // lblJenisKelamin
            this.lblJenisKelamin.AutoSize = true;
            this.lblJenisKelamin.Location = new System.Drawing.Point(25, 135);
            this.lblJenisKelamin.Name = "lblJenisKelamin";
            this.lblJenisKelamin.Size = new System.Drawing.Size(80, 15);
            this.lblJenisKelamin.TabIndex = 3;
            this.lblJenisKelamin.Text = "Jenis Kelamin";

            // cmbJenisKelamin
            this.cmbJenisKelamin.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJenisKelamin.FormattingEnabled = true;
            this.cmbJenisKelamin.Location = new System.Drawing.Point(25, 155);
            this.cmbJenisKelamin.Name = "cmbJenisKelamin";
            this.cmbJenisKelamin.Size = new System.Drawing.Size(380, 23);
            this.cmbJenisKelamin.TabIndex = 4;

            // lblTanggalLahir
            this.lblTanggalLahir.AutoSize = true;
            this.lblTanggalLahir.Location = new System.Drawing.Point(25, 200);
            this.lblTanggalLahir.Name = "lblTanggalLahir";
            this.lblTanggalLahir.Size = new System.Drawing.Size(78, 15);
            this.lblTanggalLahir.TabIndex = 5;
            this.lblTanggalLahir.Text = "Tanggal Lahir";

            // dtpTanggalLahir
            this.dtpTanggalLahir.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTanggalLahir.Location = new System.Drawing.Point(25, 220);
            this.dtpTanggalLahir.Name = "dtpTanggalLahir";
            this.dtpTanggalLahir.Size = new System.Drawing.Size(380, 23);
            this.dtpTanggalLahir.TabIndex = 6;

            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(25, 265);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 15);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status";

            // cmbStatus
            this.cmbStatus.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(25, 285);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(380, 23);
            this.cmbStatus.TabIndex = 8;

            // lblKandang
            this.lblKandang.AutoSize = true;
            this.lblKandang.Location = new System.Drawing.Point(25, 330);
            this.lblKandang.Name = "lblKandang";
            this.lblKandang.Size = new System.Drawing.Size(55, 15);
            this.lblKandang.TabIndex = 9;
            this.lblKandang.Text = "Kandang";

            // cmbKandang
            this.cmbKandang.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKandang.FormattingEnabled = true;
            this.cmbKandang.Location = new System.Drawing.Point(25, 350);
            this.cmbKandang.Name = "cmbKandang";
            this.cmbKandang.Size = new System.Drawing.Size(380, 23);
            this.cmbKandang.TabIndex = 10;

            // btnSimpan
            this.btnSimpan.Location = new System.Drawing.Point(315, 410);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(90, 30);
            this.btnSimpan.TabIndex = 11;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;

            // btnBatal
            this.btnBatal.Location = new System.Drawing.Point(215, 410);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(90, 30);
            this.btnBatal.TabIndex = 12;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;

            // FormBurung
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 480);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.lblKode);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.lblJenisKelamin);
            this.Controls.Add(this.cmbJenisKelamin);
            this.Controls.Add(this.lblTanggalLahir);
            this.Controls.Add(this.dtpTanggalLahir);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblKandang);
            this.Controls.Add(this.cmbKandang);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.Name = "FormBurung";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form Burung";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
