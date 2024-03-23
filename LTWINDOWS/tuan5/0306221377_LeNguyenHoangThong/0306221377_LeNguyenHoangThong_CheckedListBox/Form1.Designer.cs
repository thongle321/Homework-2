namespace _0306221377_LeNguyenHoangThong_CheckedListBox
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
            chkListBox = new CheckedListBox();
            btnClick = new Button();
            SuspendLayout();
            // 
            // chkListBox
            // 
            chkListBox.FormattingEnabled = true;
            chkListBox.Items.AddRange(new object[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" });
            chkListBox.Location = new Point(218, 87);
            chkListBox.Name = "chkListBox";
            chkListBox.Size = new Size(248, 166);
            chkListBox.TabIndex = 0;
            // 
            // btnClick
            // 
            btnClick.Location = new Point(218, 276);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(248, 23);
            btnClick.TabIndex = 1;
            btnClick.Text = "Click Me";
            btnClick.UseVisualStyleBackColor = true;
            btnClick.Click += btnClick_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 450);
            Controls.Add(btnClick);
            Controls.Add(chkListBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox chkListBox;
        private Button btnClick;
    }
}