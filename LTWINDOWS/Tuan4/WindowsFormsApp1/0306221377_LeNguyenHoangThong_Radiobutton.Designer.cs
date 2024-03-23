namespace WindowsFormsApp1
{
    partial class _0306221377_Radiobutton
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
            this.radXanh = new System.Windows.Forms.RadioButton();
            this.radVang = new System.Windows.Forms.RadioButton();
            this.radDo = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radXanh);
            this.groupBox1.Controls.Add(this.radVang);
            this.groupBox1.Controls.Add(this.radDo);
            this.groupBox1.Location = new System.Drawing.Point(180, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn màu";
            // 
            // radXanh
            // 
            this.radXanh.AutoSize = true;
            this.radXanh.Location = new System.Drawing.Point(6, 65);
            this.radXanh.Name = "radXanh";
            this.radXanh.Size = new System.Drawing.Size(50, 17);
            this.radXanh.TabIndex = 2;
            this.radXanh.TabStop = true;
            this.radXanh.Text = "Xanh";
            this.radXanh.UseVisualStyleBackColor = true;
            // 
            // radVang
            // 
            this.radVang.AutoSize = true;
            this.radVang.Location = new System.Drawing.Point(6, 42);
            this.radVang.Name = "radVang";
            this.radVang.Size = new System.Drawing.Size(50, 17);
            this.radVang.TabIndex = 1;
            this.radVang.TabStop = true;
            this.radVang.Text = "Vàng";
            this.radVang.UseVisualStyleBackColor = true;
            // 
            // radDo
            // 
            this.radDo.AutoSize = true;
            this.radDo.Location = new System.Drawing.Point(6, 19);
            this.radDo.Name = "radDo";
            this.radDo.Size = new System.Drawing.Size(39, 17);
            this.radDo.TabIndex = 0;
            this.radDo.TabStop = true;
            this.radDo.Text = "Đỏ";
            this.radDo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Click Me";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _0306221377_Radiobutton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 307);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "_0306221377_Radiobutton";
            this.Text = "_0306221377_Radiobutton";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radXanh;
        private System.Windows.Forms.RadioButton radVang;
        private System.Windows.Forms.RadioButton radDo;
        private System.Windows.Forms.Button button1;
    }
}