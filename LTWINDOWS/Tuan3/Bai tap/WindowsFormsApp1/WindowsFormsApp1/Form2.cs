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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNum1.Text) || string.IsNullOrWhiteSpace(txtNum2.Text))
            {
                MessageBox.Show("Please enter all the number", "Error", MessageBoxButtons.OK, icon:MessageBoxIcon.Error);
                return;
            }
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            double KQ;
            if(radP.Checked )
            {
                KQ = num1 + num2;
            }
            else if(radM.Checked )
            {
                KQ = num1 - num2;
            }
            else if(radMu.Checked )
            {
                KQ = num1 * num2;
            }
            else
            {
                if(num2 == 0)
                {
                    MessageBox.Show("Khong chia duoc cho 0");
                }
                KQ = (double)num1 / num2;
            }
            string kq = string.Format("Ket qua la: {0}", KQ);
            MessageBox.Show(kq,"Ket Qua");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            radP.Checked = true;
        }
    }
}
