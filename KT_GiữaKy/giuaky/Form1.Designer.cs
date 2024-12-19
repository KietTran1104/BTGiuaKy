namespace giuaky
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbblop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtmssv = new System.Windows.Forms.TextBox();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btnLuuDoiChung = new System.Windows.Forms.Button();
            this.btnKluu = new System.Windows.Forms.Button();
            this.Them = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.cbbNgaySinh = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbNgaySinh);
            this.groupBox1.Controls.Add(this.cbblop);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.txtmssv);
            this.groupBox1.Location = new System.Drawing.Point(195, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý sinh viên";
            // 
            // cbblop
            // 
            this.cbblop.FormattingEnabled = true;
            this.cbblop.Location = new System.Drawing.Point(453, 102);
            this.cbblop.Name = "cbblop";
            this.cbblop.Size = new System.Drawing.Size(154, 28);
            this.cbblop.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Lớp học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày Sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Sinh Viên";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(453, 36);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(121, 26);
            this.txtHoten.TabIndex = 0;
            // 
            // txtmssv
            // 
            this.txtmssv.Location = new System.Drawing.Point(143, 37);
            this.txtmssv.Name = "txtmssv";
            this.txtmssv.Size = new System.Drawing.Size(122, 26);
            this.txtmssv.TabIndex = 0;
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location = new System.Drawing.Point(101, 326);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersWidth = 62;
            this.dgvSinhVien.RowTemplate.Height = 28;
            this.dgvSinhVien.Size = new System.Drawing.Size(831, 150);
            this.dgvSinhVien.TabIndex = 1;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(240, 249);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 51);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(454, 249);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 51);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(561, 249);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 51);
            this.btsua.TabIndex = 3;
            this.btsua.Text = "sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btnLuuDoiChung
            // 
            this.btnLuuDoiChung.Location = new System.Drawing.Point(668, 249);
            this.btnLuuDoiChung.Name = "btnLuuDoiChung";
            this.btnLuuDoiChung.Size = new System.Drawing.Size(75, 51);
            this.btnLuuDoiChung.TabIndex = 3;
            this.btnLuuDoiChung.Text = "Lưu";
            this.btnLuuDoiChung.UseVisualStyleBackColor = true;
            this.btnLuuDoiChung.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnKluu
            // 
            this.btnKluu.Location = new System.Drawing.Point(775, 249);
            this.btnKluu.Name = "btnKluu";
            this.btnKluu.Size = new System.Drawing.Size(75, 51);
            this.btnKluu.TabIndex = 3;
            this.btnKluu.Text = "K.Lưu";
            this.btnKluu.UseVisualStyleBackColor = true;
            // 
            // Them
            // 
            this.Them.Location = new System.Drawing.Point(347, 249);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(75, 51);
            this.Them.TabIndex = 3;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = true;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(882, 249);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 51);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // cbbNgaySinh
            // 
            this.cbbNgaySinh.Location = new System.Drawing.Point(143, 109);
            this.cbbNgaySinh.Name = "cbbNgaySinh";
            this.cbbNgaySinh.Size = new System.Drawing.Size(100, 26);
            this.cbbNgaySinh.TabIndex = 4;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(12, 249);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(209, 26);
            this.txtTimKiem.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 552);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.btnKluu);
            this.Controls.Add(this.btnLuuDoiChung);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.ComboBox cbblop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtmssv;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btnLuuDoiChung;
        private System.Windows.Forms.Button btnKluu;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox cbbNgaySinh;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}

