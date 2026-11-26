
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
            btnSimpan = new Button();
            btnBatal = new Button();
            ((System.ComponentModel.ISupportInitialize)numMenetas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGagal).BeginInit();
            SuspendLayout();

            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblJudul.ForeColor = Color.FromArgb(53, 92, 69);
            lblJudul.Location = new Point(24, 24);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(236, 41);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Form Penetasan";

            // 
            // lblTelur
            // 
            lblTelur.AutoSize = true;
            lblTelur.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTelur.ForeColor = Color.FromArgb(48, 56, 50);
            lblTelur.Location = new Point(24, 90);
            lblTelur.Name = "lblTelur";
            lblTelur.Size = new Size(114, 21);
            lblTelur.TabIndex = 1;
            lblTelur.Text = "Kelompok Telur";

            // 
            // cmbTelur
            // 
            cmbTelur.BackColor = Color.White;
            cmbTelur.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTelur.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            cmbTelur.ForeColor = Color.FromArgb(48, 56, 50);
            cmbTelur.FormattingEnabled = true;
            cmbTelur.Location = new Point(24, 118);
            cmbTelur.Name = "cmbTelur";
            cmbTelur.Size = new Size(480, 34);
            cmbTelur.TabIndex = 2;

            // 
            // lblTotalTelur
            // 
            lblTotalTelur.AutoSize = true;
            lblTotalTelur.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTotalTelur.ForeColor = Color.FromArgb(48, 56, 50);
            lblTotalTelur.Location = new Point(24, 180);
            lblTotalTelur.Name = "lblTotalTelur";
            lblTotalTelur.Size = new Size(94, 21);
            lblTotalTelur.TabIndex = 3;
            lblTotalTelur.Text = "Jumlah Telur";

            // 
            // txtTotalTelur
            // 
            txtTotalTelur.BackColor = Color.White;
            txtTotalTelur.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            txtTotalTelur.ForeColor = Color.FromArgb(48, 56, 50);
            txtTotalTelur.Location = new Point(24, 208);
            txtTotalTelur.Name = "txtTotalTelur";
            txtTotalTelur.ReadOnly = true;
            txtTotalTelur.Size = new Size(480, 34);
            txtTotalTelur.TabIndex = 4;

            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTanggal.ForeColor = Color.FromArgb(48, 56, 50);
            lblTanggal.Location = new Point(24, 270);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(139, 21);
            lblTanggal.TabIndex = 5;
            lblTanggal.Text = "Tanggal Pencatatan";

            // 
            // dtpTanggal
            // 
            dtpTanggal.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            dtpTanggal.Format = DateTimePickerFormat.Short;
            dtpTanggal.Location = new Point(24, 298);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(480, 34);
            dtpTanggal.TabIndex = 6;

            // 
            // lblMenetas
            // 
            lblMenetas.AutoSize = true;
            lblMenetas.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblMenetas.ForeColor = Color.FromArgb(48, 56, 50);
            lblMenetas.Location = new Point(24, 360);
            lblMenetas.Name = "lblMenetas";
            lblMenetas.Size = new Size(117, 21);
            lblMenetas.TabIndex = 7;
            lblMenetas.Text = "Jumlah Menetas";

            // 
            // numMenetas
            // 
            numMenetas.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            numMenetas.Location = new Point(24, 388);
            numMenetas.Name = "numMenetas";
            numMenetas.Size = new Size(480, 34);
            numMenetas.TabIndex = 8;

            // 
            // lblGagal
            // 
            lblGagal.AutoSize = true;
            lblGagal.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblGagal.ForeColor = Color.FromArgb(48, 56, 50);
            lblGagal.Location = new Point(24, 450);
            lblGagal.Name = "lblGagal";
            lblGagal.Size = new Size(100, 21);
            lblGagal.TabIndex = 9;
            lblGagal.Text = "Jumlah Gagal";

            // 
            // numGagal
            // 
            numGagal.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            numGagal.Location = new Point(24, 478);
            numGagal.Name = "numGagal";
            numGagal.Size = new Size(480, 34);
            numGagal.TabIndex = 10;

            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(53, 92, 69);
            btnSimpan.Cursor = Cursors.Hand;
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(956, 638);
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
            btnBatal.FlatAppearance.BorderColor = Color.FromArgb(227, 231, 225);
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnBatal.ForeColor = Color.FromArgb(53, 92, 69);
            btnBatal.Location = new Point(826, 638);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(120, 38);
            btnBatal.TabIndex = 12;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;

            // 
            // FormPenetasan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 245, 237);
            ClientSize = new Size(1100, 700);
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
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormPenetasan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Penetasan";
            ((System.ComponentModel.ISupportInitialize)numMenetas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGagal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
