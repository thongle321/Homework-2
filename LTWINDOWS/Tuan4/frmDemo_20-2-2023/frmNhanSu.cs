using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmDemo
{
    public partial class frmNhanSu : Form
    {
        public frmNhanSu()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(lstDanhSach.Items.IndexOf(txtHoTen.Text) >= 0)
            {
                lstDanhSach.SelectedItem = txtHoTen.Text;
            }
            else
            {
                lstDanhSach.Items.Add(txtHoTen.Text);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.SelectedItems.Count > 0)
            {
                lstDanhSach.Items.Remove(lstDanhSach.SelectedItems[0]);
                //lstDanhSach.Items.RemoveAt(lstDanhSach.SelectedIndex);
            }
        }
    }
}
