namespace _0306221377_LeNguyenHoangThong
{
    partial class frmCapNhatSanPham
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_NhaSanXuat = new System.Windows.Forms.ComboBox();
            this.dt_NgaySanXuat = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.txt_TenSP = new System.Windows.Forms.TextBox();
            this.txt_MaSanPham = new System.Windows.Forms.TextBox();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.grid_DanhSach = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "CẬP NHẬT SẢN PHẨM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sản phẩm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đơn giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sản phẩm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã nhà sản xuất:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_NhaSanXuat);
            this.groupBox1.Controls.Add(this.dt_NgaySanXuat);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_SoLuong);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_DonGia);
            this.groupBox1.Controls.Add(this.txt_TenSP);
            this.groupBox1.Controls.Add(this.txt_MaSanPham);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(63, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 256);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // cbb_NhaSanXuat
            // 
            this.cbb_NhaSanXuat.FormattingEnabled = true;
            this.cbb_NhaSanXuat.Location = new System.Drawing.Point(168, 97);
            this.cbb_NhaSanXuat.Name = "cbb_NhaSanXuat";
            this.cbb_NhaSanXuat.Size = new System.Drawing.Size(250, 21);
            this.cbb_NhaSanXuat.TabIndex = 14;
            // 
            // dt_NgaySanXuat
            // 
            this.dt_NgaySanXuat.CustomFormat = "dd/MM/yy";
            this.dt_NgaySanXuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_NgaySanXuat.Location = new System.Drawing.Point(168, 203);
            this.dt_NgaySanXuat.Name = "dt_NgaySanXuat";
            this.dt_NgaySanXuat.Size = new System.Drawing.Size(250, 20);
            this.dt_NgaySanXuat.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ngày sản xuất:";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(168, 168);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(250, 20);
            this.txt_SoLuong.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số lượng:";
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Location = new System.Drawing.Point(168, 132);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(250, 20);
            this.txt_DonGia.TabIndex = 8;
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.Location = new System.Drawing.Point(168, 65);
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.Size = new System.Drawing.Size(250, 20);
            this.txt_TenSP.TabIndex = 6;
            // 
            // txt_MaSanPham
            // 
            this.txt_MaSanPham.Location = new System.Drawing.Point(168, 27);
            this.txt_MaSanPham.Name = "txt_MaSanPham";
            this.txt_MaSanPham.Size = new System.Drawing.Size(250, 20);
            this.txt_MaSanPham.TabIndex = 5;
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Location = new System.Drawing.Point(272, 327);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(113, 35);
            this.btn_CapNhat.TabIndex = 18;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = true;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // grid_DanhSach
            // 
            this.grid_DanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_DanhSach.Location = new System.Drawing.Point(12, 392);
            this.grid_DanhSach.Name = "grid_DanhSach";
            this.grid_DanhSach.ReadOnly = true;
            this.grid_DanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_DanhSach.Size = new System.Drawing.Size(618, 150);
            this.grid_DanhSach.TabIndex = 19;
            this.grid_DanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_DanhSach_CellClick);
            // 
            // frmCapNhatSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 576);
            this.Controls.Add(this.grid_DanhSach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_CapNhat);
            this.Name = "frmCapNhatSanPham";
            this.Text = "frmCapNhatSanPham";
            this.Load += new System.EventHandler(this.frmCapNhatSanPham_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbb_NhaSanXuat;
        private System.Windows.Forms.DateTimePicker dt_NgaySanXuat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.TextBox txt_TenSP;
        private System.Windows.Forms.TextBox txt_MaSanPham;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.DataGridView grid_DanhSach;
    }
}