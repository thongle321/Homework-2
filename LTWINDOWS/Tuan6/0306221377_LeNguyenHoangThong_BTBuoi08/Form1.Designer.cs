namespace _0306221377_LeNguyenHoangThong_BTBuoi08
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
            ListViewItem listViewItem1 = new ListViewItem("Ủn Ủn", 2);
            ListViewItem listViewItem2 = new ListViewItem("Chít Chít", 0);
            ListViewItem listViewItem3 = new ListViewItem("Ó o", 1);
            ListViewItem listViewItem4 = new ListViewItem("Cạp cạp", 3);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lv_Animal = new ListView();
            imageList1 = new ImageList(components);
            btn_Large = new Button();
            btn_Small = new Button();
            btn_List = new Button();
            btn_Tile = new Button();
            SuspendLayout();
            // 
            // lv_Animal
            // 
            lv_Animal.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4 });
            lv_Animal.LargeImageList = imageList1;
            lv_Animal.Location = new Point(12, 38);
            lv_Animal.Name = "lv_Animal";
            lv_Animal.Size = new Size(666, 418);
            lv_Animal.SmallImageList = imageList1;
            lv_Animal.TabIndex = 0;
            lv_Animal.UseCompatibleStateImageBehavior = false;
            lv_Animal.View = View.SmallIcon;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "4370-15790849079601083165506-crop-15790851002311001826132.jpg");
            imageList1.Images.SetKeyName(1, "congly-vn_con-ga.jpg");
            imageList1.Images.SetKeyName(2, "Sus_scrofa_domesticus,_miniature_pig,_juvenile.jpg");
            imageList1.Images.SetKeyName(3, "White_duck_in_Utah_(42425216301).jpg");
            // 
            // btn_Large
            // 
            btn_Large.Location = new Point(12, 9);
            btn_Large.Name = "btn_Large";
            btn_Large.Size = new Size(75, 23);
            btn_Large.TabIndex = 1;
            btn_Large.Text = "Large";
            btn_Large.UseVisualStyleBackColor = true;
            btn_Large.Click += btn_Large_Click;
            // 
            // btn_Small
            // 
            btn_Small.Location = new Point(93, 9);
            btn_Small.Name = "btn_Small";
            btn_Small.Size = new Size(75, 23);
            btn_Small.TabIndex = 2;
            btn_Small.Text = "Small";
            btn_Small.UseVisualStyleBackColor = true;
            btn_Small.Click += btn_Small_Click;
            // 
            // btn_List
            // 
            btn_List.Location = new Point(174, 9);
            btn_List.Name = "btn_List";
            btn_List.Size = new Size(75, 23);
            btn_List.TabIndex = 3;
            btn_List.Text = "List";
            btn_List.UseVisualStyleBackColor = true;
            btn_List.Click += btn_List_Click;
            // 
            // btn_Tile
            // 
            btn_Tile.Location = new Point(255, 9);
            btn_Tile.Name = "btn_Tile";
            btn_Tile.Size = new Size(75, 23);
            btn_Tile.TabIndex = 4;
            btn_Tile.Text = "Tile";
            btn_Tile.UseVisualStyleBackColor = true;
            btn_Tile.Click += btn_Tile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 456);
            Controls.Add(btn_Tile);
            Controls.Add(btn_List);
            Controls.Add(btn_Small);
            Controls.Add(btn_Large);
            Controls.Add(lv_Animal);
            Name = "Form1";
            Text = "0306221377 - Lê Nguyễn Hoàng Thông - ListView";
            ResumeLayout(false);
        }

        #endregion

        private ListView lv_Animal;
        private ImageList imageList1;
        private Button btn_Large;
        private Button btn_Small;
        private Button btn_List;
        private Button btn_Tile;
    }
}
