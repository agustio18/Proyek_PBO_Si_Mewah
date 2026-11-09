
namespace SiMewah.Views.Produksi.Telur
{
    partial class FormTelur
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblPerkawinan;
        private System.Windows.Forms.ComboBox cmbPerkawinan;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.NumericUpDown numJumlah;
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
            this.lblPerkawinan = new System.Windows.Forms.Label();
            this.cmbPerkawinan = new System.Windows.Forms.ComboBox();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.numJumlah = new System.Windows.Forms.NumericUpDown();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.numJumlah)).BeginInit();
            this.SuspendLayout();

            // lblJudul
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font(
                "Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblJudul.Location = new System.Drawing.Point(25, 20);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(93, 21);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Form Telur";

            // lblPerkawinan
            this.lblPerkawinan.AutoSize = true;
            this.lblPerkawinan.Location = new System.Drawing.Point(25, 70);
            this.lblPerkawinan.Name = "lblPerkawinan";
            this.lblPerkawinan.Size = new System.Drawing.Size(72, 15);
            this.lblPerkawinan.TabIndex = 1;
            this.lblPerkawinan.Text = "Perkawinan";

            // cmbPerkawinan
            this.cmbPerkawinan.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerkawinan.FormattingEnabled = true;
            this.cmbPerkawinan.Location = new System.Drawing.Point(25, 90);
            this.cmbPerkawinan.Name = "cmbPerkawinan";
            this.cmbPerkawinan.Size = new System.Drawing.Size(380, 23);
            this.cmbPerkawinan.TabIndex = 2;

            // lblTanggal
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Location = new System.Drawing.Point(25, 135);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(73, 15);
            this.lblTanggal.TabIndex = 3;
            this.lblTanggal.Text = "Tanggal Telur";

            // dtpTanggal
            this.dtpTanggal.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTanggal.Location = new System.Drawing.Point(25, 155);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(380, 23);
            this.dtpTanggal.TabIndex = 4;

            // lblJumlah
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Location = new System.Drawing.Point(25, 200);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(75, 15);
            this.lblJumlah.TabIndex = 5;
            this.lblJumlah.Text = "Jumlah Telur";

            // numJumlah
            this.numJumlah.Location = new System.Drawing.Point(25, 220);
            this.numJumlah.Minimum = 1;
            this.numJumlah.Maximum = 100;
            this.numJumlah.Name = "numJumlah";
            this.numJumlah.Size = new System.Drawing.Size(380, 23);
            this.numJumlah.TabIndex = 6;

            // btnSimpan
            this.btnSimpan.Location = new System.Drawing.Point(315, 290);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(90, 30);
            this.btnSimpan.TabIndex = 7;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;

            // btnBatal
            this.btnBatal.Location = new System.Drawing.Point(215, 290);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(90, 30);
            this.btnBatal.TabIndex = 8;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;

            // FormTelur
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 360);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.lblPerkawinan);
            this.Controls.Add(this.cmbPerkawinan);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.lblJumlah);
            this.Controls.Add(this.numJumlah);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.Name = "FormTelur";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form Telur";

            ((System.ComponentModel.ISupportInitialize)(this.numJumlah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
