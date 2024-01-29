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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(btnOK.Text) )
            {
                MessageBox.Show("Chưa nhập năm sinh");
            }
            else
            {
                int NamSinh = int.Parse(txtNamSinh.Text);
                int Tuoi = DateTime.Now.Year - NamSinh;
                MessageBox.Show("Số tuổi của bạn là: " + Tuoi);
            }    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
