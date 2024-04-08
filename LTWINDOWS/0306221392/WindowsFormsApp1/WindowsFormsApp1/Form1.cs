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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public SqlConnection sqlConn()
        {
            string conn;
            conn = "Data Source=.;Initial Catalog=CuaHangDB;Integrated Security=True";
            
            SqlConnection sqlConnection = new SqlConnection(conn);

            return sqlConnection;
        }

        public void gridHienKetQua(SqlConnection sqlConnection, string sSQL)
        {
            try
            {
                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sSQL, sqlConnection);

                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);

                sqlConnection.Close();

                grid_ketQua.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        public void xemDSsanPham()
        {
            SqlConnection sqlConnection = sqlConn();

            string sSQL = "select * from SanPham";

            gridHienKetQua(sqlConnection, sSQL);
            
        }

        private void btn_sanPham_Click(object sender, EventArgs e)
        {
            xemDSsanPham();
        }

        private void lietKeNhaSanXuat()
        {
            SqlConnection sqlConnection = sqlConn();

            string sSQL = "select * from NhaSanXuat";

            gridHienKetQua(sqlConnection, sSQL);
            
            
        }

        private void btn_nhaSanXuat_Click(object sender, EventArgs e)
        {
            lietKeNhaSanXuat();
        }

        private void lietKeSPGiaHon1trieu()
        {
            SqlConnection sqlConnection = sqlConn();

            string sSQL = "Select * from SanPham where DonGia >= 1000000";

        
            gridHienKetQua(sqlConnection, sSQL);
            
        }

        private void btn_lietkeSPgiaHon1trieu_Click(object sender, EventArgs e)
        {
            lietKeSPGiaHon1trieu();
        }

        public void lietKeSanPhamMaxSoLuong()
        {
            SqlConnection sqlConnection = sqlConn();

            string sSQL = "select * from SanPham " +
                "where SoLuong >= (Select MAX(SoLuong) " +
                "from SanPham)";

                gridHienKetQua(sqlConnection, sSQL);
        }

        private void btn_maxSanPham_Click(object sender, EventArgs e)
        {
            lietKeSanPhamMaxSoLuong();
        }

        public void minGia()
        {
            SqlConnection sqlConnection = sqlConn();

            string sSQL = "select * from SanPham " +
                "where DonGia <= (Select MIN(DonGia) " +
                                 "from SanPham)";

            gridHienKetQua(sqlConnection, sSQL);
        }

        private void btn_sanPhamMinDonGia_Click(object sender, EventArgs e)
        {
            minGia();
        }

        private void comBox_nhaSX_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void lietKeNSS()
        {
            SqlConnection sqlConnection = sqlConn();

            String s = comBox_nhaSX.Text;

            string sSQL = "select * from SanPham where MaNhaSanXuat = (select MaNhaSanXuat " +
                            "from NhaSanXuat where TenNhaSanXuat = '" + s + "')";

            gridHienKetQua(sqlConnection, sSQL);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comBox_nhaSX.Items.Add("Intel");
            comBox_nhaSX.Items.Add("Gigabyte");
            comBox_nhaSX.Items.Add("KingMax");
            comBox_nhaSX.Items.Add("Seagate");
            comBox_nhaSX.Items.Add("Samsung");

        }

        private void btn_lietKeNSScomboBx_Click(object sender, EventArgs e)
        {
            lietKeNSS();
        }
    }
}
