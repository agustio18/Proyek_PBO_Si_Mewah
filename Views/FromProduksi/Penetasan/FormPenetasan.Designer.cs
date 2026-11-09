
namespace SiMewah.Views.Produksi.Penetasan
{
    partial class FormPenetasan
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblTelur;
        private System.Windows.Forms.ComboBox cmbTelur;
        private System.Windows.Forms.Label lblTotalTelur;
        private System.Windows.Forms.TextBox txtTotalTelur;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.Label lblMenetas;
        private System.Windows.Forms.NumericUpDown numMenetas;
        private System.Windows.Forms.Label lblGagal;
        private System.Windows.Forms.NumericUpDown numGagal;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
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
            this.lblTelur = new System.Windows.Forms.Label();
            this.cmbTelur = new System.Windows.Forms.ComboBox();
            this.lblTotalTelur = new System.Windows.Forms.Label();
            this.txtTotalTelur = new System.Windows.Forms.TextBox();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.lblMenetas = new System.Windows.Forms.Label();
            this.numMenetas = new System.Windows.Forms.NumericUpDown();
            this.lblGagal = new System.Windows.Forms.Label();
            this.numGagal = new System.Windows.Forms.NumericUpDown();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.numMenetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGagal)).BeginInit();
            this.SuspendLayout();

            // lblJudul
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font(
                "Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblJudul.Location = new System.Drawing.Point(25, 20);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(140, 21);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Form Penetasan";

            // lblTelur
            this.lblTelur.AutoSize = true;
            this.lblTelur.Location = new System.Drawing.Point(25, 65);
            this.lblTelur.Name = "lblTelur";
            this.lblTelur.Size = new System.Drawing.Size(60, 15);
            this.lblTelur.TabIndex = 1;
            this.lblTelur.Text = "Kelompok Telur";

            // cmbTelur
            this.cmbTelur.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTelur.FormattingEnabled = true;
            this.cmbTelur.Location = new System.Drawing.Point(25, 85);
            this.cmbTelur.Name = "cmbTelur";
            this.cmbTelur.Size = new System.Drawing.Size(380, 23);
            this.cmbTelur.TabIndex = 2;

            // lblTotalTelur
            this.lblTotalTelur.AutoSize = true;
            this.lblTotalTelur.Location = new System.Drawing.Point(25, 125);
            this.lblTotalTelur.Name = "lblTotalTelur";
            this.lblTotalTelur.Size = new System.Drawing.Size(75, 15);
            this.lblTotalTelur.TabIndex = 3;
            this.lblTotalTelur.Text = "Jumlah Telur";

            // txtTotalTelur
            this.txtTotalTelur.Location = new System.Drawing.Point(25, 145);
            this.txtTotalTelur.Name = "txtTotalTelur";
            this.txtTotalTelur.ReadOnly = true;
            this.txtTotalTelur.Size = new System.Drawing.Size(380, 23);
            this.txtTotalTelur.TabIndex = 4;

            // lblTanggal
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Location = new System.Drawing.Point(25, 185);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(110, 15);
            this.lblTanggal.TabIndex = 5;
            this.lblTanggal.Text = "Tanggal Pencatatan";

            // dtpTanggal
            this.dtpTanggal.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTanggal.Location = new System.Drawing.Point(25, 205);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(380, 23);
            this.dtpTanggal.TabIndex = 6;

            // lblMenetas
            this.lblMenetas.AutoSize = true;
            this.lblMenetas.Location = new System.Drawing.Point(25, 245);
            this.lblMenetas.Name = "lblMenetas";
            this.lblMenetas.Size = new System.Drawing.Size(100, 15);
            this.lblMenetas.TabIndex = 7;
            this.lblMenetas.Text = "Jumlah Menetas";

            // numMenetas
            this.numMenetas.Location = new System.Drawing.Point(25, 265);
            this.numMenetas.Minimum = 0;
            this.numMenetas.Maximum = 100;
            this.numMenetas.Name = "numMenetas";
            this.numMenetas.Size = new System.Drawing.Size(380, 23);
            this.numMenetas.TabIndex = 8;

            // lblGagal
            this.lblGagal.AutoSize = true;
            this.lblGagal.Location = new System.Drawing.Point(25, 305);
            this.lblGagal.Name = "lblGagal";
            this.lblGagal.Size = new System.Drawing.Size(85, 15);
            this.lblGagal.TabIndex = 9;
            this.lblGagal.Text = "Jumlah Gagal";

            // numGagal
            this.numGagal.Location = new System.Drawing.Point(25, 325);
            this.numGagal.Minimum = 0;
            this.numGagal.Maximum = 100;
            this.numGagal.Name = "numGagal";
            this.numGagal.Size = new System.Drawing.Size(380, 23);
            this.numGagal.TabIndex = 10;

            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(25, 365);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 15);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status";

            // txtStatus
            this.txtStatus.Location = new System.Drawing.Point(25, 385);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(380, 23);
            this.txtStatus.TabIndex = 12;

            // btnSimpan
            this.btnSimpan.Location = new System.Drawing.Point(315, 435);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(90, 30);
            this.btnSimpan.TabIndex = 13;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;

            // btnBatal
            this.btnBatal.Location = new System.Drawing.Point(215, 435);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(90, 30);
            this.btnBatal.TabIndex = 14;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;

            // FormPenetasan
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 490);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.lblTelur);
            this.Controls.Add(this.cmbTelur);
            this.Controls.Add(this.lblTotalTelur);
            this.Controls.Add(this.txtTotalTelur);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.lblMenetas);
            this.Controls.Add(this.numMenetas);
            this.Controls.Add(this.lblGagal);
            this.Controls.Add(this.numGagal);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.Name = "FormPenetasan";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form Penetasan";

            ((System.ComponentModel.ISupportInitialize)(this.numMenetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGagal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
