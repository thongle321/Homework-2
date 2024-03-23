namespace _0306221377_LeNguyenHoangThong_QuanLyTaiKhoan
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            btn_Reload = new Button();
            imageList1 = new ImageList(components);
            btn_Remove = new Button();
            btn_Edit = new Button();
            btn_Add = new Button();
            chk_TT = new CheckBox();
            rd_GTnu = new RadioButton();
            rd_GTnam = new RadioButton();
            dtp_Ngay = new DateTimePicker();
            txt_HoTen = new TextBox();
            txt_TaiKhoan = new TextBox();
            lbl_TT = new Label();
            lbl_GT = new Label();
            lbl_NS = new Label();
            lbl_HT = new Label();
            lbl_TK = new Label();
            lv_Account = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Reload);
            groupBox1.Controls.Add(btn_Remove);
            groupBox1.Controls.Add(btn_Edit);
            groupBox1.Controls.Add(btn_Add);
            groupBox1.Controls.Add(chk_TT);
            groupBox1.Controls.Add(rd_GTnu);
            groupBox1.Controls.Add(rd_GTnam);
            groupBox1.Controls.Add(dtp_Ngay);
            groupBox1.Controls.Add(txt_HoTen);
            groupBox1.Controls.Add(txt_TaiKhoan);
            groupBox1.Controls.Add(lbl_TT);
            groupBox1.Controls.Add(lbl_GT);
            groupBox1.Controls.Add(lbl_NS);
            groupBox1.Controls.Add(lbl_HT);
            groupBox1.Controls.Add(lbl_TK);
            groupBox1.Location = new Point(12, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(587, 236);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiết";
            // 
            // btn_Reload
            // 
            btn_Reload.ImageIndex = 0;
            btn_Reload.ImageList = imageList1;
            btn_Reload.Location = new Point(495, 145);
            btn_Reload.Name = "btn_Reload";
            btn_Reload.Size = new Size(75, 35);
            btn_Reload.TabIndex = 14;
            btn_Reload.UseVisualStyleBackColor = true;
            btn_Reload.Click += btn_Reload_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "refresh-button.png");
            imageList1.Images.SetKeyName(1, "remove.png");
            imageList1.Images.SetKeyName(2, "edit.png");
            imageList1.Images.SetKeyName(3, "plus.png");
            // 
            // btn_Remove
            // 
            btn_Remove.ImageIndex = 1;
            btn_Remove.ImageList = imageList1;
            btn_Remove.Location = new Point(495, 104);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Size = new Size(75, 35);
            btn_Remove.TabIndex = 13;
            btn_Remove.UseVisualStyleBackColor = true;
            btn_Remove.Click += btn_Remove_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.ImageIndex = 2;
            btn_Edit.ImageList = imageList1;
            btn_Edit.Location = new Point(495, 63);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(75, 35);
            btn_Edit.TabIndex = 12;
            btn_Edit.UseVisualStyleBackColor = true;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_Add
            // 
            btn_Add.ImageIndex = 3;
            btn_Add.ImageList = imageList1;
            btn_Add.Location = new Point(495, 22);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(75, 35);
            btn_Add.TabIndex = 1;
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // chk_TT
            // 
            chk_TT.AutoSize = true;
            chk_TT.Location = new Point(150, 188);
            chk_TT.Name = "chk_TT";
            chk_TT.Size = new Size(83, 19);
            chk_TT.TabIndex = 11;
            chk_TT.Text = "Hoạt động";
            chk_TT.UseVisualStyleBackColor = true;
            // 
            // rd_GTnu
            // 
            rd_GTnu.AutoSize = true;
            rd_GTnu.Location = new Point(228, 150);
            rd_GTnu.Name = "rd_GTnu";
            rd_GTnu.Size = new Size(41, 19);
            rd_GTnu.TabIndex = 10;
            rd_GTnu.TabStop = true;
            rd_GTnu.Text = "Nữ";
            rd_GTnu.UseVisualStyleBackColor = true;
            // 
            // rd_GTnam
            // 
            rd_GTnam.AutoSize = true;
            rd_GTnam.Location = new Point(150, 150);
            rd_GTnam.Name = "rd_GTnam";
            rd_GTnam.Size = new Size(51, 19);
            rd_GTnam.TabIndex = 9;
            rd_GTnam.TabStop = true;
            rd_GTnam.Text = "Nam";
            rd_GTnam.UseVisualStyleBackColor = true;
            // 
            // dtp_Ngay
            // 
            dtp_Ngay.Location = new Point(150, 110);
            dtp_Ngay.Name = "dtp_Ngay";
            dtp_Ngay.Size = new Size(203, 23);
            dtp_Ngay.TabIndex = 8;
            // 
            // txt_HoTen
            // 
            txt_HoTen.Location = new Point(150, 74);
            txt_HoTen.Name = "txt_HoTen";
            txt_HoTen.Size = new Size(203, 23);
            txt_HoTen.TabIndex = 7;
            // 
            // txt_TaiKhoan
            // 
            txt_TaiKhoan.Location = new Point(150, 35);
            txt_TaiKhoan.Name = "txt_TaiKhoan";
            txt_TaiKhoan.Size = new Size(203, 23);
            txt_TaiKhoan.TabIndex = 6;
            // 
            // lbl_TT
            // 
            lbl_TT.AutoSize = true;
            lbl_TT.Location = new Point(39, 189);
            lbl_TT.Name = "lbl_TT";
            lbl_TT.Size = new Size(59, 15);
            lbl_TT.TabIndex = 5;
            lbl_TT.Text = "Trạng thái";
            // 
            // lbl_GT
            // 
            lbl_GT.AutoSize = true;
            lbl_GT.Location = new Point(39, 152);
            lbl_GT.Name = "lbl_GT";
            lbl_GT.Size = new Size(55, 15);
            lbl_GT.TabIndex = 4;
            lbl_GT.Text = "Giới tính:";
            // 
            // lbl_NS
            // 
            lbl_NS.AutoSize = true;
            lbl_NS.Location = new Point(39, 116);
            lbl_NS.Name = "lbl_NS";
            lbl_NS.Size = new Size(63, 15);
            lbl_NS.TabIndex = 3;
            lbl_NS.Text = "Ngày sinh:";
            // 
            // lbl_HT
            // 
            lbl_HT.AutoSize = true;
            lbl_HT.Location = new Point(39, 77);
            lbl_HT.Name = "lbl_HT";
            lbl_HT.Size = new Size(49, 15);
            lbl_HT.TabIndex = 2;
            lbl_HT.Text = "Họ tên: ";
            // 
            // lbl_TK
            // 
            lbl_TK.AutoSize = true;
            lbl_TK.Location = new Point(39, 38);
            lbl_TK.Name = "lbl_TK";
            lbl_TK.Size = new Size(60, 15);
            lbl_TK.TabIndex = 1;
            lbl_TK.Text = "Tài khoản:";
            // 
            // lv_Account
            // 
            lv_Account.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lv_Account.Location = new Point(12, 272);
            lv_Account.Name = "lv_Account";
            lv_Account.Size = new Size(587, 144);
            lv_Account.TabIndex = 1;
            lv_Account.UseCompatibleStateImageBehavior = false;
            lv_Account.View = View.Details;
            lv_Account.SelectedIndexChanged += lv_Account_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tài khoản";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Họ tên";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ngày sinh";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Giới tính";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Trạng thái";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 428);
            Controls.Add(lv_Account);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Tài Khoản";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_HoTen;
        private TextBox txt_TaiKhoan;
        private Label lbl_TT;
        private Label lbl_GT;
        private Label lbl_NS;
        private Label lbl_HT;
        private Label lbl_TK;
        private CheckBox chk_TT;
        private RadioButton rd_GTnu;
        private RadioButton rd_GTnam;
        private DateTimePicker dtp_Ngay;
        private Button btn_Reload;
        private Button btn_Remove;
        private Button btn_Edit;
        private Button btn_Add;
        private ImageList imageList1;
        private ListView lv_Account;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}