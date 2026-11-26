
namespace SiMewah.Views.Produksi.Penetasan
{
    partial class UcPenetasan
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblPencarian;
        private System.Windows.Forms.TextBox txtPencarian;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.DataGridView dgvPenetasan;

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
            dgvPenetasan = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPenetasan).BeginInit();
            SuspendLayout();

            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblJudul.ForeColor = Color.FromArgb(53, 92, 69);
            lblJudul.Location = new Point(24, 20);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(200, 41);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Data Penetasan";

            // 
            // lblPencarian
            // 
            lblPencarian.AutoSize = true;
            lblPencarian.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPencarian.ForeColor = Color.FromArgb(48, 56, 50);
            lblPencarian.Location = new Point(24, 70);
            lblPencarian.Name = "lblPencarian";
            lblPencarian.Size = new Size(80, 21);
            lblPencarian.TabIndex = 1;
            lblPencarian.Text = "Cari data:";

            // 
            // txtPencarian
            // 
            txtPencarian.BackColor = Color.White;
            txtPencarian.BorderStyle = BorderStyle.FixedSingle;
            txtPencarian.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            txtPencarian.ForeColor = Color.FromArgb(48, 56, 50);
            txtPencarian.Location = new Point(24, 94);
            txtPencarian.Name = "txtPencarian";
            txtPencarian.Size = new Size(260, 34);
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
            btnCari.Location = new Point(292, 92);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(100, 38);
            btnCari.TabIndex = 3;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;

            // 
            // btnTambah
            // 
            btnTambah.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTambah.BackColor = Color.FromArgb(53, 92, 69);
            btnTambah.Cursor = Cursors.Hand;
            btnTambah.FlatAppearance.BorderSize = 0;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(506, 92);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(180, 38);
            btnTambah.TabIndex = 4;
            btnTambah.Text = "Tambah Data";
            btnTambah.UseVisualStyleBackColor = false;

            // 
            // btnUbah
            // 
            btnUbah.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUbah.BackColor = Color.FromArgb(143, 175, 145);
            btnUbah.Cursor = Cursors.Hand;
            btnUbah.FlatAppearance.BorderSize = 0;
            btnUbah.FlatStyle = FlatStyle.Flat;
            btnUbah.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnUbah.ForeColor = Color.FromArgb(48, 56, 50);
            btnUbah.Location = new Point(696, 92);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(120, 38);
            btnUbah.TabIndex = 5;
            btnUbah.Text = "Ubah";
            btnUbah.UseVisualStyleBackColor = false;

            // 
            // dgvPenetasan
            // 
            dgvPenetasan.AllowUserToAddRows = false;
            dgvPenetasan.AllowUserToDeleteRows = false;
            dgvPenetasan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPenetasan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPenetasan.BackgroundColor = Color.White;
            dgvPenetasan.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(53, 92, 69);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(53, 92, 69);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPenetasan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPenetasan.ColumnHeadersHeight = 40;
            dgvPenetasan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPenetasan.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(48, 56, 50);
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(143, 175, 145);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(48, 56, 50);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPenetasan.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPenetasan.EnableHeadersVisualStyles = false;
            dgvPenetasan.GridColor = Color.FromArgb(227, 231, 225);
            dgvPenetasan.Location = new Point(24, 146);
            dgvPenetasan.MultiSelect = false;
            dgvPenetasan.Name = "dgvPenetasan";
            dgvPenetasan.ReadOnly = true;
            dgvPenetasan.RowHeadersVisible = false;
            dgvPenetasan.RowTemplate.Height = 36;
            dgvPenetasan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPenetasan.Size = new Size(792, 415);
            dgvPenetasan.TabIndex = 6;

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
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;

            // 
            // UcPenetasan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 245, 237);
            Controls.Add(lblJudul);
            Controls.Add(lblPencarian);
            Controls.Add(txtPencarian);
            Controls.Add(btnCari);
            Controls.Add(btnTambah);
            Controls.Add(btnUbah);
            Controls.Add(dgvPenetasan);
            Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            Name = "UcPenetasan";
            Size = new Size(840, 585);
            ((System.ComponentModel.ISupportInitialize)dgvPenetasan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
