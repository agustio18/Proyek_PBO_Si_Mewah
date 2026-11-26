
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.FromArgb(53, 92, 69);
            this.lblJudul.Location = new System.Drawing.Point(24, 20);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(130, 41);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Data Telur";

            // lblPencarian
            this.lblPencarian.AutoSize = true;
            this.lblPencarian.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPencarian.ForeColor = System.Drawing.Color.FromArgb(48, 56, 50);
            this.lblPencarian.Location = new System.Drawing.Point(24, 70);
            this.lblPencarian.Name = "lblPencarian";
            this.lblPencarian.Size = new System.Drawing.Size(80, 21);
            this.lblPencarian.TabIndex = 1;
            this.lblPencarian.Text = "Cari data:";

            // txtPencarian
            this.txtPencarian.BackColor = System.Drawing.Color.White;
            this.txtPencarian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPencarian.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.txtPencarian.ForeColor = System.Drawing.Color.FromArgb(48, 56, 50);
            this.txtPencarian.Location = new System.Drawing.Point(24, 94);
            this.txtPencarian.Name = "txtPencarian";
            this.txtPencarian.Size = new System.Drawing.Size(260, 34);
            this.txtPencarian.TabIndex = 2;

            // btnCari
            this.btnCari.BackColor = System.Drawing.Color.FromArgb(53, 92, 69);
            this.btnCari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCari.FlatAppearance.BorderSize = 0;
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCari.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCari.ForeColor = System.Drawing.Color.White;
            this.btnCari.Location = new System.Drawing.Point(292, 92);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(100, 38);
            this.btnCari.TabIndex = 3;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = false;

            // btnTambah
            this.btnTambah.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnTambah.BackColor = System.Drawing.Color.FromArgb(53, 92, 69);
            this.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambah.FlatAppearance.BorderSize = 0;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(506, 92);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(180, 38);
            this.btnTambah.TabIndex = 4;
            this.btnTambah.Text = "Tambah Data";
            this.btnTambah.UseVisualStyleBackColor = false;

            // btnUbah
            this.btnUbah.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnUbah.BackColor = System.Drawing.Color.FromArgb(143, 175, 145);
            this.btnUbah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUbah.FlatAppearance.BorderSize = 0;
            this.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbah.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnUbah.ForeColor = System.Drawing.Color.FromArgb(48, 56, 50);
            this.btnUbah.Location = new System.Drawing.Point(696, 92);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(120, 38);
            this.btnUbah.TabIndex = 5;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = false;

            // dgvTelur
            this.dgvTelur.AllowUserToAddRows = false;
            this.dgvTelur.AllowUserToDeleteRows = false;
            this.dgvTelur.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom
                | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dgvTelur.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTelur.BackgroundColor = System.Drawing.Color.White;
            this.dgvTelur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(53, 92, 69);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(53, 92, 69);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTelur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTelur.ColumnHeadersHeight = 40;
            this.dgvTelur.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(48, 56, 50);
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(143, 175, 145);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(48, 56, 50);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTelur.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTelur.EnableHeadersVisualStyles = false;
            this.dgvTelur.GridColor = System.Drawing.Color.FromArgb(227, 231, 225);
            this.dgvTelur.Location = new System.Drawing.Point(24, 146);
            this.dgvTelur.Name = "dgvTelur";
            this.dgvTelur.ReadOnly = true;
            this.dgvTelur.RowHeadersVisible = false;
            this.dgvTelur.RowTemplate.Height = 36;
            this.dgvTelur.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTelur.MultiSelect = false;
            this.dgvTelur.Size = new System.Drawing.Size(792, 415);
            this.dgvTelur.TabIndex = 6;

            // UcTelur
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(247, 245, 237);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.lblPencarian);
            this.Controls.Add(this.txtPencarian);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.dgvTelur);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.Name = "UcTelur";
            this.Size = new System.Drawing.Size(840, 585);

            ((System.ComponentModel.ISupportInitialize)(this.dgvTelur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
