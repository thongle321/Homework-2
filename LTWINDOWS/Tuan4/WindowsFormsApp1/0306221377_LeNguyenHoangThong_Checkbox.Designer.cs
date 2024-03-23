namespace WindowsFormsApp1
{
    partial class _0306221377_Checkbox
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
            this.chkPhim = new System.Windows.Forms.CheckBox();
            this.chkNhac = new System.Windows.Forms.CheckBox();
            this.chkSach = new System.Windows.Forms.CheckBox();
            this.chkBong = new System.Windows.Forms.CheckBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBong);
            this.groupBox1.Controls.Add(this.chkSach);
            this.groupBox1.Controls.Add(this.chkNhac);
            this.groupBox1.Controls.Add(this.chkPhim);
            this.groupBox1.Location = new System.Drawing.Point(248, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sở thích";
            // 
            // chkPhim
            // 
            this.chkPhim.AutoSize = true;
            this.chkPhim.Location = new System.Drawing.Point(20, 37);
            this.chkPhim.Name = "chkPhim";
            this.chkPhim.Size = new System.Drawing.Size(72, 17);
            this.chkPhim.TabIndex = 0;
            this.chkPhim.Text = "Xem phim";
            this.chkPhim.UseVisualStyleBackColor = true;
            // 
            // chkNhac
            // 
            this.chkNhac.AutoSize = true;
            this.chkNhac.Location = new System.Drawing.Point(20, 60);
            this.chkNhac.Name = "chkNhac";
            this.chkNhac.Size = new System.Drawing.Size(79, 17);
            this.chkNhac.TabIndex = 1;
            this.chkNhac.Text = "Nghe nhạc";
            this.chkNhac.UseVisualStyleBackColor = true;
            // 
            // chkSach
            // 
            this.chkSach.AutoSize = true;
            this.chkSach.Location = new System.Drawing.Point(20, 83);
            this.chkSach.Name = "chkSach";
            this.chkSach.Size = new System.Drawing.Size(72, 17);
            this.chkSach.TabIndex = 1;
            this.chkSach.Text = "Đọc sách";
            this.chkSach.UseVisualStyleBackColor = true;
            // 
            // chkBong
            // 
            this.chkBong.AutoSize = true;
            this.chkBong.Location = new System.Drawing.Point(20, 106);
            this.chkBong.Name = "chkBong";
            this.chkBong.Size = new System.Drawing.Size(67, 17);
            this.chkBong.TabIndex = 2;
            this.chkBong.Text = "Đá bóng";
            this.chkBong.UseVisualStyleBackColor = true;
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(310, 277);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 23);
            this.btnClick.TabIndex = 3;
            this.btnClick.Text = "Click Me";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // _0306221377_Checkbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.groupBox1);
            this.Name = "_0306221377_Checkbox";
            this.Text = "_0306221377_Checkbox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkBong;
        private System.Windows.Forms.CheckBox chkSach;
        private System.Windows.Forms.CheckBox chkNhac;
        private System.Windows.Forms.CheckBox chkPhim;
        private System.Windows.Forms.Button btnClick;
    }
}