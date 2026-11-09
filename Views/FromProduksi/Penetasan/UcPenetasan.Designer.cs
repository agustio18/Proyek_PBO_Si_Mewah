
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
            lblJudul.Location = new Point(23, 27);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(111, 20);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Data Penetasan";
            // 
            // lblPencarian
            // 
            lblPencarian.AutoSize = true;
            lblPencarian.Location = new Point(23, 87);
            lblPencarian.Name = "lblPencarian";
            lblPencarian.Size = new Size(72, 20);
            lblPencarian.TabIndex = 1;
            lblPencarian.Text = "Cari data:";
            // 
            // txtPencarian
            // 
            txtPencarian.Location = new Point(114, 83);
            txtPencarian.Margin = new Padding(3, 4, 3, 4);
            txtPencarian.Name = "txtPencarian";
            txtPencarian.Size = new Size(251, 27);
            txtPencarian.TabIndex = 2;
            // 
            // btnCari
            // 
            btnCari.Location = new Point(377, 80);
            btnCari.Margin = new Padding(3, 4, 3, 4);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(91, 36);
            btnCari.TabIndex = 3;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = true;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(23, 147);
            btnTambah.Margin = new Padding(3, 4, 3, 4);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(160, 40);
            btnTambah.TabIndex = 4;
            btnTambah.Text = "Tambah Penetasan";
            btnTambah.UseVisualStyleBackColor = true;
            // 
            // btnUbah
            // 
            btnUbah.Location = new Point(194, 147);
            btnUbah.Margin = new Padding(3, 4, 3, 4);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(91, 40);
            btnUbah.TabIndex = 5;
            btnUbah.Text = "Ubah";
            btnUbah.UseVisualStyleBackColor = true;
            // 
            // dgvPenetasan
            // 
            dgvPenetasan.AllowUserToAddRows = false;
            dgvPenetasan.AllowUserToDeleteRows = false;
            dgvPenetasan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPenetasan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPenetasan.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dgvPenetasan.Location = new Point(23, 213);
            dgvPenetasan.Margin = new Padding(3, 4, 3, 4);
            dgvPenetasan.MultiSelect = false;
            dgvPenetasan.Name = "dgvPenetasan";
            dgvPenetasan.ReadOnly = true;
            dgvPenetasan.RowHeadersWidth = 51;
            dgvPenetasan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPenetasan.Size = new Size(857, 467);
            dgvPenetasan.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // UcPenetasan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 644);
            Controls.Add(lblJudul);
            Controls.Add(lblPencarian);
            Controls.Add(txtPencarian);
            Controls.Add(btnCari);
            Controls.Add(btnTambah);
            Controls.Add(btnUbah);
            Controls.Add(dgvPenetasan);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UcPenetasan";
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
