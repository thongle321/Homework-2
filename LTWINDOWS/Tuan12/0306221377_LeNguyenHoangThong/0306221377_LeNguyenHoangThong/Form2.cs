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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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

            string sCPUName = "";
            ManagementObjectSearcher searcher2 = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            foreach(ManagementObject obj in searcher2.Get())
            {
                sCPUName = obj["Name"].ToString();
            }
            lbl_CPU.Text = sCPUName.ToString();

            string sHDDName = "";
            float sHDDSize = 0;
            ManagementObjectSearcher searcher3 = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            foreach( ManagementObject obj in searcher3.Get())
            {
                foreach(PropertyData pd in obj.Properties)
                {
                    if (pd.Name == "Model")
                    {
                        sHDDName = pd.Value.ToString();
                    }    
                    if (pd.Name == "Size")
                    {
                        string size = pd.Value.ToString();
                        sHDDSize = float.Parse(size) / (1024 * 1024 * 1024);
                    }    
                }    
            }    
            lbl_HDD.Text = sHDDName + " - Size: " + sHDDSize.ToString() + " " + "GB";
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
