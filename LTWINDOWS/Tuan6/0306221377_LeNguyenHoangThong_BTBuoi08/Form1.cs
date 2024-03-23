namespace _0306221377_LeNguyenHoangThong_BTBuoi08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Large_Click(object sender, EventArgs e)
        {
            lv_Animal.View = View.LargeIcon;
        }

        private void btn_Small_Click(object sender, EventArgs e)
        {
            lv_Animal.View = View.SmallIcon;

        }

        private void btn_List_Click(object sender, EventArgs e)
        {
            lv_Animal.View = View.List;

        }

        private void btn_Tile_Click(object sender, EventArgs e)
        {
            lv_Animal.View = View.Tile;

        }
    }
}
