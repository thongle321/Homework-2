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
            dtp_Ngay = new DateTimePicker();
            btn_Show = new Button();
            SuspendLayout();
            // 
            // dtp_Ngay
            // 
            dtp_Ngay.CustomFormat = "'Ngày' dd 'tháng' MM 'năm' yyyy";
            dtp_Ngay.Format = DateTimePickerFormat.Custom;
            dtp_Ngay.Location = new Point(235, 158);
            dtp_Ngay.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtp_Ngay.Name = "dtp_Ngay";
            dtp_Ngay.Size = new Size(200, 23);
            dtp_Ngay.TabIndex = 0;
            // 
            // btn_Show
            // 
            btn_Show.Location = new Point(235, 218);
            btn_Show.Name = "btn_Show";
            btn_Show.Size = new Size(200, 23);
            btn_Show.TabIndex = 1;
            btn_Show.Text = "Hiển Thị";
            btn_Show.UseVisualStyleBackColor = true;
            btn_Show.Click += btn_Show_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Show);
            Controls.Add(dtp_Ngay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtp_Ngay;
        private Button btn_Show;
    }
}
