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
    public partial class frmThemNhaSanXuat : Form
    {
        public frmThemNhaSanXuat()
        {
            InitializeComponent();
        }
        public bool ThemNhaSanXuat(string sMaNSX, string sTenNSX, string sDiaChi, string sDienThoai)
        {
            bool kq;

            kq = true;

            string scon;
            scon = "Data Source=DESKTOP-676STPK\\SQLEXPRESS;Initial Catalog=CuaHangDB;Integrated Security=True;Encrypt=False";
            SqlConnection myConnection = new SqlConnection(scon);

            string sSql;
            sSql = "INSERT INTO NhaSanXuat VALUES (";
            sSql += "'" + sMaNSX + "',";
            sSql += "N'" + sTenNSX + "',";
            sSql += "N'" + sDiaChi + "',";
            sSql += "'" + sDienThoai + "')";
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
                //myConnection.Close();
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
            bool kq = ThemNhaSanXuat(sMaNSX, sTenNSX, sDiaChi, sDienThoai);
            if (kq == false)
            {
                MessageBox.Show("Thêm NSX không thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Đã thêm NSX thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
