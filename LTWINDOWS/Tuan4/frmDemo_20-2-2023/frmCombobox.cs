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
    public partial class frmCombobox : Form
    {
        public frmCombobox()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cbDanhSach.Items.Add("Vincent");
            cbDanhSach.Items.Add("Christopher");
            cbDanhSach.Items.Add("Hanna");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            cbDanhSach.Items.Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string s;
            s = cbDanhSach.SelectedItem.ToString();
            MessageBox.Show(s);
        }
    }
}
