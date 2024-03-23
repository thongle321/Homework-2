namespace _0306221377_LeNguyenHoangThong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            string chonNgay = dtp_Ngay.Value.ToString();
            MessageBox.Show(chonNgay);
        }
    }
}
