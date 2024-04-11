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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace _0306221377_LeNguyenHoangThong_CuaHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        SqlConnection myConnection = new SqlConnection("Data Source=.;Initial Catalog=CuaHangDB;Integrated Security=True");
        public void Mot(string sql)
        {
          
            try
            {
                myConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, myConnection);
                DataSet ds = new DataSet();
                da.Fill(ds);
                myConnection.Close();
                grid_SanPham.DataSource = ds.Tables[0];

            } catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message.ToString());
            }
        }
        public void Hai(string sql2)
        {
           
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
        public void Ba(string sql3)
        {
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
        public void Bon(string sql4)
        {
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
        public void Nam(string sql5)
        {
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
        public void Bay(string sql7)
        {
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
        public void Tam(string sql8)
        {
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
        public void Chin(string sql9)
        {
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
        public void Muoi(string sql10)
        {
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
        public void MuoiMot(string sql11)
        {
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
            string sql = "SELECT MaSanPham, TenSanPham, TenNhaSanXuat,DonGia, SoLuong, NgaySanXuat FROM SanPham, NhaSanXuat WHERE SanPham.MaNhaSanXuat = NhaSanXuat.MaNhaSanXuat";
            Mot(sql);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            string sql2 = "SELECT * FROM NhaSanXuat";
            Hai(sql2);

        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            string sql3 = "SELECT * FROM SanPham WHERE DonGia > 1000000";
            Ba(sql3);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            string sql4 = "SELECT TOP 1 * FROM SanPham ORDER BY SoLuong DESC";
            Bon(sql4);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            string sql5 = "SELECT TOP 1 * FROM SanPham ORDER BY DonGia ASC";
            Nam(sql5);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {

        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            string sql7 = "SELECT * From SanPham WHERE NgaySanXuat < '01/10/2009'";
            Bay(sql7);
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            string sql8 = "SELECT * From SanPham WHERE YEAR(NgaySanXuat) < 2009";
            Tam(sql8);
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            string sql9 = "SELECT * From NhaSanXuat WHERE DiaChi LIKE '%TP. HCM%'";
            Chin(sql9);
        }

        private void btn_10_Click(object sender, EventArgs e)
        {
            string sql10 = "SELECT * From NhaSanXuat join SanPham ON NhaSanXuat.MaNhaSanXuat = SanPham.MaNhaSanXuat WHERE DiaChi LIKE N'%HÀ NỘI%' AND SanPham.DonGia < 15000000";
            Muoi(sql10);
        }

        private void btn_11_Click(object sender, EventArgs e)
        {
            string sql11 = "SELECT NhaSanXuat.TenNhaSanXuat, COUNT(*) AS SoLuongSanPham From NhaSanXuat join SanPham ON NhaSanXuat.MaNhaSanXuat = SanPham.MaNhaSanXuat GROUP BY NhaSanXuat.MaNhaSanXuat, TenNhaSanXuat";
            MuoiMot(sql11);
        }

        private void btn_12_Click(object sender, EventArgs e)
        {

        }

        private void txt_TimSanPham_TextChanged(object sender, EventArgs e)
        {
            string sql12 = "SELECT MaSanPham, TenSanPham, TenNhaSanXuat, DonGia, SoLuong, NgaySanXuat ";
            sql12 += "FROM SanPham, NhaSanXuat ";
            sql12 += "WHERE SanPham.MaNhaSanXuat=NhaSanXuat.MaNhaSanXuat AND TenSanPham LIKE '%" + txt_TimSanPham.Text + "%'";
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

        private void txt_TuKhoa_TextChanged(object sender, EventArgs e)
        {
            string sql13 = "SELECT MaSanPham, TenSanPham, TenNhaSanXuat, DonGia, SoLuong, NgaySanXuat ";
            sql13 += "FROM SanPham, NhaSanXuat ";
            sql13 += "WHERE SanPham.MaNhaSanXuat = NhaSanXuat.MaNhaSanXuat AND TenSanPham LIKE '%" + txt_TuKhoa.Text + "%' OR MaSanPham LIKE '%" + txt_TuKhoa.Text + "%'";
            try
            {
                myConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql13, myConnection);
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

        private void txt_TuKhoa2_TextChanged(object sender, EventArgs e)
        {
            string sql14 = "SELECT MaSanPham, TenSanPham, TenNhaSanXuat, DonGia, SoLuong, NgaySanXuat ";
            sql14 += "FROM SanPham, NhaSanXuat ";
            sql14 += "WHERE SanPham.MaNhaSanXuat = NhaSanXuat.MaNhaSanXuat AND TenNhaSanXuat LIKE '%" + txt_TuKhoa2.Text + "%'";
            try
            {
                myConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql14, myConnection);
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

        private void txt_TuKhoa3_TextChanged(object sender, EventArgs e)
        {
            string sql15 = "SELECT * FROM NhaSanXuat WHERE TenNhaSanXuat LIKE '%" + txt_TuKhoa3.Text + "%'";
            try
            {
                myConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql15, myConnection);
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
    }
}
