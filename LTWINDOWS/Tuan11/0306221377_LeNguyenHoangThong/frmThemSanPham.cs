﻿using System;
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
    public partial class frmThemSanPham : Form
    {
        public frmThemSanPham()
        {
            InitializeComponent();
        }
        public bool ThemSanPham(string sMaSanPham, string sTenSanPham, string sMaNSX, int iDonGia, int iSoLuong, string sNgaySX)
        {
            bool kq;

            kq = true;

            string scon;
            scon = "Data Source=DESKTOP-676STPK\\SQLEXPRESS;Initial Catalog=CuaHangDB;Integrated Security=True;Encrypt=False";
            SqlConnection myConnection = new SqlConnection(scon);

            string sSql;
            sSql = "INSERT INTO SanPham VALUES (";
            sSql += "'" + sMaSanPham + "',";
            sSql += "N'" + sTenSanPham + "',";
            sSql += "'" + sMaNSX + "',";
            sSql += iDonGia + ",";
            sSql += iSoLuong + ",";
            sSql += "'" + sNgaySX + "')";
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

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            string sMaSP, sTenSP, sMaNSX, sNgaySX;
            int iDonGia, iSoLuong;
            sMaSP = txt_MaSanPham.Text;
            sTenSP = txt_TenSP.Text;
            sMaNSX = txt_MaNhaSanXuat.Text;
            iDonGia = int.Parse(txt_DonGia.Text);
            iSoLuong = int.Parse(txt_SoLuong.Text);
            sNgaySX = txt_NgaySanXuat.Text + " 00:00:00.000";
            bool kq = ThemSanPham(sMaSP, sTenSP, sMaNSX, iDonGia, iSoLuong, sNgaySX);
            if (kq == false)
            {
                MessageBox.Show("Thêm không thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Đã thêm sản phẩm thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
