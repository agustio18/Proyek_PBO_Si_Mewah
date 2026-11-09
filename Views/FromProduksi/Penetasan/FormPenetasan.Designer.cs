
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
            lblJudul = new Label();
            lblTelur = new Label();
            cmbTelur = new ComboBox();
            lblTotalTelur = new Label();
            txtTotalTelur = new TextBox();
            lblTanggal = new Label();
            dtpTanggal = new DateTimePicker();
            lblMenetas = new Label();
            numMenetas = new NumericUpDown();
            lblGagal = new Label();
            numGagal = new NumericUpDown();
            lblStatus = new Label();
            txtStatus = new TextBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            ((System.ComponentModel.ISupportInitialize)numMenetas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGagal).BeginInit();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblJudul.Location = new Point(29, 27);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(162, 28);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Form Penetasan";
            // 
            // lblTelur
            // 
            lblTelur.AutoSize = true;
            lblTelur.Location = new Point(29, 87);
            lblTelur.Name = "lblTelur";
            lblTelur.Size = new Size(113, 20);
            lblTelur.TabIndex = 1;
            lblTelur.Text = "Kelompok Telur";
            // 
            // cmbTelur
            // 
            cmbTelur.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTelur.FormattingEnabled = true;
            cmbTelur.Location = new Point(29, 113);
            cmbTelur.Margin = new Padding(3, 4, 3, 4);
            cmbTelur.Name = "cmbTelur";
            cmbTelur.Size = new Size(434, 28);
            cmbTelur.TabIndex = 2;
            // 
            // lblTotalTelur
            // 
            lblTotalTelur.AutoSize = true;
            lblTotalTelur.Location = new Point(29, 167);
            lblTotalTelur.Name = "lblTotalTelur";
            lblTotalTelur.Size = new Size(91, 20);
            lblTotalTelur.TabIndex = 3;
            lblTotalTelur.Text = "Jumlah Telur";
            // 
            // txtTotalTelur
            // 
            txtTotalTelur.Location = new Point(29, 193);
            txtTotalTelur.Margin = new Padding(3, 4, 3, 4);
            txtTotalTelur.Name = "txtTotalTelur";
            txtTotalTelur.ReadOnly = true;
            txtTotalTelur.Size = new Size(434, 27);
            txtTotalTelur.TabIndex = 4;
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.Location = new Point(29, 247);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(137, 20);
            lblTanggal.TabIndex = 5;
            lblTanggal.Text = "Tanggal Pencatatan";
            // 
            // dtpTanggal
            // 
            dtpTanggal.Format = DateTimePickerFormat.Short;
            dtpTanggal.Location = new Point(29, 273);
            dtpTanggal.Margin = new Padding(3, 4, 3, 4);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(434, 27);
            dtpTanggal.TabIndex = 6;
            // 
            // lblMenetas
            // 
            lblMenetas.AutoSize = true;
            lblMenetas.Location = new Point(29, 327);
            lblMenetas.Name = "lblMenetas";
            lblMenetas.Size = new Size(115, 20);
            lblMenetas.TabIndex = 7;
            lblMenetas.Text = "Jumlah Menetas";
            // 
            // numMenetas
            // 
            numMenetas.Location = new Point(29, 353);
            numMenetas.Margin = new Padding(3, 4, 3, 4);
            numMenetas.Name = "numMenetas";
            numMenetas.Size = new Size(434, 27);
            numMenetas.TabIndex = 8;
            // 
            // lblGagal
            // 
            lblGagal.AutoSize = true;
            lblGagal.Location = new Point(29, 407);
            lblGagal.Name = "lblGagal";
            lblGagal.Size = new Size(98, 20);
            lblGagal.TabIndex = 9;
            lblGagal.Text = "Jumlah Gagal";
            // 
            // numGagal
            // 
            numGagal.Location = new Point(29, 433);
            numGagal.Margin = new Padding(3, 4, 3, 4);
            numGagal.Name = "numGagal";
            numGagal.Size = new Size(434, 27);
            numGagal.TabIndex = 10;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(29, 487);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 20);
            lblStatus.TabIndex = 11;
            lblStatus.Text = "Status";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(29, 513);
            txtStatus.Margin = new Padding(3, 4, 3, 4);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(434, 27);
            txtStatus.TabIndex = 12;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(360, 580);
            btnSimpan.Margin = new Padding(3, 4, 3, 4);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(103, 40);
            btnSimpan.TabIndex = 13;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(246, 580);
            btnBatal.Margin = new Padding(3, 4, 3, 4);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(103, 40);
            btnBatal.TabIndex = 14;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            // 
            // FormPenetasan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 653);
            Controls.Add(lblJudul);
            Controls.Add(lblTelur);
            Controls.Add(cmbTelur);
            Controls.Add(lblTotalTelur);
            Controls.Add(txtTotalTelur);
            Controls.Add(lblTanggal);
            Controls.Add(dtpTanggal);
            Controls.Add(lblMenetas);
            Controls.Add(numMenetas);
            Controls.Add(lblGagal);
            Controls.Add(numGagal);
            Controls.Add(lblStatus);
            Controls.Add(txtStatus);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPenetasan";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form Penetasan";
            ((System.ComponentModel.ISupportInitialize)numMenetas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGagal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
