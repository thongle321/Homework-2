using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _0306221377_LeNguyenHoangThong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_XemDSHS_Click(object sender, EventArgs e)
        {
            XemDanhSachHocSinh();

        }
        public void XemDanhSachHocSinh()
        {
            string scon;
            scon = "Data Source=.;Initial Catalog=HocSinhDB;Integrated Security=True";
            SqlConnection myConnection = new SqlConnection(scon);
            string sSQL = "SELECT * FROM HocSinh";
            try
            {
                myConnection.Open();
                SqlDataAdapter daHocSinh = new SqlDataAdapter(sSQL, myConnection);
                DataSet dsHocSinh = new DataSet();
                daHocSinh.Fill(dsHocSinh);
                myConnection.Close();   
                grid_DSHocSinh.DataSource = dsHocSinh.Tables[0];
            } catch (Exception ex)
            {
                MessageBox.Show("Lỗi chi tiết: " + ex.Message);
            }
        }
        public void XemDanhSachHocSinhNu()
        {
            string scon;
            scon = "Data Source=.;Initial Catalog=HocSinhDB;Integrated Security=True";
            SqlConnection myConnection = new SqlConnection(scon);
            string sSQL = "SELECT * FROM HocSinh Where GioiTinh=0";
            try
            {
                myConnection.Open();
                SqlDataAdapter daHocSinhNu = new SqlDataAdapter(sSQL, myConnection);
                DataSet dsHocSinhNu = new DataSet();
                daHocSinhNu.Fill(dsHocSinhNu);
                myConnection.Close();
                grid_DSHocSinh.DataSource = dsHocSinhNu.Tables[0];
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi chi tiết: " + ex.Message);
            }
        }
        public void XemDanhSachHocSinhDat()
        {
            string scon;
            scon = "Data Source=.;Initial Catalog=HocSinhDB;Integrated Security=True";
            SqlConnection myConnection = new SqlConnection(scon);
            string sSQL = "SELECT * FROM HocSinh Where DiemTrungBinh >= 5";
            try
            {
                myConnection.Open();
                SqlDataAdapter daHocSinhDat = new SqlDataAdapter(sSQL, myConnection);
                DataSet dsHocSinhDat = new DataSet();
                daHocSinhDat.Fill(dsHocSinhDat);
                myConnection.Close();
                grid_DSHocSinh.DataSource = dsHocSinhDat.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chi tiết: " + ex.Message);
            }
        }
        private void btn_XemDSHSNu_Click(object sender, EventArgs e)
        {
            XemDanhSachHocSinhNu();
        }

        private void btn_XemDSHSDat_Click(object sender, EventArgs e)
        {
            XemDanhSachHocSinhDat();
        }
    }
}
