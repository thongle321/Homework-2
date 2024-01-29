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
    public partial class frmBai4 : Form
    {
        public frmBai4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        void NumberOnly(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && (!Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }    
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtKQ.Clear();  
        }
        int UCLN(int a , int b)
        {
            if(a == 0 || b == 0)
            {
                return a + b;
            }    
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            return a;
        }
        private void btnUCLN_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtA.Text) || String.IsNullOrEmpty(txtB.Text)) 
            {
                MessageBox.Show("Chưa nhập số liệu", "Thông báo");
                return;
            }
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            string kq = $"{UCLN(a, b)}";
            txtKQ.Text = kq;
        }
    }
}
