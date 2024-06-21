using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Management.Instrumentation;
namespace _0306221377_LeNguyenHoangThong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            long DungLuongRam = 0;
            lbl_Name.Text = Environment.MachineName.ToString();

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Computersystem");
            foreach (ManagementObject obj in searcher.Get())
            {
                DungLuongRam = long.Parse(obj["TotalPhysicalMemory"].ToString());
                DungLuongRam = DungLuongRam / (1024 * 1024);
            }
            lbl_RAM.Text = DungLuongRam.ToString() + " " +"MB";
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
