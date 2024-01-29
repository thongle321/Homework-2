namespace WindowsFormsApp1
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.radP = new System.Windows.Forms.RadioButton();
            this.radM = new System.Windows.Forms.RadioButton();
            this.radMu = new System.Windows.Forms.RadioButton();
            this.radD = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Number";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(172, 57);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(218, 20);
            this.txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(172, 89);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(218, 20);
            this.txtNum2.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(215, 166);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(118, 166);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 23);
            this.btnCal.TabIndex = 9;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // radP
            // 
            this.radP.AutoSize = true;
            this.radP.Location = new System.Drawing.Point(82, 129);
            this.radP.Name = "radP";
            this.radP.Size = new System.Drawing.Size(45, 17);
            this.radP.TabIndex = 10;
            this.radP.TabStop = true;
            this.radP.Text = "Plus";
            this.radP.UseVisualStyleBackColor = true;
            // 
            // radM
            // 
            this.radM.AutoSize = true;
            this.radM.Location = new System.Drawing.Point(163, 129);
            this.radM.Name = "radM";
            this.radM.Size = new System.Drawing.Size(53, 17);
            this.radM.TabIndex = 11;
            this.radM.TabStop = true;
            this.radM.Text = "Minus";
            this.radM.UseVisualStyleBackColor = true;
            // 
            // radMu
            // 
            this.radMu.AutoSize = true;
            this.radMu.Location = new System.Drawing.Point(245, 129);
            this.radMu.Name = "radMu";
            this.radMu.Size = new System.Drawing.Size(60, 17);
            this.radMu.TabIndex = 12;
            this.radMu.TabStop = true;
            this.radMu.Text = "Multiply";
            this.radMu.UseVisualStyleBackColor = true;
            // 
            // radD
            // 
            this.radD.AutoSize = true;
            this.radD.Location = new System.Drawing.Point(335, 129);
            this.radD.Name = "radD";
            this.radD.Size = new System.Drawing.Size(55, 17);
            this.radD.TabIndex = 13;
            this.radD.TabStop = true;
            this.radD.Text = "Divide";
            this.radD.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radD);
            this.Controls.Add(this.radMu);
            this.Controls.Add(this.radM);
            this.Controls.Add(this.radP);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.RadioButton radP;
        private System.Windows.Forms.RadioButton radM;
        private System.Windows.Forms.RadioButton radMu;
        private System.Windows.Forms.RadioButton radD;
    }
}