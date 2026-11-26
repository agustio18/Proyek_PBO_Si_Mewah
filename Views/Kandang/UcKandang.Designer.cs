
namespace SiMewah.Views.Kandang
{
    partial class UcKandang
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.TextBox txtPencarian;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.DataGridView dgvKandang;

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
            txtPencarian = new TextBox();
            btnCari = new Button();
            btnTambah = new Button();
            btnUbah = new Button();
            dgvKandang = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKandang).BeginInit();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.BackColor = Color.Transparent;
            lblJudul.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblJudul.ForeColor = Color.FromArgb(53, 92, 69);
            lblJudul.Location = new Point(35, 25);
            lblJudul.Margin = new Padding(4, 0, 4, 0);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(319, 60);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Data Kandang";
            // 
            // txtPencarian
            // 
            txtPencarian.BackColor = Color.White;
            txtPencarian.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            btnCari.FlatStyle = FlatStyle.Flat;
            btnCari.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(790, 125);
            btnTambah.Margin = new Padding(4, 5, 4, 5);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(120, 38);
            btnTambah.TabIndex = 4;
            btnTambah.Text = "Tambah Kandang";
            btnTambah.UseVisualStyleBackColor = false;
            // 
            // btnUbah
            // 
            btnUbah.BackColor = Color.FromArgb(143, 175, 145);
            btnUbah.Cursor = Cursors.Hand;
            btnUbah.FlatStyle = FlatStyle.Flat;
            btnUbah.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUbah.ForeColor = Color.White;
            btnUbah.Location = new Point(920, 125);
            btnUbah.Margin = new Padding(4, 5, 4, 5);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(120, 38);
            btnUbah.TabIndex = 5;
            btnUbah.Text = "Ubah";
            btnUbah.UseVisualStyleBackColor = false;
            // 
            // dgvKandang
            // 
            dgvKandang.AllowUserToAddRows = false;
            dgvKandang.AllowUserToDeleteRows = false;
            dgvKandang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvKandang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKandang.BackgroundColor = Color.White;
            dgvKandang.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(53, 92, 69);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvKandang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvKandang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKandang.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(48, 56, 50);
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(143, 175, 145);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(48, 56, 50);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvKandang.DefaultCellStyle = dataGridViewCellStyle2;
            dgvKandang.EnableHeadersVisualStyles = false;
            dgvKandang.Location = new Point(38, 185);
            dgvKandang.Margin = new Padding(4, 5, 4, 5);
            dgvKandang.MultiSelect = false;
            dgvKandang.Name = "dgvKandang";
            dgvKandang.ReadOnly = true;
            dgvKandang.RowHeadersVisible = false;
            dgvKandang.RowHeadersWidth = 62;
            dgvKandang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKandang.Size = new Size(1015, 420);
            dgvKandang.TabIndex = 6;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(120, 128, 120);
            label1.Location = new Point(44, 73);
            label1.Name = "label1";
            label1.Size = new Size(191, 28);
            label1.TabIndex = 7;
            label1.Text = "Kelola data kandang";
            // 
            // UcKandang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(247, 245, 237);
            ClientSize = new Size(1078, 644);
            Controls.Add(label1);
            Controls.Add(lblJudul);
            Controls.Add(txtPencarian);
            Controls.Add(btnCari);
            Controls.Add(btnTambah);
            Controls.Add(btnUbah);
            Controls.Add(dgvKandang);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "UcKandang";
            StartPosition = FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)dgvKandang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Label label1;
    }
}
