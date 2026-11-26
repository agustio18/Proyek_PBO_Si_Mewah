
namespace SiMewah.Views.Produksi.Perkawinan
{
    partial class FormPerkawinan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lbl_judul = new Label();
            lbl_tanggal = new Label();
            dtp_tanggal = new DateTimePicker();
            lbl_jantan = new Label();
            lbl_betina = new Label();
            cmb_jantan = new ComboBox();
            cmb_betina = new ComboBox();
            btn_simpan = new Button();
            btn_batal = new Button();
            SuspendLayout();

            // 
            // lbl_judul
            // 
            lbl_judul.AutoSize = true;
            lbl_judul.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lbl_judul.ForeColor = Color.FromArgb(53, 92, 69);
            lbl_judul.Location = new Point(24, 24);
            lbl_judul.Name = "lbl_judul";
            lbl_judul.Size = new Size(258, 41);
            lbl_judul.TabIndex = 0;
            lbl_judul.Text = "Form Perkawinan";

            // 
            // lbl_tanggal
            // 
            lbl_tanggal.AutoSize = true;
            lbl_tanggal.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lbl_tanggal.ForeColor = Color.FromArgb(48, 56, 50);
            lbl_tanggal.Location = new Point(24, 100);
            lbl_tanggal.Name = "lbl_tanggal";
            lbl_tanggal.Size = new Size(166, 21);
            lbl_tanggal.TabIndex = 1;
            lbl_tanggal.Text = "Tanggal Perkawinan";

            // 
            // dtp_tanggal
            // 
            dtp_tanggal.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            dtp_tanggal.Format = DateTimePickerFormat.Short;
            dtp_tanggal.Location = new Point(24, 128);
            dtp_tanggal.Name = "dtp_tanggal";
            dtp_tanggal.Size = new Size(480, 34);
            dtp_tanggal.TabIndex = 2;

            // 
            // lbl_jantan
            // 
            lbl_jantan.AutoSize = true;
            lbl_jantan.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lbl_jantan.ForeColor = Color.FromArgb(48, 56, 50);
            lbl_jantan.Location = new Point(24, 190);
            lbl_jantan.Name = "lbl_jantan";
            lbl_jantan.Size = new Size(126, 21);
            lbl_jantan.TabIndex = 3;
            lbl_jantan.Text = "Burung Jantan";

            // 
            // cmb_jantan
            // 
            cmb_jantan.BackColor = Color.White;
            cmb_jantan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_jantan.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            cmb_jantan.ForeColor = Color.FromArgb(48, 56, 50);
            cmb_jantan.FormattingEnabled = true;
            cmb_jantan.Location = new Point(24, 218);
            cmb_jantan.Name = "cmb_jantan";
            cmb_jantan.Size = new Size(480, 34);
            cmb_jantan.TabIndex = 4;

            // 
            // lbl_betina
            // 
            lbl_betina.AutoSize = true;
            lbl_betina.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lbl_betina.ForeColor = Color.FromArgb(48, 56, 50);
            lbl_betina.Location = new Point(24, 280);
            lbl_betina.Name = "lbl_betina";
            lbl_betina.Size = new Size(122, 21);
            lbl_betina.TabIndex = 5;
            lbl_betina.Text = "Burung Betina";

            // 
            // cmb_betina
            // 
            cmb_betina.BackColor = Color.White;
            cmb_betina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_betina.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            cmb_betina.ForeColor = Color.FromArgb(48, 56, 50);
            cmb_betina.FormattingEnabled = true;
            cmb_betina.Location = new Point(24, 308);
            cmb_betina.Name = "cmb_betina";
            cmb_betina.Size = new Size(480, 34);
            cmb_betina.TabIndex = 6;

            // 
            // btn_simpan
            // 
            btn_simpan.BackColor = Color.FromArgb(53, 92, 69);
            btn_simpan.Cursor = Cursors.Hand;
            btn_simpan.FlatAppearance.BorderSize = 0;
            btn_simpan.FlatStyle = FlatStyle.Flat;
            btn_simpan.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btn_simpan.ForeColor = Color.White;
            btn_simpan.Location = new Point(956, 638);
            btn_simpan.Name = "btn_simpan";
            btn_simpan.Size = new Size(120, 38);
            btn_simpan.TabIndex = 7;
            btn_simpan.Text = "Simpan";
            btn_simpan.UseVisualStyleBackColor = false;

            // 
            // btn_batal
            // 
            btn_batal.BackColor = Color.White;
            btn_batal.Cursor = Cursors.Hand;
            btn_batal.FlatAppearance.BorderColor = Color.FromArgb(227, 231, 225);
            btn_batal.FlatStyle = FlatStyle.Flat;
            btn_batal.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btn_batal.ForeColor = Color.FromArgb(53, 92, 69);
            btn_batal.Location = new Point(826, 638);
            btn_batal.Name = "btn_batal";
            btn_batal.Size = new Size(120, 38);
            btn_batal.TabIndex = 8;
            btn_batal.Text = "Batal";
            btn_batal.UseVisualStyleBackColor = false;

            // 
            // FormPerkawinan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 245, 237);
            ClientSize = new Size(1100, 700);
            Controls.Add(btn_batal);
            Controls.Add(btn_simpan);
            Controls.Add(cmb_betina);
            Controls.Add(cmb_jantan);
            Controls.Add(lbl_betina);
            Controls.Add(lbl_jantan);
            Controls.Add(dtp_tanggal);
            Controls.Add(lbl_tanggal);
            Controls.Add(lbl_judul);
            Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormPerkawinan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Perkawinan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_judul;
        private Label lbl_tanggal;
        private DateTimePicker dtp_tanggal;
        private Label lbl_jantan;
        private Label lbl_betina;
        private ComboBox cmb_jantan;
        private ComboBox cmb_betina;
        private Button btn_simpan;
        private Button btn_batal;
    }
}
