using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0306221377_LeNguyenHoangThong_CuaHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        SqlConnection myConnection = new SqlConnection("Data Source=F73-15;Initial Catalog=CuaHangDB;Integrated Security=True");
        public void Mot()
        {
            string sql1 = "SELECT * FROM SanPham";
            try
            {
                myConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql1, myConnection);
                DataSet ds = new DataSet();
                da.Fill(ds);
                myConnection.Close();
                grid_SanPham.DataSource = ds.Tables[0];

            } catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message.ToString());
            }
        }
        public void Hai()
        {
            string sql2 = "SELECT * FROM NhaSanXuat";
            try
            {
                myConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql2, myConnection);
                DataSet ds = new DataSet();
                da.Fill(ds);
                myConnection.Close();
                grid_SanPham.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message.ToString());
            }
        }
        public void Ba()
        {
            string sql3 = "SELECT * FROM SanPham WHERE DonGia > 1000000";
            try
            {
                myConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql3, myConnection);
                DataSet ds = new DataSet();
                da.Fill(ds);
                myConnection.Close();
                grid_SanPham.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message.ToString());
            }
        }
        public void Bon()
        {
            string sql4 = "SELECT TOP 1 * FROM SanPham ORDER BY SoLuong DESC";
            try
            {
                myConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql4, myConnection);
                DataSet ds = new DataSet();
                da.Fill(ds);
                myConnection.Close();
                grid_SanPham.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message.ToString());
            }
        }
        public void Nam()
        {
            string sql5 = "SELECT TOP 1 * FROM SanPham ORDER BY DonGia ASC";
            try
            {
                myConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql5, myConnection);
                DataSet ds = new DataSet();
                da.Fill(ds);
                myConnection.Close();
                grid_SanPham.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message.ToString());
            }
        }
        public void Bay()
        {
            string sql7 = "SELECT * From SanPham WHERE NgaySanXuat < '01/10/2009'";
            try
            {
                myConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql7, myConnection);
                DataSet ds = new DataSet();
                da.Fill(ds);
                myConnection.Close();
                grid_SanPham.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message.ToString());
            }
        }
        public void Tam()
        {
            string sql8 = "SELECT * From SanPham WHERE YEAR(NgaySanXuat) < 2009";
            try
            {
                myConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql8, myConnection);
                DataSet ds = new DataSet();
                da.Fill(ds);
                myConnection.Close();
                grid_SanPham.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message.ToString());
            }
        }
        public void Chin()
        {
            string sql9 = "SELECT * From NhaSanXuat WHERE DiaChi LIKE '%TP. HCM%'";
            try
            {
                myConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql9, myConnection);
                DataSet ds = new DataSet();
                da.Fill(ds);
                myConnection.Close();
                grid_SanPham.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message.ToString());
            }
        }
        public void Muoi()
        {
            string sql10 = "SELECT * From NhaSanXuat join SanPham ON NhaSanXuat.MaNhaSanXuat = SanPham.MaNhaSanXuat WHERE DiaChi LIKE N'%HÀ NỘI%' AND SanPham.DonGia < 15000000\r\n";
            try
            {
                myConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql10, myConnection);
                DataSet ds = new DataSet();
                da.Fill(ds);
                myConnection.Close();
                grid_SanPham.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message.ToString());
            }
        }
        public void MuoiMot()
        {
            string sql11 = "SELECT NhaSanXuat.TenNhaSanXuat, COUNT(*) AS SoLuongSanPham From NhaSanXuat join SanPham ON NhaSanXuat.MaNhaSanXuat = SanPham.MaNhaSanXuat GROUP BY NhaSanXuat.TenNhaSanXuat";
            try
            {
                myConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql11, myConnection);
                DataSet ds = new DataSet();
                da.Fill(ds);
                myConnection.Close();
                grid_SanPham.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message.ToString());
            }
        }
        public void MuoiHai()
        {
            string sql12 = "SELECT NhaSanXuat.TenNhaSanXuat, COUNT(*) AS SoLuongSanPham From NhaSanXuat join SanPham ON NhaSanXuat.MaNhaSanXuat = SanPham.MaNhaSanXuat GROUP BY NhaSanXuat.TenNhaSanXuat";
            try
            {
                myConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql12, myConnection);
                DataSet ds = new DataSet();
                da.Fill(ds);
                myConnection.Close();
                grid_SanPham.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message.ToString());
            }
        }
        private void btn_1_Click(object sender, EventArgs e)
        {
            Mot();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            Hai();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            Ba();
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            Bon();
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            Nam();
        }

        private void btn_6_Click(object sender, EventArgs e)
        {

        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            Bay();
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            Tam();
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            Chin();
        }

        private void btn_10_Click(object sender, EventArgs e)
        {
            Muoi();
        }

        private void btn_11_Click(object sender, EventArgs e)
        {
            MuoiMot();
        }
    }
}
