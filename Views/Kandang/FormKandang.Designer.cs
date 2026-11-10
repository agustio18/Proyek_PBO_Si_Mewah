
namespace SiMewah.Views.Kandang
{
    partial class FormKandang
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblJenis;
        private System.Windows.Forms.ComboBox cmbJenis;
        private System.Windows.Forms.Label lblKeterangan;
        private System.Windows.Forms.TextBox txtKeterangan;
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
            this.lblJenis = new System.Windows.Forms.Label();
            this.cmbJenis = new System.Windows.Forms.ComboBox();
            this.lblKeterangan = new System.Windows.Forms.Label();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // lblJudul
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font(
                "Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblJudul.Location = new System.Drawing.Point(25, 20);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(118, 21);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Form Kandang";

            // lblJenis
            this.lblJenis.AutoSize = true;
            this.lblJenis.Location = new System.Drawing.Point(25, 70);
            this.lblJenis.Name = "lblJenis";
            this.lblJenis.Size = new System.Drawing.Size(80, 15);
            this.lblJenis.TabIndex = 1;
            this.lblJenis.Text = "Jenis Kandang";

            // cmbJenis
            this.cmbJenis.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJenis.FormattingEnabled = true;
            this.cmbJenis.Location = new System.Drawing.Point(25, 90);
            this.cmbJenis.Name = "cmbJenis";
            this.cmbJenis.Size = new System.Drawing.Size(380, 23);
            this.cmbJenis.TabIndex = 2;

            // lblKeterangan
            this.lblKeterangan.AutoSize = true;
            this.lblKeterangan.Location = new System.Drawing.Point(25, 135);
            this.lblKeterangan.Name = "lblKeterangan";
            this.lblKeterangan.Size = new System.Drawing.Size(67, 15);
            this.lblKeterangan.TabIndex = 3;
            this.lblKeterangan.Text = "Keterangan";

            // txtKeterangan
            this.txtKeterangan.Location = new System.Drawing.Point(25, 155);
            this.txtKeterangan.Multiline = true;
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(380, 80);
            this.txtKeterangan.TabIndex = 4;

            // btnSimpan
            this.btnSimpan.Location = new System.Drawing.Point(315, 270);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(90, 30);
            this.btnSimpan.TabIndex = 5;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;

            // btnBatal
            this.btnBatal.Location = new System.Drawing.Point(215, 270);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(90, 30);
            this.btnBatal.TabIndex = 6;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;

            // FormKandang
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 340);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.lblJenis);
            this.Controls.Add(this.cmbJenis);
            this.Controls.Add(this.lblKeterangan);
            this.Controls.Add(this.txtKeterangan);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.Name = "FormKandang";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form Kandang";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
