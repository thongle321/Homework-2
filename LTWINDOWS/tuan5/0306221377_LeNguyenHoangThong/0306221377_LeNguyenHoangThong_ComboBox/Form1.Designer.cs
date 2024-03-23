namespace _0306221377_LeNguyenHoangThong_ComboBox
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
            cb = new ComboBox();
            btnClick = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // cb
            // 
            cb.FormattingEnabled = true;
            cb.Items.AddRange(new object[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" });
            cb.Location = new Point(214, 158);
            cb.Name = "cb";
            cb.Size = new Size(243, 23);
            cb.TabIndex = 0;
            cb.SelectedIndexChanged += cb_SelectedIndexChanged;
            // 
            // btnClick
            // 
            btnClick.Location = new Point(214, 197);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(243, 23);
            btnClick.TabIndex = 1;
            btnClick.Text = "Click Me";
            btnClick.UseVisualStyleBackColor = true;
            btnClick.Click += btnClick_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(214, 226);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(243, 23);
            btnClear.TabIndex = 2;
            btnClear.Text = "Remove";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 363);
            Controls.Add(btnClear);
            Controls.Add(btnClick);
            Controls.Add(cb);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cb;
        private Button btnClick;
        private Button btnClear;
    }
}