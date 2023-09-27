namespace AplikasiInputDataMahasiswa
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nim = new System.Windows.Forms.Label();
            this.Nama = new System.Windows.Forms.Label();
            this.Kelas = new System.Windows.Forms.Label();
            this.Nilai = new System.Windows.Forms.Label();
            this.txtNim = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtKelas = new System.Windows.Forms.TextBox();
            this.txtNilai = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnTampilkanData = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwMahasiswa = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nim
            // 
            this.Nim.AutoSize = true;
            this.Nim.Location = new System.Drawing.Point(17, 24);
            this.Nim.Name = "Nim";
            this.Nim.Size = new System.Drawing.Size(25, 13);
            this.Nim.TabIndex = 1;
            this.Nim.Text = "Nim";
            // 
            // Nama
            // 
            this.Nama.AutoSize = true;
            this.Nama.Location = new System.Drawing.Point(17, 51);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(35, 13);
            this.Nama.TabIndex = 2;
            this.Nama.Text = "Nama";
            // 
            // Kelas
            // 
            this.Kelas.AutoSize = true;
            this.Kelas.Location = new System.Drawing.Point(17, 78);
            this.Kelas.Name = "Kelas";
            this.Kelas.Size = new System.Drawing.Size(33, 13);
            this.Kelas.TabIndex = 3;
            this.Kelas.Text = "Kelas";
            // 
            // Nilai
            // 
            this.Nilai.AutoSize = true;
            this.Nilai.Location = new System.Drawing.Point(17, 104);
            this.Nilai.Name = "Nilai";
            this.Nilai.Size = new System.Drawing.Size(27, 13);
            this.Nilai.TabIndex = 4;
            this.Nilai.Text = "Nilai";
            // 
            // txtNim
            // 
            this.txtNim.Location = new System.Drawing.Point(89, 24);
            this.txtNim.Name = "txtNim";
            this.txtNim.Size = new System.Drawing.Size(100, 20);
            this.txtNim.TabIndex = 5;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(89, 51);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(157, 20);
            this.txtNama.TabIndex = 6;
            // 
            // txtKelas
            // 
            this.txtKelas.Location = new System.Drawing.Point(89, 78);
            this.txtKelas.Name = "txtKelas";
            this.txtKelas.Size = new System.Drawing.Size(100, 20);
            this.txtKelas.TabIndex = 7;
            // 
            // txtNilai
            // 
            this.txtNilai.Location = new System.Drawing.Point(89, 104);
            this.txtNilai.Name = "txtNilai";
            this.txtNilai.Size = new System.Drawing.Size(100, 20);
            this.txtNilai.TabIndex = 8;
            this.txtNilai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNilai_KeyPress);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(89, 145);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 9;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(188, 144);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnTampilkanData
            // 
            this.btnTampilkanData.Location = new System.Drawing.Point(10, 27);
            this.btnTampilkanData.Name = "btnTampilkanData";
            this.btnTampilkanData.Size = new System.Drawing.Size(96, 23);
            this.btnTampilkanData.TabIndex = 11;
            this.btnTampilkanData.Text = "Tampilkan Data";
            this.btnTampilkanData.UseVisualStyleBackColor = true;
            this.btnTampilkanData.Click += new System.EventHandler(this.btnTampilkanData_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(112, 27);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(91, 23);
            this.btnHapus.TabIndex = 12;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwMahasiswa);
            this.groupBox1.Controls.Add(this.btnHapus);
            this.groupBox1.Controls.Add(this.btnTampilkanData);
            this.groupBox1.Location = new System.Drawing.Point(303, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 389);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[ Daftar Mahasiswa ]";
            // 
            // lvwMahasiswa
            // 
            this.lvwMahasiswa.HideSelection = false;
            this.lvwMahasiswa.Location = new System.Drawing.Point(6, 56);
            this.lvwMahasiswa.Name = "lvwMahasiswa";
            this.lvwMahasiswa.Size = new System.Drawing.Size(458, 314);
            this.lvwMahasiswa.TabIndex = 13;
            this.lvwMahasiswa.UseCompatibleStateImageBehavior = false;
            this.lvwMahasiswa.SelectedIndexChanged += new System.EventHandler(this.lvwMahasiswa_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtNilai);
            this.Controls.Add(this.txtKelas);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNim);
            this.Controls.Add(this.Nilai);
            this.Controls.Add(this.Kelas);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.Nim);
            this.Name = "Form1";
            this.Text = "AplikasiInputDataMahasiswa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nim;
        private System.Windows.Forms.Label Nama;
        private System.Windows.Forms.Label Kelas;
        private System.Windows.Forms.Label Nilai;
        private System.Windows.Forms.TextBox txtNim;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtKelas;
        private System.Windows.Forms.TextBox txtNilai;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnTampilkanData;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwMahasiswa;
    }
}

