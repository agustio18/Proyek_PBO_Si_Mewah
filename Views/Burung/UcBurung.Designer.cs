
namespace SiMewah.Views.Burung
{
    partial class UcBurung
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.TextBox txtPencarian;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.DataGridView dgvBurung;

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
            dgvBurung = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBurung).BeginInit();
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
            lblJudul.Size = new Size(288, 60);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Data Burung";
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
            btnTambah.Text = "Tambah Burung";
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
            // dgvBurung
            // 
            dgvBurung.AllowUserToAddRows = false;
            dgvBurung.AllowUserToDeleteRows = false;
            dgvBurung.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBurung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBurung.BackgroundColor = Color.White;
            dgvBurung.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(53, 92, 69);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBurung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBurung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBurung.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(48, 56, 50);
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(143, 175, 145);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(48, 56, 50);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBurung.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBurung.EnableHeadersVisualStyles = false;
            dgvBurung.Location = new Point(35, 185);
            dgvBurung.Margin = new Padding(4, 5, 4, 5);
            dgvBurung.MultiSelect = false;
            dgvBurung.Name = "dgvBurung";
            dgvBurung.ReadOnly = true;
            dgvBurung.RowHeadersVisible = false;
            dgvBurung.RowHeadersWidth = 62;
            dgvBurung.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBurung.Size = new Size(1015, 420);
            dgvBurung.TabIndex = 6;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(120, 128, 120);
            label1.Location = new Point(45, 76);
            label1.Name = "label1";
            label1.Size = new Size(179, 28);
            label1.TabIndex = 7;
            label1.Text = "Kelola data burung";
            // 
            // UcBurung
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 245, 237);
            ClientSize = new Size(1078, 644);
            Controls.Add(label1);
            Controls.Add(lblJudul);
            Controls.Add(txtPencarian);
            Controls.Add(btnCari);
            Controls.Add(btnTambah);
            Controls.Add(btnUbah);
            Controls.Add(dgvBurung);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "UcBurung";
            StartPosition = FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)dgvBurung).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Label label1;
    }
}
