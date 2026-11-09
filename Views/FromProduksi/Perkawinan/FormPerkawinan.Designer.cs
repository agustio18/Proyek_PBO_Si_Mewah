namespace Proyek_PBO___Si_Mewah.Views.FromProduksi.Perkawinan
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
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_judul = new Label();
            lbl_tanggal = new Label();
            dtp_tanggal = new DateTimePicker();
            lbl_jantan = new Label();
            lbl_betina = new Label();
            cmb_jantan = new ComboBox();
            cmb_betina = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lbl_judul
            // 
            lbl_judul.AutoSize = true;
            lbl_judul.Dock = DockStyle.Top;
            lbl_judul.Font = new Font("Microsoft Sans Serif", 13.2F, FontStyle.Bold);
            lbl_judul.Location = new Point(0, 0);
            lbl_judul.Margin = new Padding(4, 0, 4, 0);
            lbl_judul.Name = "lbl_judul";
            lbl_judul.Size = new Size(198, 26);
            lbl_judul.TabIndex = 1;
            lbl_judul.Text = "Form Perkawinan";
            // 
            // lbl_tanggal
            // 
            lbl_tanggal.AutoSize = true;
            lbl_tanggal.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lbl_tanggal.Location = new Point(14, 70);
            lbl_tanggal.Margin = new Padding(4, 0, 4, 0);
            lbl_tanggal.Name = "lbl_tanggal";
            lbl_tanggal.Size = new Size(177, 20);
            lbl_tanggal.TabIndex = 2;
            lbl_tanggal.Text = "Tanggal Perkawinan";
            // 
            // dtp_tanggal
            // 
            dtp_tanggal.Location = new Point(21, 100);
            dtp_tanggal.Margin = new Padding(4, 3, 4, 3);
            dtp_tanggal.Name = "dtp_tanggal";
            dtp_tanggal.Size = new Size(342, 28);
            dtp_tanggal.TabIndex = 3;
            // 
            // lbl_jantan
            // 
            lbl_jantan.AutoSize = true;
            lbl_jantan.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lbl_jantan.Location = new Point(21, 170);
            lbl_jantan.Margin = new Padding(4, 0, 4, 0);
            lbl_jantan.Name = "lbl_jantan";
            lbl_jantan.Size = new Size(131, 20);
            lbl_jantan.TabIndex = 4;
            lbl_jantan.Text = "Burung Jantan";
            // 
            // lbl_betina
            // 
            lbl_betina.AutoSize = true;
            lbl_betina.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lbl_betina.Location = new Point(21, 270);
            lbl_betina.Margin = new Padding(4, 0, 4, 0);
            lbl_betina.Name = "lbl_betina";
            lbl_betina.Size = new Size(129, 20);
            lbl_betina.TabIndex = 5;
            lbl_betina.Text = "Burung Betina";
            // 
            // cmb_jantan
            // 
            cmb_jantan.FormattingEnabled = true;
            cmb_jantan.Location = new Point(21, 300);
            cmb_jantan.Margin = new Padding(4, 3, 4, 3);
            cmb_jantan.Name = "cmb_jantan";
            cmb_jantan.Size = new Size(206, 28);
            cmb_jantan.TabIndex = 6;
            // 
            // cmb_betina
            // 
            cmb_betina.FormattingEnabled = true;
            cmb_betina.Location = new Point(21, 200);
            cmb_betina.Margin = new Padding(4, 3, 4, 3);
            cmb_betina.Name = "cmb_betina";
            cmb_betina.Size = new Size(206, 28);
            cmb_betina.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            button1.Location = new Point(860, 520);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(129, 29);
            button1.TabIndex = 8;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            button2.Location = new Point(1010, 520);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(129, 29);
            button2.TabIndex = 9;
            button2.Text = "Batal";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormPerkawinan
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1350, 603);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cmb_betina);
            Controls.Add(cmb_jantan);
            Controls.Add(lbl_betina);
            Controls.Add(lbl_jantan);
            Controls.Add(dtp_tanggal);
            Controls.Add(lbl_tanggal);
            Controls.Add(lbl_judul);
            Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(1643, 750);
            MinimumSize = new Size(1368, 650);
            Name = "FormPerkawinan";
            Text = "FormPerkawinan";
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
        private Button button1;
        private Button button2;
    }
}