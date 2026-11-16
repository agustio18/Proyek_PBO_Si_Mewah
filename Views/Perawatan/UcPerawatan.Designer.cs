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
            lblJudul = new System.Windows.Forms.Label();
            lblPencarian = new System.Windows.Forms.Label();
            txtPencarian = new System.Windows.Forms.TextBox();
            btnCari = new System.Windows.Forms.Button();
            btnTambah = new System.Windows.Forms.Button();
            btnUbah = new System.Windows.Forms.Button();
            btnHapus = new System.Windows.Forms.Button();
            dgvPerawatan = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)dgvPerawatan).BeginInit();
            SuspendLayout();

            lblJudul.AutoSize = true;
            lblJudul.Font = new System.Drawing.Font(
                "Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblJudul.Location = new System.Drawing.Point(20, 20);
            lblJudul.Name = "lblJudul";
            lblJudul.Text = "Data Perawatan";

            lblPencarian.AutoSize = true;
            lblPencarian.Location = new System.Drawing.Point(20, 65);
            lblPencarian.Name = "lblPencarian";
            lblPencarian.Text = "Cari data:";

            txtPencarian.Location = new System.Drawing.Point(100, 62);
            txtPencarian.Name = "txtPencarian";
            txtPencarian.Size = new System.Drawing.Size(220, 23);

            btnCari.Location = new System.Drawing.Point(330, 60);
            btnCari.Name = "btnCari";
            btnCari.Size = new System.Drawing.Size(80, 27);
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = true;

            btnTambah.Location = new System.Drawing.Point(20, 110);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new System.Drawing.Size(130, 30);
            btnTambah.Text = "Tambah Perawatan";
            btnTambah.UseVisualStyleBackColor = true;

            btnUbah.Location = new System.Drawing.Point(160, 110);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new System.Drawing.Size(80, 30);
            btnUbah.Text = "Ubah";
            btnUbah.UseVisualStyleBackColor = true;

            btnHapus.Location = new System.Drawing.Point(250, 110);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new System.Drawing.Size(80, 30);
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;

            dgvPerawatan.AllowUserToAddRows = false;
            dgvPerawatan.AllowUserToDeleteRows = false;
            dgvPerawatan.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvPerawatan.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dgvPerawatan.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    new System.Windows.Forms.DataGridViewTextBoxColumn()
                    {
                        Name = "colKodeBurung",
                        HeaderText = "Kode Burung"
                    },
                    new System.Windows.Forms.DataGridViewTextBoxColumn()
                    {
                        Name = "colJenisPerawatan",
                        HeaderText = "Jenis Perawatan"
                    },
                    new System.Windows.Forms.DataGridViewTextBoxColumn()
                    {
                        Name = "colTanggal",
                        HeaderText = "Tanggal"
                    },
                    new System.Windows.Forms.DataGridViewTextBoxColumn()
                    {
                        Name = "colJumlah",
                        HeaderText = "Jumlah"
                    },
                    new System.Windows.Forms.DataGridViewTextBoxColumn()
                    {
                        Name = "colId",
                        HeaderText = "ID Perawatan",
                        Visible = false
                    }
                });

            dgvPerawatan.Location = new System.Drawing.Point(20, 160);
            dgvPerawatan.Name = "dgvPerawatan";
            dgvPerawatan.ReadOnly = true;
            dgvPerawatan.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvPerawatan.MultiSelect = false;
            dgvPerawatan.Size = new System.Drawing.Size(820, 350);
            dgvPerawatan.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right |
                System.Windows.Forms.AnchorStyles.Bottom;

            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(870, 530);

            Controls.Add(lblJudul);
            Controls.Add(lblPencarian);
            Controls.Add(txtPencarian);
            Controls.Add(btnCari);
            Controls.Add(btnTambah);
            Controls.Add(btnUbah);
            Controls.Add(btnHapus);
            Controls.Add(dgvPerawatan);

            Name = "UcPerawatan";
            StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Data Perawatan";

            ((System.ComponentModel.ISupportInitialize)dgvPerawatan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
