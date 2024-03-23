namespace _0306221377_LeNguyenHoangThong
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstBox = new ListBox();
            btnClick = new Button();
            SuspendLayout();
            // 
            // lstBox
            // 
            lstBox.FormattingEnabled = true;
            lstBox.ItemHeight = 15;
            lstBox.Items.AddRange(new object[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" });
            lstBox.Location = new Point(243, 23);
            lstBox.Name = "lstBox";
            lstBox.Size = new Size(128, 139);
            lstBox.TabIndex = 0;
            // 
            // btnClick
            // 
            btnClick.Location = new Point(243, 168);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(128, 23);
            btnClick.TabIndex = 1;
            btnClick.Text = "Click Me";
            btnClick.UseVisualStyleBackColor = true;
            btnClick.Click += btnClick_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 355);
            Controls.Add(btnClick);
            Controls.Add(lstBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstBox;
        private Button btnClick;
    }
}