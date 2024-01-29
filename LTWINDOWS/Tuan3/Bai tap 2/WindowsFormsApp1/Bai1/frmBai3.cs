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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtKQ.Clear();
        }
        void NumberOnly(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }    
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtA.Text) || (String.IsNullOrEmpty(txtB.Text)))
            {
                MessageBox.Show("Chưa nhập số liệu", "Thông báo");
                return;
            }
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            string kq = $"{a} + {b} = {a+b}";
            txtKQ.Text = kq;
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtA.Text) || (String.IsNullOrEmpty(txtB.Text)))
            {
                MessageBox.Show("Chưa nhập số liệu", "Thông báo");
                return;
            }
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            string kq = $"{a} - {b} = {a - b}";
            txtKQ.Text = kq;
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtA.Text) || (String.IsNullOrEmpty(txtB.Text)))
            {
                MessageBox.Show("Chưa nhập số liệu", "Thông báo");
                return;
            }
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            string kq = $"{a} * {b} = {a * b}";
            txtKQ.Text = kq;
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtA.Text) || (String.IsNullOrEmpty(txtB.Text)))
            {
                MessageBox.Show("Chưa nhập số liệu", "Thông báo");
                return;
            }
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            string kq = $"{a} / {b} = {a / b}";
            txtKQ.Text = kq;
        }
    }
}
