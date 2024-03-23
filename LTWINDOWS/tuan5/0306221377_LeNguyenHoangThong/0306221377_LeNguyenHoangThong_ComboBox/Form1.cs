namespace _0306221377_LeNguyenHoangThong_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            string s;
            s = this.cb.GetItemText(this.cb.SelectedItem);
            MessageBox.Show(s);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb.SelectedItem = "Monday";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (cb.SelectedIndex >= 0)
            {
                cb.Items.Remove(cb.SelectedItem);
            }
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}