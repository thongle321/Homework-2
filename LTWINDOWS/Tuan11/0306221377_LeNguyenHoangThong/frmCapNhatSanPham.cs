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

namespace _0306221377_LeNguyenHoangThong
{
    public partial class frmCapNhatSanPham : Form
    {
        public frmCapNhatSanPham()
        {
            InitializeComponent();
        }
        public void HienThiDanhSachSP()
        {
            string sSql = "SELECT MaSanPham, TenSanPham, TenNhaSanXuat, DonGia, SoLuong, NgaySanXuat ";
            sSql += " FROM SanPham, NhaSanXuat ";
            sSql += " WHERE SanPham.MaNhaSanXuat=NhaSanXuat.MaNhaSanXuat";
            XemDanhSach(sSql);
        }

        public void HienThiDanhSachNhaSanXuat()
        {
            string scon = "Data Source=DESKTOP-676STPK\\SQLEXPRESS;Initial Catalog=CuaHangDB;Integrated Security=True;Encrypt=False";

            SqlConnection myConnection = new SqlConnection(scon);

            string sSql = "SELECT MaNhaSanXuat, TenNhaSanXuat FROM NhaSanXuat";
            try
            {
                myConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sSql, myConnection);

                DataSet ds = new DataSet();
                da.Fill(ds);

                myConnection.Close();
                cbb_NhaSanXuat.DataSource = ds.Tables[0];
                cbb_NhaSanXuat.DisplayMember = "TenNhaSanXuat";
                cbb_NhaSanXuat.ValueMember = "MaNhaSanXuat";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chi tiết" + ex.Message);
            }

        }
        public bool CapNhatSanPham(string sMaSP, string sTenSP, string sMaNSX, int iDonGia, int iSoLuong, string  s_NgaySX)
        {
            bool kq;

            kq = true;

            string scon;
            scon = "Data Source=DESKTOP-676STPK\\SQLEXPRESS;Initial Catalog=CuaHangDB;Integrated Security=True;Encrypt=False";
            SqlConnection myConnection = new SqlConnection(scon);

            string sSql;
            sSql = "UPDATE SanPham ";
            sSql += "SET ";
            sSql += " TenSanPham=N'" + sTenSP + "', ";
            sSql += " MaNhaSanXuat='" + sMaNSX + "', ";
            sSql += " DonGia='" + iDonGia.ToString() + "',";
            sSql += " SoLuong='" + iSoLuong.ToString() + "',";
            sSql += " NgaySanXuat='" + s_NgaySX + "'";
            sSql += " WHERE MaSanPham='" + sMaSP + "'";
            MessageBox.Show(sSql);
            try
            {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand(sSql, myConnection);
                myCommand.ExecuteNonQuery();

                //int numRows = myCommand.ExecuteNonQuery();
                //if (numRows == 0)
                //{
                //    kq = false;
                //}
                myConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return kq;
        }
        public void XemDanhSach(string sSql)
        {
            string scon = "Data Source = DESKTOP-676STPK\\SQLEXPRESS; Initial Catalog =CuaHangDB;Integrated Security=True";
            SqlConnection myConnection = new SqlConnection(scon);
            try
            {
                myConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sSql, myConnection);
                DataSet ds = new DataSet();
                da.Fill(ds);
                myConnection.Close();
                grid_DanhSach.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message.ToString());
            }
        }

        private void frmCapNhatSanPham_Load(object sender, EventArgs e)
        {
            HienThiDanhSachSP();
            HienThiDanhSachNhaSanXuat();
        }

        private void grid_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string sMaSP, sTenSP, sTenNSX;
                int iSoLuong, iDonGia;
                DateTime dt_NgaySX;
                sMaSP = grid_DanhSach.CurrentRow.Cells[0].Value.ToString();
                sTenSP = grid_DanhSach.CurrentRow.Cells[1].Value.ToString();
                sTenNSX = grid_DanhSach.CurrentRow.Cells[2].Value.ToString();
                iDonGia = (int) grid_DanhSach.CurrentRow.Cells[3].Value;
                iSoLuong = (int) grid_DanhSach.CurrentRow.Cells[4].Value;
                dt_NgaySX = (DateTime) grid_DanhSach.CurrentRow.Cells[5].Value;

                txt_MaSanPham.Text = sMaSP;
                txt_TenSP.Text = sTenSP;
                cbb_NhaSanXuat.Text = sTenNSX;
                txt_DonGia.Text = iDonGia.ToString(); 
                txt_SoLuong.Text = iSoLuong.ToString();
                dt_NgaySanXuat.Value = dt_NgaySX;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chi tiết:" + ex.Message);
            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            string sMaSP, sTenSP, sMaNSX, sNgaySX;
            int iDonGia, iSoLuong;
            sMaSP = txt_MaSanPham.Text;
            sTenSP = txt_TenSP.Text;
            sMaNSX = cbb_NhaSanXuat.SelectedValue.ToString();
            iDonGia = int.Parse(txt_DonGia.Text);
            iSoLuong = int.Parse(txt_SoLuong.Text);
            sNgaySX = dt_NgaySanXuat.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
            bool kq = CapNhatSanPham(sMaSP, sTenSP, sMaNSX, iDonGia, iSoLuong, sNgaySX);
            if (kq)
            {
                MessageBox.Show("Cập nhật thành công");
                HienThiDanhSachSP();
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công");
            }    

        }
    }
}
