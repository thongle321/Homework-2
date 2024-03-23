using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class _0306221377_ListBox : Form
    {
        public _0306221377_ListBox()
        {
            InitializeComponent();
        }

        private void lstThu_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void _0306221377_ListBox_Load(object sender, EventArgs e)
        {
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            if(lstThu.SelectedItems.Count > 0)
            {
                MessageBox.Show(lstThu.Text,"Ngày bạn chọn",MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn ngày","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }    
        }
    }
}
