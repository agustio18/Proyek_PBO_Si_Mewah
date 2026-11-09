
namespace SiMewah.Views.Produksi.Telur
{
    partial class UcTelur
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblPencarian;
        private System.Windows.Forms.TextBox txtPencarian;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.DataGridView dgvTelur;

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
            this.dgvTelur = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvTelur)).BeginInit();
            this.SuspendLayout();

            // lblJudul
            this.lblJudul.AutoSize = true;
            this.lblJudul.Location = new System.Drawing.Point(20, 20);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(70, 15);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Data Telur";

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
            this.btnTambah.Size = new System.Drawing.Size(120, 30);
            this.btnTambah.TabIndex = 4;
            this.btnTambah.Text = "Tambah Telur";
            this.btnTambah.UseVisualStyleBackColor = true;

            // btnUbah
            this.btnUbah.Location = new System.Drawing.Point(150, 110);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(80, 30);
            this.btnUbah.TabIndex = 5;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;

            // dgvTelur
            this.dgvTelur.AllowUserToAddRows = false;
            this.dgvTelur.AllowUserToDeleteRows = false;
            this.dgvTelur.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTelur.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelur.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    new System.Windows.Forms.DataGridViewTextBoxColumn()
                    {
                        Name = "colTanggal",
                        HeaderText = "Tanggal Telur"
                    },
                    new System.Windows.Forms.DataGridViewTextBoxColumn()
                    {
                        Name = "colJumlah",
                        HeaderText = "Jumlah Telur"
                    },
                    new System.Windows.Forms.DataGridViewTextBoxColumn()
                    {
                        Name = "colPerkawinan",
                        HeaderText = "Pasangan Perkawinan"
                    },
                    new System.Windows.Forms.DataGridViewTextBoxColumn()
                    {
                        Name = "colId",
                        HeaderText = "ID Telur",
                        Visible = false
                    }
                });
            this.dgvTelur.Location = new System.Drawing.Point(20, 160);
            this.dgvTelur.Name = "dgvTelur";
            this.dgvTelur.ReadOnly = true;
            this.dgvTelur.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTelur.MultiSelect = false;
            this.dgvTelur.Size = new System.Drawing.Size(700, 350);
            this.dgvTelur.TabIndex = 6;

            // UcTelur
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.lblPencarian);
            this.Controls.Add(this.txtPencarian);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.dgvTelur);
            this.Name = "UcTelur";
            this.Size = new System.Drawing.Size(750, 530);

            ((System.ComponentModel.ISupportInitialize)(this.dgvTelur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
