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
    public partial class frmCapNhatNhaSanXuat : Form
    {
        public frmCapNhatNhaSanXuat()
        {
            InitializeComponent();
        }
        public void HienThiDanhSachNSX()
        {
            string sSql = "SELECT MaNhaSanXuat, TenNhaSanXuat, DiaChi, DienThoai FROM NhaSanXuat";
            XemDanhSach(sSql);
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

        private void grid_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string sMaNSX, sTenNSX, sDiaChi, sDienThoai;
                sMaNSX = grid_DanhSach.CurrentRow.Cells[0].Value.ToString();
                sTenNSX = grid_DanhSach.CurrentRow.Cells[1].Value.ToString();
                sDiaChi = grid_DanhSach.CurrentRow.Cells[2].Value.ToString();
                sDienThoai = grid_DanhSach.CurrentRow.Cells[3].Value.ToString();

                txt_MaNhaSanXuat.Text = sMaNSX;
                txt_TenNhaSanXuat.Text = sTenNSX;
                txt_DiaChi.Text = sDiaChi;
                txt_DienThoai.Text = sDienThoai;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chi tiết:" + ex.Message);
            }
        }

        private void frmCapNhatNhaSanXuat_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNSX();
        }

        public bool CapNhatNhaSanXuat(string sMaNhaSanXuat, string sTenNhaSanXuat, string sDiaChi, string sDienThoai)
        {
            bool kq;

            kq = true;

            string scon;
            scon = "Data Source=DESKTOP-676STPK\\SQLEXPRESS;Initial Catalog=CuaHangDB;Integrated Security=True;Encrypt=False";
            SqlConnection myConnection = new SqlConnection(scon);

            string sSql;
            sSql = "UPDATE NhaSanXuat ";
            sSql += "SET";
            sSql += " TenNhaSanXuat=N'" + sTenNhaSanXuat + "', ";
            sSql += " DiaChi=N'" + sDiaChi + "', ";
            sSql += " DienThoai='" + sDienThoai + "'";
            sSql += " WHERE MaNhaSanXuat='" + sMaNhaSanXuat + "'";
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
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sMaNSX, sTenNSX, sDiaChi, sDienThoai;
            sMaNSX = txt_MaNhaSanXuat.Text;
            sTenNSX = txt_TenNhaSanXuat.Text;
            sDiaChi = txt_DiaChi.Text;
            sDienThoai = txt_DienThoai.Text;
            bool kq = CapNhatNhaSanXuat(sMaNSX, sTenNSX, sDiaChi, sDienThoai);
            if (kq)
            {
                MessageBox.Show("Cập nhật thành công");
                HienThiDanhSachNSX();
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công");
            }    
        }
    }
}
