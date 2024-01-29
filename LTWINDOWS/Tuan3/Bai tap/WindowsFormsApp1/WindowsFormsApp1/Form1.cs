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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            chkMovie.Checked = chkMusic.Checked = chkRead.Checked = chkSoccer.Checked = false;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Please enter full name", "Error", MessageBoxButtons.OK, icon:MessageBoxIcon.Error);
                return;
            }

            string tb = "";
            tb += txtHoTen.Text + "\n";
            tb += "Hobby: \n";

            if(chkMovie.Checked)
            {
                tb += $"- {chkMovie.Text} \n";
            }
            if(chkMusic.Checked)
            {
                tb += $"- {chkMusic.Text} \n";
            }
            if(chkRead.Checked)
            {
                tb += $"- {chkRead.Text} \n";
            }
            if (chkSoccer.Checked)
            {
                tb += $"- {chkSoccer.Text} \n";
            }
            MessageBox.Show(tb,"Information",MessageBoxButtons.OK,icon:MessageBoxIcon.Information);
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsDigit(e.KeyChar) && Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
