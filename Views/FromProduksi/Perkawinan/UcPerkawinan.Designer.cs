namespace Proyek_PBO___Si_Mewah.Views.FromProduksi.Perkawinan
{
    partial class UcPerkawinan
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
            lbl_perkawinan = new Label();
            lbl_pencarian = new Label();
            tb_pencarian = new TextBox();
            btn_pencarian = new Button();
            btn_ubah = new Button();
            btn_tambah_perkawinan = new Button();
            dg_perkawinan = new DataGridView();
            col_tanggal = new DataGridViewTextBoxColumn();
            col_id = new DataGridViewTextBoxColumn();
            col_jantan = new DataGridViewTextBoxColumn();
            col_betina = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dg_perkawinan).BeginInit();
            SuspendLayout();
            // 
            // lbl_perkawinan
            // 
            lbl_perkawinan.AutoSize = true;
            lbl_perkawinan.Dock = DockStyle.Top;
            lbl_perkawinan.Font = new Font("Microsoft Sans Serif", 13.2F, FontStyle.Bold);
            lbl_perkawinan.Location = new Point(0, 0);
            lbl_perkawinan.Name = "lbl_perkawinan";
            lbl_perkawinan.Size = new Size(193, 26);
            lbl_perkawinan.TabIndex = 0;
            lbl_perkawinan.Text = "Data Perkawinan";
            lbl_perkawinan.Click += label1_Click;
            // 
            // lbl_pencarian
            // 
            lbl_pencarian.AutoSize = true;
            lbl_pencarian.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lbl_pencarian.Location = new Point(12, 87);
            lbl_pencarian.Name = "lbl_pencarian";
            lbl_pencarian.Size = new Size(90, 20);
            lbl_pencarian.TabIndex = 1;
            lbl_pencarian.Text = "Cari Data";
            // 
            // tb_pencarian
            // 
            tb_pencarian.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_pencarian.Location = new Point(122, 84);
            tb_pencarian.Name = "tb_pencarian";
            tb_pencarian.Size = new Size(125, 24);
            tb_pencarian.TabIndex = 2;
            // 
            // btn_pencarian
            // 
            btn_pencarian.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btn_pencarian.Location = new Point(827, 82);
            btn_pencarian.Name = "btn_pencarian";
            btn_pencarian.Size = new Size(94, 29);
            btn_pencarian.TabIndex = 3;
            btn_pencarian.Text = "Cari";
            btn_pencarian.UseVisualStyleBackColor = true;
            // 
            // btn_ubah
            // 
            btn_ubah.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btn_ubah.Location = new Point(827, 162);
            btn_ubah.Name = "btn_ubah";
            btn_ubah.Size = new Size(94, 29);
            btn_ubah.TabIndex = 4;
            btn_ubah.Text = "Ubah";
            btn_ubah.UseVisualStyleBackColor = true;
            // 
            // btn_tambah_perkawinan
            // 
            btn_tambah_perkawinan.AutoSize = true;
            btn_tambah_perkawinan.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btn_tambah_perkawinan.Location = new Point(581, 162);
            btn_tambah_perkawinan.Name = "btn_tambah_perkawinan";
            btn_tambah_perkawinan.Size = new Size(187, 30);
            btn_tambah_perkawinan.TabIndex = 5;
            btn_tambah_perkawinan.Text = "Tambah Perkawinan";
            btn_tambah_perkawinan.UseVisualStyleBackColor = true;
            // 
            // dg_perkawinan
            // 
            dg_perkawinan.AllowUserToAddRows = false;
            dg_perkawinan.AllowUserToDeleteRows = false;
            dg_perkawinan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_perkawinan.BackgroundColor = SystemColors.ControlLight;
            dg_perkawinan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_perkawinan.Columns.AddRange(new DataGridViewColumn[] { col_tanggal, col_id, col_jantan, col_betina });
            dg_perkawinan.Location = new Point(0, 239);
            dg_perkawinan.MultiSelect = false;
            dg_perkawinan.Name = "dg_perkawinan";
            dg_perkawinan.ReadOnly = true;
            dg_perkawinan.RowHeadersWidth = 51;
            dg_perkawinan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_perkawinan.Size = new Size(982, 369);
            dg_perkawinan.TabIndex = 6;
            // 
            // col_tanggal
            // 
            col_tanggal.HeaderText = "Tanggal Perkawinan";
            col_tanggal.MinimumWidth = 6;
            col_tanggal.Name = "col_tanggal";
            col_tanggal.ReadOnly = true;
            // 
            // col_id
            // 
            col_id.HeaderText = "ID Perkawinan";
            col_id.MinimumWidth = 6;
            col_id.Name = "col_id";
            col_id.ReadOnly = true;
            col_id.Visible = false;
            // 
            // col_jantan
            // 
            col_jantan.HeaderText = "Burung Jantan";
            col_jantan.MinimumWidth = 6;
            col_jantan.Name = "col_jantan";
            col_jantan.ReadOnly = true;
            // 
            // col_betina
            // 
            col_betina.HeaderText = "Burung Betina";
            col_betina.MinimumWidth = 6;
            col_betina.Name = "col_betina";
            col_betina.ReadOnly = true;
            // 
            // UcPerkawinan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 603);
            Controls.Add(dg_perkawinan);
            Controls.Add(btn_tambah_perkawinan);
            Controls.Add(btn_ubah);
            Controls.Add(btn_pencarian);
            Controls.Add(tb_pencarian);
            Controls.Add(lbl_pencarian);
            Controls.Add(lbl_perkawinan);
            MaximumSize = new Size(1200, 750);
            MinimumSize = new Size(1000, 650);
            Name = "UcPerkawinan";
            Text = "UcPerkawinan";
            ((System.ComponentModel.ISupportInitialize)dg_perkawinan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_perkawinan;
        private Label lbl_pencarian;
        private TextBox tb_pencarian;
        private Button btn_pencarian;
        private Button btn_ubah;
        private Button btn_tambah_perkawinan;
        private DataGridView dg_perkawinan;
        private DataGridViewTextBoxColumn col_tanggal;
        private DataGridViewTextBoxColumn col_id;
        private DataGridViewTextBoxColumn col_jantan;
        private DataGridViewTextBoxColumn col_betina;
    }
}