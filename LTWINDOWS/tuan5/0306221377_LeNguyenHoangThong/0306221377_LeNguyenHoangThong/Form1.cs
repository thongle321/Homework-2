using System.Windows.Forms;

namespace _0306221377_LeNguyenHoangThong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstBox.SelectionMode = SelectionMode.MultiSimple;
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            foreach (Object obj in lstBox.SelectedItems)
            {
                MessageBox.Show(obj.ToString(), "Ngày bạn chọn");
            }
        }
    }
}