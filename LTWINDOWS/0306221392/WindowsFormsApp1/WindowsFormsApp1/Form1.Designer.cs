namespace WindowsFormsApp1
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
            this.grid_ketQua = new System.Windows.Forms.DataGridView();
            this.btn_sanPham = new System.Windows.Forms.Button();
            this.btn_nhaSanXuat = new System.Windows.Forms.Button();
            this.btn_lietkeSPgiaHon1trieu = new System.Windows.Forms.Button();
            this.btn_maxSanPham = new System.Windows.Forms.Button();
            this.btn_sanPhamMinDonGia = new System.Windows.Forms.Button();
            this.comBox_nhaSX = new System.Windows.Forms.ComboBox();
            this.btn_lietKeNSScomboBx = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ketQua)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_ketQua
            // 
            this.grid_ketQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_ketQua.Location = new System.Drawing.Point(9, 215);
            this.grid_ketQua.Name = "grid_ketQua";
            this.grid_ketQua.Size = new System.Drawing.Size(779, 150);
            this.grid_ketQua.TabIndex = 0;
            // 
            // btn_sanPham
            // 
            this.btn_sanPham.Location = new System.Drawing.Point(460, 79);
            this.btn_sanPham.Name = "btn_sanPham";
            this.btn_sanPham.Size = new System.Drawing.Size(131, 62);
            this.btn_sanPham.TabIndex = 1;
            this.btn_sanPham.Text = "Liệt kê sản phẩm";
            this.btn_sanPham.UseVisualStyleBackColor = true;
            this.btn_sanPham.Click += new System.EventHandler(this.btn_sanPham_Click);
            // 
            // btn_nhaSanXuat
            // 
            this.btn_nhaSanXuat.Location = new System.Drawing.Point(189, 79);
            this.btn_nhaSanXuat.Name = "btn_nhaSanXuat";
            this.btn_nhaSanXuat.Size = new System.Drawing.Size(131, 62);
            this.btn_nhaSanXuat.TabIndex = 2;
            this.btn_nhaSanXuat.Text = "Liệt kê nhà sản xuất";
            this.btn_nhaSanXuat.UseVisualStyleBackColor = true;
            this.btn_nhaSanXuat.Click += new System.EventHandler(this.btn_nhaSanXuat_Click);
            // 
            // btn_lietkeSPgiaHon1trieu
            // 
            this.btn_lietkeSPgiaHon1trieu.Location = new System.Drawing.Point(336, 147);
            this.btn_lietkeSPgiaHon1trieu.Name = "btn_lietkeSPgiaHon1trieu";
            this.btn_lietkeSPgiaHon1trieu.Size = new System.Drawing.Size(131, 62);
            this.btn_lietkeSPgiaHon1trieu.TabIndex = 3;
            this.btn_lietkeSPgiaHon1trieu.Text = "Liệt kê sản phẩm giá hơn 1000000";
            this.btn_lietkeSPgiaHon1trieu.UseVisualStyleBackColor = true;
            this.btn_lietkeSPgiaHon1trieu.Click += new System.EventHandler(this.btn_lietkeSPgiaHon1trieu_Click);
            // 
            // btn_maxSanPham
            // 
            this.btn_maxSanPham.Location = new System.Drawing.Point(31, 127);
            this.btn_maxSanPham.Name = "btn_maxSanPham";
            this.btn_maxSanPham.Size = new System.Drawing.Size(131, 62);
            this.btn_maxSanPham.TabIndex = 4;
            this.btn_maxSanPham.Text = "Liệt kê sản phẩm có số lượng nhiều nhất";
            this.btn_maxSanPham.UseVisualStyleBackColor = true;
            this.btn_maxSanPham.Click += new System.EventHandler(this.btn_maxSanPham_Click);
            // 
            // btn_sanPhamMinDonGia
            // 
            this.btn_sanPhamMinDonGia.Location = new System.Drawing.Point(325, 12);
            this.btn_sanPhamMinDonGia.Name = "btn_sanPhamMinDonGia";
            this.btn_sanPhamMinDonGia.Size = new System.Drawing.Size(131, 62);
            this.btn_sanPhamMinDonGia.TabIndex = 5;
            this.btn_sanPhamMinDonGia.Text = "Liệt kê sản phẩm có đơn giá thấp nhất";
            this.btn_sanPhamMinDonGia.UseVisualStyleBackColor = true;
            this.btn_sanPhamMinDonGia.Click += new System.EventHandler(this.btn_sanPhamMinDonGia_Click);
            // 
            // comBox_nhaSX
            // 
            this.comBox_nhaSX.FormattingEnabled = true;
            this.comBox_nhaSX.Location = new System.Drawing.Point(41, 12);
            this.comBox_nhaSX.Name = "comBox_nhaSX";
            this.comBox_nhaSX.Size = new System.Drawing.Size(121, 21);
            this.comBox_nhaSX.TabIndex = 6;
            this.comBox_nhaSX.SelectedIndexChanged += new System.EventHandler(this.comBox_nhaSX_SelectedIndexChanged);
            // 
            // btn_lietKeNSScomboBx
            // 
            this.btn_lietKeNSScomboBx.Location = new System.Drawing.Point(41, 39);
            this.btn_lietKeNSScomboBx.Name = "btn_lietKeNSScomboBx";
            this.btn_lietKeNSScomboBx.Size = new System.Drawing.Size(121, 57);
            this.btn_lietKeNSScomboBx.TabIndex = 7;
            this.btn_lietKeNSScomboBx.Text = "Liệt kê nhà sản xuất";
            this.btn_lietKeNSScomboBx.UseVisualStyleBackColor = true;
            this.btn_lietKeNSScomboBx.Click += new System.EventHandler(this.btn_lietKeNSScomboBx_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_lietKeNSScomboBx);
            this.Controls.Add(this.comBox_nhaSX);
            this.Controls.Add(this.btn_sanPhamMinDonGia);
            this.Controls.Add(this.btn_maxSanPham);
            this.Controls.Add(this.btn_lietkeSPgiaHon1trieu);
            this.Controls.Add(this.btn_nhaSanXuat);
            this.Controls.Add(this.btn_sanPham);
            this.Controls.Add(this.grid_ketQua);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_ketQua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_ketQua;
        private System.Windows.Forms.Button btn_sanPham;
        private System.Windows.Forms.Button btn_nhaSanXuat;
        private System.Windows.Forms.Button btn_lietkeSPgiaHon1trieu;
        private System.Windows.Forms.Button btn_maxSanPham;
        private System.Windows.Forms.Button btn_sanPhamMinDonGia;
        private System.Windows.Forms.ComboBox comBox_nhaSX;
        private System.Windows.Forms.Button btn_lietKeNSScomboBx;
    }
}

