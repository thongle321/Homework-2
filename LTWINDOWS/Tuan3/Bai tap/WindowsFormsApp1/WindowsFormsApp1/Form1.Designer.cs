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
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.chkMovie = new System.Windows.Forms.CheckBox();
            this.chkMusic = new System.Windows.Forms.CheckBox();
            this.chkRead = new System.Windows.Forms.CheckBox();
            this.chkSoccer = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(177, 48);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(161, 20);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoTen_KeyPress);
            // 
            // chkMovie
            // 
            this.chkMovie.AutoSize = true;
            this.chkMovie.Location = new System.Drawing.Point(23, 27);
            this.chkMovie.Name = "chkMovie";
            this.chkMovie.Size = new System.Drawing.Size(89, 17);
            this.chkMovie.TabIndex = 3;
            this.chkMovie.Text = "Watch movie";
            this.chkMovie.UseVisualStyleBackColor = true;
            // 
            // chkMusic
            // 
            this.chkMusic.AutoSize = true;
            this.chkMusic.Location = new System.Drawing.Point(23, 50);
            this.chkMusic.Name = "chkMusic";
            this.chkMusic.Size = new System.Drawing.Size(96, 17);
            this.chkMusic.TabIndex = 4;
            this.chkMusic.Text = "Listen to music";
            this.chkMusic.UseVisualStyleBackColor = true;
            // 
            // chkRead
            // 
            this.chkRead.AutoSize = true;
            this.chkRead.Location = new System.Drawing.Point(23, 73);
            this.chkRead.Name = "chkRead";
            this.chkRead.Size = new System.Drawing.Size(79, 17);
            this.chkRead.TabIndex = 5;
            this.chkRead.Text = "Read book";
            this.chkRead.UseVisualStyleBackColor = true;
            // 
            // chkSoccer
            // 
            this.chkSoccer.AutoSize = true;
            this.chkSoccer.Location = new System.Drawing.Point(23, 96);
            this.chkSoccer.Name = "chkSoccer";
            this.chkSoccer.Size = new System.Drawing.Size(81, 17);
            this.chkSoccer.TabIndex = 6;
            this.chkSoccer.Text = "Play soccer";
            this.chkSoccer.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(161, 222);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(262, 222);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(76, 23);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkMovie);
            this.groupBox1.Controls.Add(this.chkMusic);
            this.groupBox1.Controls.Add(this.chkRead);
            this.groupBox1.Controls.Add(this.chkSoccer);
            this.groupBox1.Location = new System.Drawing.Point(117, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 119);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hobby";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 347);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.CheckBox chkMovie;
        private System.Windows.Forms.CheckBox chkMusic;
        private System.Windows.Forms.CheckBox chkRead;
        private System.Windows.Forms.CheckBox chkSoccer;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

