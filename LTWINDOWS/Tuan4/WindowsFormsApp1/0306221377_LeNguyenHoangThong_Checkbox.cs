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
    public partial class _0306221377_Checkbox : Form
    {
        public _0306221377_Checkbox()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            string m = "";
            if(chkPhim.Checked) { m += $"{chkPhim.Text},"; }
            if(chkNhac.Checked) { m += $"{chkNhac.Text},"; }
            if(chkSach.Checked) { m += $"{chkSach.Text},"; }
            if(chkBong.Checked) { m += $"{chkBong.Text},"; }
            MessageBox.Show(m,"Sở thích",MessageBoxButtons.OK);
        }
    }
}
