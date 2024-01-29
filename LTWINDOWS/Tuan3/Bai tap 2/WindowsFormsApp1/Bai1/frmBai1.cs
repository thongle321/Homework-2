using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Chưa nhập họ tên");
            }
            else
            {
                MessageBox.Show("Xin chào " + txtHoTen.Text);
            }
        }
    }
}
