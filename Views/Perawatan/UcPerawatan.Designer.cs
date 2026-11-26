namespace SiMewah.Views.Perawatan
{
    partial class UcPerawatan
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblPencarian;
        private System.Windows.Forms.TextBox txtPencarian;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.DataGridView dgvPerawatan;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblJudul = new Label();
            lblPencarian = new Label();
            txtPencarian = new TextBox();
            btnCari = new Button();
            btnTambah = new Button();
            btnUbah = new Button();
            btnHapus = new Button();
            dgvPerawatan = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPerawatan).BeginInit();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.FromArgb(53, 92, 69);
            lblJudul.Location = new Point(35, 25);
            lblJudul.Margin = new Padding(4, 0, 4, 0);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(353, 60);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Data Perawatan";
            // 
            // lblPencarian
            // 
            lblPencarian.AutoSize = true;
            lblPencarian.Font = new Font("Segoe UI", 10F);
            lblPencarian.ForeColor = Color.FromArgb(120, 128, 120);
            lblPencarian.Location = new Point(44, 85);
            lblPencarian.Margin = new Padding(4, 0, 4, 0);
            lblPencarian.Name = "lblPencarian";
            lblPencarian.Size = new Size(357, 28);
            lblPencarian.TabIndex = 1;
            lblPencarian.Text = "Kelola riwayat perawatan burung kenari";
            // 
            // txtPencarian
            // 
            txtPencarian.BackColor = Color.White;
            txtPencarian.BorderStyle = BorderStyle.FixedSingle;
            txtPencarian.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPencarian.ForeColor = Color.FromArgb(48, 56, 50);
            txtPencarian.Location = new Point(35, 125);
            txtPencarian.Margin = new Padding(4, 5, 4, 5);
            txtPencarian.Name = "txtPencarian";
            txtPencarian.Size = new Size(300, 34);
            txtPencarian.TabIndex = 2;
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.FromArgb(53, 92, 69);
            btnCari.Cursor = Cursors.Hand;
            btnCari.FlatAppearance.BorderSize = 0;
            btnCari.FlatStyle = FlatStyle.Flat;
            btnCari.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCari.ForeColor = Color.White;
            btnCari.Location = new Point(345, 125);
            btnCari.Margin = new Padding(4, 5, 4, 5);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(85, 35);
            btnCari.TabIndex = 3;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.FromArgb(53, 92, 69);
            btnTambah.Cursor = Cursors.Hand;
            btnTambah.FlatAppearance.BorderSize = 0;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(660, 125);
            btnTambah.Margin = new Padding(4, 5, 4, 5);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(120, 38);
            btnTambah.TabIndex = 4;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            // 
            // btnUbah
            // 
            btnUbah.BackColor = Color.FromArgb(143, 175, 145);
            btnUbah.Cursor = Cursors.Hand;
            btnUbah.FlatAppearance.BorderSize = 0;
            btnUbah.FlatStyle = FlatStyle.Flat;
            btnUbah.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnUbah.ForeColor = Color.White;
            btnUbah.Location = new Point(790, 125);
            btnUbah.Margin = new Padding(4, 5, 4, 5);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(120, 38);
            btnUbah.TabIndex = 5;
            btnUbah.Text = "Ubah";
            btnUbah.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.FromArgb(201, 107, 99);
            btnHapus.Cursor = Cursors.Hand;
            btnHapus.FlatAppearance.BorderSize = 0;
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnHapus.ForeColor = Color.White;
            btnHapus.Location = new Point(920, 125);
            btnHapus.Margin = new Padding(4, 5, 4, 5);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(120, 38);
            btnHapus.TabIndex = 6;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            // 
            // dgvPerawatan
            // 
            dgvPerawatan.AllowUserToAddRows = false;
            dgvPerawatan.AllowUserToDeleteRows = false;
            dgvPerawatan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPerawatan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPerawatan.BackgroundColor = Color.White;
            dgvPerawatan.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(53, 92, 69);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(53, 92, 69);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPerawatan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPerawatan.ColumnHeadersHeight = 38;
            dgvPerawatan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPerawatan.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(48, 56, 50);
            dataGridViewCellStyle2.Padding = new Padding(6, 0, 6, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(143, 175, 145);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(48, 56, 50);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPerawatan.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPerawatan.EnableHeadersVisualStyles = false;
            dgvPerawatan.GridColor = Color.FromArgb(227, 231, 225);
            dgvPerawatan.Location = new Point(35, 185);
            dgvPerawatan.Margin = new Padding(4, 5, 4, 5);
            dgvPerawatan.MultiSelect = false;
            dgvPerawatan.Name = "dgvPerawatan";
            dgvPerawatan.ReadOnly = true;
            dgvPerawatan.RowHeadersVisible = false;
            dgvPerawatan.RowHeadersWidth = 62;
            dgvPerawatan.RowTemplate.Height = 34;
            dgvPerawatan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPerawatan.Size = new Size(1015, 269);
            dgvPerawatan.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // UcPerawatan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 245, 237);
            ClientSize = new Size(1078, 644);
            Controls.Add(lblJudul);
            Controls.Add(lblPencarian);
            Controls.Add(txtPencarian);
            Controls.Add(btnCari);
            Controls.Add(btnTambah);
            Controls.Add(btnUbah);
            Controls.Add(btnHapus);
            Controls.Add(dgvPerawatan);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UcPerawatan";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Data Perawatan";
            ((System.ComponentModel.ISupportInitialize)dgvPerawatan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
