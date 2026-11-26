
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
            lblJudul = new Label();
            lblJenis = new Label();
            cmbJenis = new ComboBox();
            lblKeterangan = new Label();
            txtKeterangan = new TextBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.BackColor = Color.Transparent;
            lblJudul.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.FromArgb(53, 92, 69);
            lblJudul.Location = new Point(35, 25);
            lblJudul.Margin = new Padding(4, 0, 4, 0);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(330, 60);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Form Kandang";
            // 
            // lblJenis
            // 
            lblJenis.AutoSize = true;
            lblJenis.BackColor = Color.Transparent;
            lblJenis.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJenis.ForeColor = Color.FromArgb(48, 56, 50);
            lblJenis.Location = new Point(35, 110);
            lblJenis.Margin = new Padding(4, 0, 4, 0);
            lblJenis.Name = "lblJenis";
            lblJenis.Size = new Size(135, 25);
            lblJenis.TabIndex = 1;
            lblJenis.Text = "Jenis Kandang";
            // 
            // cmbJenis
            // 
            cmbJenis.BackColor = Color.White;
            cmbJenis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJenis.ForeColor = Color.FromArgb(48, 56, 50);
            cmbJenis.FormattingEnabled = true;
            cmbJenis.Location = new Point(35, 135);
            cmbJenis.Margin = new Padding(4, 5, 4, 5);
            cmbJenis.Name = "cmbJenis";
            cmbJenis.Size = new Size(950, 33);
            cmbJenis.TabIndex = 2;
            // 
            // lblKeterangan
            // 
            lblKeterangan.AutoSize = true;
            lblKeterangan.BackColor = Color.Transparent;
            lblKeterangan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKeterangan.ForeColor = Color.FromArgb(48, 56, 50);
            lblKeterangan.Location = new Point(35, 205);
            lblKeterangan.Margin = new Padding(4, 0, 4, 0);
            lblKeterangan.Name = "lblKeterangan";
            lblKeterangan.Size = new Size(111, 25);
            lblKeterangan.TabIndex = 3;
            lblKeterangan.Text = "Keterangan";
            // 
            // txtKeterangan
            // 
            txtKeterangan.BackColor = Color.White;
            txtKeterangan.ForeColor = Color.FromArgb(48, 56, 50);
            txtKeterangan.Location = new Point(35, 230);
            txtKeterangan.Margin = new Padding(4, 5, 4, 5);
            txtKeterangan.Multiline = true;
            txtKeterangan.Name = "txtKeterangan";
            txtKeterangan.ScrollBars = ScrollBars.Vertical;
            txtKeterangan.Size = new Size(950, 180);
            txtKeterangan.TabIndex = 4;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(53, 92, 69);
            btnSimpan.Cursor = Cursors.Hand;
            btnSimpan.FlatAppearance.BorderColor = Color.FromArgb(227, 231, 225);
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(920, 590);
            btnSimpan.Margin = new Padding(4, 5, 4, 5);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(120, 38);
            btnSimpan.TabIndex = 5;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.White;
            btnBatal.Cursor = Cursors.Hand;
            btnBatal.FlatAppearance.BorderColor = Color.FromArgb(227, 231, 225);
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = Color.FromArgb(53, 92, 69);
            btnBatal.Location = new Point(790, 590);
            btnBatal.Margin = new Padding(4, 5, 4, 5);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(120, 38);
            btnBatal.TabIndex = 6;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            // 
            // FormKandang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 245, 237);
            ClientSize = new Size(1078, 644);
            Controls.Add(lblJudul);
            Controls.Add(lblJenis);
            Controls.Add(cmbJenis);
            Controls.Add(lblKeterangan);
            Controls.Add(txtKeterangan);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FormKandang";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form Kandang";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
