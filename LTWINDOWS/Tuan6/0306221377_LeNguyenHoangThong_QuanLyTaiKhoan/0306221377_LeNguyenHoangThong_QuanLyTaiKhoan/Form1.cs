using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Principal;
using System.Xml.Linq;
using System.Windows.Forms;

namespace _0306221377_LeNguyenHoangThong_QuanLyTaiKhoan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rd_GTnam.Checked = true;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string TaiKhoan = txt_TaiKhoan.Text;
            string HoTen = txt_HoTen.Text;
            string NgaySinh = dtp_Ngay.Value.ToShortDateString();
            string Phai = rd_GTnam.Checked ? "Nam" : "Nữ";
            string TrangThai = chk_TT.Checked ? "Hoạt động" : "Không hoạt động";
            if (lv_Account.Items.Count > 0)
            {
                bool tonTai = false;
                foreach (ListViewItem item in lv_Account.Items)
                {
                    if (item.Text == TaiKhoan)
                    {
                        tonTai = true;
                        break;
                    }
                }
                if (!tonTai)
                {

                    ListViewItem item = new ListViewItem(TaiKhoan);
                    item.SubItems.Add(HoTen);
                    item.SubItems.Add(NgaySinh);
                    item.SubItems.Add(Phai);
                    item.SubItems.Add(TrangThai);

                    lv_Account.Items.Add(item);
                }
                else
                {
                    MessageBox.Show("Tài khoản đã tồn tại!");
                }
            }
            else
            {
                ListViewItem item = new ListViewItem(TaiKhoan);
                item.SubItems.Add(HoTen);
                item.SubItems.Add(NgaySinh);
                item.SubItems.Add(Phai);
                item.SubItems.Add(TrangThai);
                lv_Account.Items.Add(item);
            }


        }

        private void lv_Account_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Account.SelectedItems.Count > 0)
            {
                ListViewItem item = lv_Account.SelectedItems[0];
                // Hiện lên thông tin
                if (item != null)
                {
                    txt_TaiKhoan.Text = item.Text;
                    txt_HoTen.Text = item.SubItems[1].Text;
                    dtp_Ngay.Value = DateTime.Parse(item.SubItems[2].Text);
                    if (item.SubItems[3].Text == "Nam")
                    {
                        rd_GTnam.Checked = true;
                    }
                    else
                    {
                        rd_GTnu.Checked = true;
                    }
                    chk_TT.Checked = item.SubItems[4].Text == "Hoạt động" ? true : false;
                }
            }

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                string account = txt_TaiKhoan.Text;
                string name = txt_HoTen.Text;
                string birthday = dtp_Ngay.Value.ToShortDateString();
                string sex = rd_GTnam.Checked ? "Nam" : "Nữ";
                string statetus = chk_TT.Checked ? "Hoạt động" : "Không hoạt động";

                lv_Account.SelectedItems[0].SubItems[0].Text = account;
                lv_Account.SelectedItems[0].SubItems[1].Text = name;
                lv_Account.SelectedItems[0].SubItems[2].Text = birthday;
                lv_Account.SelectedItems[0].SubItems[3].Text = sex;
                lv_Account.SelectedItems[0].SubItems[4].Text = statetus;

            }
            catch (Exception)
            {
                MessageBox.Show(lv_Account.SelectedIndices[0].ToString());
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                if (lv_Account.Items.Count > 0)
                {
                    foreach (ListViewItem item1 in lv_Account.SelectedItems)
                    {
                        //ListViewItem item = lv_Account.SelectedItems[0];
                        item1.Remove();
                    }
                   
                }
               
            }
            catch
            {
                MessageBox.Show("Vui long chon");
            }

        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            txt_HoTen.Clear();
            txt_TaiKhoan.Clear();
            dtp_Ngay.Value = DateTime.Now;
            rd_GTnam.Checked = true;
            chk_TT.Checked = false;
        }
    }
}