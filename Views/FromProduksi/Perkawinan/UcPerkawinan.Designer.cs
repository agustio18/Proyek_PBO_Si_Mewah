
namespace SiMewah.Views.Produksi.Perkawinan
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lbl_judul = new Label();
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
            col_id_jantan = new DataGridViewTextBoxColumn();
            col_id_betina = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dg_perkawinan).BeginInit();
            SuspendLayout();

            // 
            // lbl_judul
            // 
            lbl_judul.AutoSize = true;
            lbl_judul.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lbl_judul.ForeColor = Color.FromArgb(53, 92, 69);
            lbl_judul.Location = new Point(24, 20);
            lbl_judul.Name = "lbl_judul";
            lbl_judul.Size = new Size(237, 41);
            lbl_judul.TabIndex = 0;
            lbl_judul.Text = "Data Perkawinan";

            // 
            // lbl_pencarian
            // 
            lbl_pencarian.AutoSize = true;
            lbl_pencarian.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lbl_pencarian.ForeColor = Color.FromArgb(48, 56, 50);
            lbl_pencarian.Location = new Point(24, 70);
            lbl_pencarian.Name = "lbl_pencarian";
            lbl_pencarian.Size = new Size(80, 21);
            lbl_pencarian.TabIndex = 1;
            lbl_pencarian.Text = "Cari Data";

            // 
            // tb_pencarian
            // 
            tb_pencarian.BackColor = Color.White;
            tb_pencarian.BorderStyle = BorderStyle.FixedSingle;
            tb_pencarian.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            tb_pencarian.ForeColor = Color.FromArgb(48, 56, 50);
            tb_pencarian.Location = new Point(24, 94);
            tb_pencarian.Name = "tb_pencarian";
            tb_pencarian.Size = new Size(260, 34);
            tb_pencarian.TabIndex = 2;

            // 
            // btn_pencarian
            // 
            btn_pencarian.BackColor = Color.FromArgb(53, 92, 69);
            btn_pencarian.Cursor = Cursors.Hand;
            btn_pencarian.FlatAppearance.BorderSize = 0;
            btn_pencarian.FlatStyle = FlatStyle.Flat;
            btn_pencarian.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btn_pencarian.ForeColor = Color.White;
            btn_pencarian.Location = new Point(292, 92);
            btn_pencarian.Name = "btn_pencarian";
            btn_pencarian.Size = new Size(100, 38);
            btn_pencarian.TabIndex = 3;
            btn_pencarian.Text = "Cari";
            btn_pencarian.UseVisualStyleBackColor = false;

            // 
            // btn_tambah_perkawinan
            // 
            btn_tambah_perkawinan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_tambah_perkawinan.BackColor = Color.FromArgb(53, 92, 69);
            btn_tambah_perkawinan.Cursor = Cursors.Hand;
            btn_tambah_perkawinan.FlatAppearance.BorderSize = 0;
            btn_tambah_perkawinan.FlatStyle = FlatStyle.Flat;
            btn_tambah_perkawinan.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btn_tambah_perkawinan.ForeColor = Color.White;
            btn_tambah_perkawinan.Location = new Point(506, 92);
            btn_tambah_perkawinan.Name = "btn_tambah_perkawinan";
            btn_tambah_perkawinan.Size = new Size(180, 38);
            btn_tambah_perkawinan.TabIndex = 4;
            btn_tambah_perkawinan.Text = "Tambah Data";
            btn_tambah_perkawinan.UseVisualStyleBackColor = false;

            // 
            // btn_ubah
            // 
            btn_ubah.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_ubah.BackColor = Color.FromArgb(143, 175, 145);
            btn_ubah.Cursor = Cursors.Hand;
            btn_ubah.FlatAppearance.BorderSize = 0;
            btn_ubah.FlatStyle = FlatStyle.Flat;
            btn_ubah.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btn_ubah.ForeColor = Color.FromArgb(48, 56, 50);
            btn_ubah.Location = new Point(696, 92);
            btn_ubah.Name = "btn_ubah";
            btn_ubah.Size = new Size(120, 38);
            btn_ubah.TabIndex = 5;
            btn_ubah.Text = "Ubah";
            btn_ubah.UseVisualStyleBackColor = false;

            // 
            // dg_perkawinan
            // 
            dg_perkawinan.AllowUserToAddRows = false;
            dg_perkawinan.AllowUserToDeleteRows = false;
            dg_perkawinan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dg_perkawinan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_perkawinan.BackgroundColor = Color.White;
            dg_perkawinan.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(53, 92, 69);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(53, 92, 69);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dg_perkawinan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dg_perkawinan.ColumnHeadersHeight = 40;
            dg_perkawinan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dg_perkawinan.Columns.AddRange(new DataGridViewColumn[] { col_tanggal, col_id, col_jantan, col_betina, col_id_jantan, col_id_betina });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(48, 56, 50);
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(143, 175, 145);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(48, 56, 50);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dg_perkawinan.DefaultCellStyle = dataGridViewCellStyle2;
            dg_perkawinan.EnableHeadersVisualStyles = false;
            dg_perkawinan.GridColor = Color.FromArgb(227, 231, 225);
            dg_perkawinan.Location = new Point(24, 146);
            dg_perkawinan.MultiSelect = false;
            dg_perkawinan.Name = "dg_perkawinan";
            dg_perkawinan.ReadOnly = true;
            dg_perkawinan.RowHeadersVisible = false;
            dg_perkawinan.RowTemplate.Height = 36;
            dg_perkawinan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_perkawinan.Size = new Size(792, 415);
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
            // col_id_jantan
            // 
            col_id_jantan.HeaderText = "ID Jantan";
            col_id_jantan.MinimumWidth = 6;
            col_id_jantan.Name = "col_id_jantan";
            col_id_jantan.ReadOnly = true;
            col_id_jantan.Visible = false;

            // 
            // col_id_betina
            // 
            col_id_betina.HeaderText = "ID Betina";
            col_id_betina.MinimumWidth = 6;
            col_id_betina.Name = "col_id_betina";
            col_id_betina.ReadOnly = true;
            col_id_betina.Visible = false;

            // 
            // UcPerkawinan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 245, 237);
            Controls.Add(dg_perkawinan);
            Controls.Add(btn_tambah_perkawinan);
            Controls.Add(btn_ubah);
            Controls.Add(btn_pencarian);
            Controls.Add(tb_pencarian);
            Controls.Add(lbl_pencarian);
            Controls.Add(lbl_judul);
            Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            Name = "UcPerkawinan";
            Size = new Size(840, 585);
            Load += UcPerkawinan_Load;
            ((System.ComponentModel.ISupportInitialize)dg_perkawinan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_judul;
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
        private DataGridViewTextBoxColumn col_id_jantan;
        private DataGridViewTextBoxColumn col_id_betina;
    }
}
