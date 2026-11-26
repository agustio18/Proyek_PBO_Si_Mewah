
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
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.FromArgb(53, 92, 69);
            this.lblJudul.Location = new System.Drawing.Point(24, 24);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(152, 41);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Form Telur";

            // lblPerkawinan
            this.lblPerkawinan.AutoSize = true;
            this.lblPerkawinan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPerkawinan.ForeColor = System.Drawing.Color.FromArgb(48, 56, 50);
            this.lblPerkawinan.Location = new System.Drawing.Point(24, 100);
            this.lblPerkawinan.Name = "lblPerkawinan";
            this.lblPerkawinan.Size = new System.Drawing.Size(85, 21);
            this.lblPerkawinan.TabIndex = 1;
            this.lblPerkawinan.Text = "Perkawinan";

            // cmbPerkawinan
            this.cmbPerkawinan.BackColor = System.Drawing.Color.White;
            this.cmbPerkawinan.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerkawinan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.cmbPerkawinan.ForeColor = System.Drawing.Color.FromArgb(48, 56, 50);
            this.cmbPerkawinan.FormattingEnabled = true;
            this.cmbPerkawinan.Location = new System.Drawing.Point(24, 128);
            this.cmbPerkawinan.Name = "cmbPerkawinan";
            this.cmbPerkawinan.Size = new System.Drawing.Size(480, 34);
            this.cmbPerkawinan.TabIndex = 2;

            // lblTanggal
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTanggal.ForeColor = System.Drawing.Color.FromArgb(48, 56, 50);
            this.lblTanggal.Location = new System.Drawing.Point(24, 190);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(93, 21);
            this.lblTanggal.TabIndex = 3;
            this.lblTanggal.Text = "Tanggal Telur";

            // dtpTanggal
            this.dtpTanggal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.dtpTanggal.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTanggal.Location = new System.Drawing.Point(24, 218);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(480, 34);
            this.dtpTanggal.TabIndex = 4;

            // lblJumlah
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblJumlah.ForeColor = System.Drawing.Color.FromArgb(48, 56, 50);
            this.lblJumlah.Location = new System.Drawing.Point(24, 280);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(100, 21);
            this.lblJumlah.TabIndex = 5;
            this.lblJumlah.Text = "Jumlah Telur";

            // numJumlah
            this.numJumlah.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.numJumlah.Location = new System.Drawing.Point(24, 308);
            this.numJumlah.Minimum = 1;
            this.numJumlah.Maximum = 100;
            this.numJumlah.Name = "numJumlah";
            this.numJumlah.Size = new System.Drawing.Size(480, 34);
            this.numJumlah.TabIndex = 6;

            // btnSimpan
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(53, 92, 69);
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(956, 638);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(120, 38);
            this.btnSimpan.TabIndex = 7;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;

            // btnBatal
            this.btnBatal.BackColor = System.Drawing.Color.White;
            this.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(227, 231, 225);
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnBatal.ForeColor = System.Drawing.Color.FromArgb(53, 92, 69);
            this.btnBatal.Location = new System.Drawing.Point(826, 638);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(120, 38);
            this.btnBatal.TabIndex = 8;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;

            // FormTelur
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(247, 245, 237);
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.lblPerkawinan);
            this.Controls.Add(this.cmbPerkawinan);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.lblJumlah);
            this.Controls.Add(this.numJumlah);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormTelur";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Telur";

            ((System.ComponentModel.ISupportInitialize)(this.numJumlah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
