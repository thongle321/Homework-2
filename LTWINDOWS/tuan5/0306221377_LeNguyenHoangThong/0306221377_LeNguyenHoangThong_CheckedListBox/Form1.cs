namespace _0306221377_LeNguyenHoangThong_CheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnClick_Click(object sender, EventArgs e)
        {
            foreach (string ItemChecked in chkListBox.CheckedItems)
            {
                MessageBox.Show(ItemChecked + ".");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}