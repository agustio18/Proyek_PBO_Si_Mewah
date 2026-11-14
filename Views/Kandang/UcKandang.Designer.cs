
namespace SiMewah.Views.Kandang
{
    partial class UcKandang
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblPencarian;
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
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblPencarian = new System.Windows.Forms.Label();
            this.txtPencarian = new System.Windows.Forms.TextBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.dgvKandang = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvKandang)).BeginInit();
            this.SuspendLayout();

            // lblJudul
            this.lblJudul.AutoSize = true;
            this.lblJudul.Location = new System.Drawing.Point(20, 20);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(85, 15);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Data Kandang";

            // lblPencarian
            this.lblPencarian.AutoSize = true;
            this.lblPencarian.Location = new System.Drawing.Point(20, 65);
            this.lblPencarian.Name = "lblPencarian";
            this.lblPencarian.Size = new System.Drawing.Size(55, 15);
            this.lblPencarian.TabIndex = 1;
            this.lblPencarian.Text = "Cari data:";

            // txtPencarian
            this.txtPencarian.Location = new System.Drawing.Point(100, 62);
            this.txtPencarian.Name = "txtPencarian";
            this.txtPencarian.Size = new System.Drawing.Size(220, 23);
            this.txtPencarian.TabIndex = 2;

            // btnCari
            this.btnCari.Location = new System.Drawing.Point(330, 60);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(80, 27);
            this.btnCari.TabIndex = 3;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;

            // btnTambah
            this.btnTambah.Location = new System.Drawing.Point(20, 110);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(130, 30);
            this.btnTambah.TabIndex = 4;
            this.btnTambah.Text = "Tambah Kandang";
            this.btnTambah.UseVisualStyleBackColor = true;

            // btnUbah
            this.btnUbah.Location = new System.Drawing.Point(160, 110);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(80, 30);
            this.btnUbah.TabIndex = 5;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;

            // dgvKandang
            this.dgvKandang.AllowUserToAddRows = false;
            this.dgvKandang.AllowUserToDeleteRows = false;
            this.dgvKandang.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKandang.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKandang.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    new System.Windows.Forms.DataGridViewTextBoxColumn()
                    {
                        Name = "colJenis",
                        HeaderText = "Jenis Kandang"
                    },
                    new System.Windows.Forms.DataGridViewTextBoxColumn()
                    {
                        Name = "colKeterangan",
                        HeaderText = "Keterangan"
                    },
                    new System.Windows.Forms.DataGridViewTextBoxColumn()
                    {
                        Name = "colId",
                        HeaderText = "ID Kandang",
                        Visible = false
                    }
                });
            this.dgvKandang.Location = new System.Drawing.Point(20, 160);
            this.dgvKandang.Name = "dgvKandang";
            this.dgvKandang.ReadOnly = true;
            this.dgvKandang.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKandang.MultiSelect = false;
            this.dgvKandang.Size = new System.Drawing.Size(700, 350);
            this.dgvKandang.Anchor = System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Left
                | System.Windows.Forms.AnchorStyles.Right
                | System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvKandang.TabIndex = 6;

            // UcKandang
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.lblPencarian);
            this.Controls.Add(this.txtPencarian);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.dgvKandang);
            this.Name = "UcKandang";
            this.Size = new System.Drawing.Size(750, 530);

            ((System.ComponentModel.ISupportInitialize)(this.dgvKandang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
