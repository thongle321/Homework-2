namespace WindowsFormsApp1
{
    partial class _0306221377_ListBox
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
            this.lstThu = new System.Windows.Forms.ListBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstThu
            // 
            this.lstThu.FormattingEnabled = true;
            this.lstThu.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.lstThu.Location = new System.Drawing.Point(198, 81);
            this.lstThu.Name = "lstThu";
            this.lstThu.Size = new System.Drawing.Size(120, 160);
            this.lstThu.TabIndex = 0;
            this.lstThu.SelectedIndexChanged += new System.EventHandler(this.lstThu_SelectedIndexChanged);
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(240, 269);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(179, 46);
            this.btnClick.TabIndex = 1;
            this.btnClick.Text = "Click Me";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // _0306221377_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.lstThu);
            this.Name = "_0306221377_ListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_0306221377_ListBox";
            this.Load += new System.EventHandler(this._0306221377_ListBox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstThu;
        private System.Windows.Forms.Button btnClick;
    }
}