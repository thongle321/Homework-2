namespace _0306221377_LeNguyenHoangThong
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
            this.grid_DSHocSinh = new System.Windows.Forms.DataGridView();
            this.btn_XemDSHS = new System.Windows.Forms.Button();
            this.btn_XemDSHSNu = new System.Windows.Forms.Button();
            this.btn_XemDSHSDat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DSHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_DSHocSinh
            // 
            this.grid_DSHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_DSHocSinh.Location = new System.Drawing.Point(12, 176);
            this.grid_DSHocSinh.Name = "grid_DSHocSinh";
            this.grid_DSHocSinh.Size = new System.Drawing.Size(776, 262);
            this.grid_DSHocSinh.TabIndex = 0;
            // 
            // btn_XemDSHS
            // 
            this.btn_XemDSHS.Location = new System.Drawing.Point(12, 74);
            this.btn_XemDSHS.Name = "btn_XemDSHS";
            this.btn_XemDSHS.Size = new System.Drawing.Size(108, 23);
            this.btn_XemDSHS.TabIndex = 1;
            this.btn_XemDSHS.Text = "Xem DSHS";
            this.btn_XemDSHS.UseVisualStyleBackColor = true;
            this.btn_XemDSHS.Click += new System.EventHandler(this.btn_XemDSHS_Click);
            // 
            // btn_XemDSHSNu
            // 
            this.btn_XemDSHSNu.Location = new System.Drawing.Point(141, 74);
            this.btn_XemDSHSNu.Name = "btn_XemDSHSNu";
            this.btn_XemDSHSNu.Size = new System.Drawing.Size(116, 23);
            this.btn_XemDSHSNu.TabIndex = 2;
            this.btn_XemDSHSNu.Text = "XemDSHSNữ";
            this.btn_XemDSHSNu.UseVisualStyleBackColor = true;
            this.btn_XemDSHSNu.Click += new System.EventHandler(this.btn_XemDSHSNu_Click);
            // 
            // btn_XemDSHSDat
            // 
            this.btn_XemDSHSDat.Location = new System.Drawing.Point(277, 74);
            this.btn_XemDSHSDat.Name = "btn_XemDSHSDat";
            this.btn_XemDSHSDat.Size = new System.Drawing.Size(131, 23);
            this.btn_XemDSHSDat.TabIndex = 3;
            this.btn_XemDSHSDat.Text = "Xem DSHSĐạt";
            this.btn_XemDSHSDat.UseVisualStyleBackColor = true;
            this.btn_XemDSHSDat.Click += new System.EventHandler(this.btn_XemDSHSDat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_XemDSHSDat);
            this.Controls.Add(this.btn_XemDSHSNu);
            this.Controls.Add(this.btn_XemDSHS);
            this.Controls.Add(this.grid_DSHocSinh);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grid_DSHocSinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_DSHocSinh;
        private System.Windows.Forms.Button btn_XemDSHS;
        private System.Windows.Forms.Button btn_XemDSHSNu;
        private System.Windows.Forms.Button btn_XemDSHSDat;
    }
}

