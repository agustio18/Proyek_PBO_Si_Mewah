
namespace SiMewah.Views.Burung
{
    partial class UcBurung
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblPencarian;
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
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblPencarian = new System.Windows.Forms.Label();
            this.txtPencarian = new System.Windows.Forms.TextBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.dgvBurung = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvBurung)).BeginInit();
            this.SuspendLayout();

            // lblJudul
            this.lblJudul.AutoSize = true;
            this.lblJudul.Location = new System.Drawing.Point(20, 20);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(80, 15);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Data Burung";

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
            this.btnTambah.Text = "Tambah Burung";
            this.btnTambah.UseVisualStyleBackColor = true;

            // btnUbah
            this.btnUbah.Location = new System.Drawing.Point(150, 110);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(80, 30);
            this.btnUbah.TabIndex = 5;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;

            // dgvBurung
            this.dgvBurung.AllowUserToAddRows = false;
            this.dgvBurung.AllowUserToDeleteRows = false;
            this.dgvBurung.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBurung.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBurung.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    new System.Windows.Forms.DataGridViewTextBoxColumn()
                    {
                        Name = "colKode",
                        HeaderText = "Kode Burung"
                    },
                    new System.Windows.Forms.DataGridViewTextBoxColumn()
                    {
                        Name = "colJenisKelamin",
                        HeaderText = "Jenis Kelamin"
                    },
                    new System.Windows.Forms.DataGridViewTextBoxColumn()
                    {
                        Name = "colTanggalLahir",
                        HeaderText = "Tanggal Lahir"
                    },
                    new System.Windows.Forms.DataGridViewTextBoxColumn()
                    {
                        Name = "colStatus",
                        HeaderText = "Status"
                    },
                    new System.Windows.Forms.DataGridViewTextBoxColumn()
                    {
                        Name = "colKandang",
                        HeaderText = "Kandang"
                    },
                    new System.Windows.Forms.DataGridViewTextBoxColumn()
                    {
                        Name = "colId",
                        HeaderText = "ID Burung",
                        Visible = false
                    }
                });
            this.dgvBurung.Location = new System.Drawing.Point(20, 160);
            this.dgvBurung.Name = "dgvBurung";
            this.dgvBurung.ReadOnly = true;
            this.dgvBurung.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBurung.MultiSelect = false;
            this.dgvBurung.Size = new System.Drawing.Size(820, 350);
            this.dgvBurung.Anchor = System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Left
                | System.Windows.Forms.AnchorStyles.Right
                | System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvBurung.TabIndex = 6;

            // UcBurung
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.lblPencarian);
            this.Controls.Add(this.txtPencarian);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.dgvBurung);
            this.Name = "UcBurung";
            this.Size = new System.Drawing.Size(870, 530);

            ((System.ComponentModel.ISupportInitialize)(this.dgvBurung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
