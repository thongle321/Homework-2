using System.Diagnostics.Tracing;

namespace _0306221377_LeNguyenHoangThong
{
    public partial class Form1 : Form
    {
        float TongThanhTien = 0;
        int TongSoLuong = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_TongTien.ReadOnly = true;
            txt_TongSoLuongCD.ReadOnly = true;
            txt_TB.ReadOnly = true;
            btn_XemThongKe.Enabled = false;
        }

        private void btn_TinhThue_Click(object sender, EventArgs e)
        {
            int gia, soluong;
            int soCDKhuyenMai;
            float thanhtien;
            soluong = int.Parse(txt_SoLuongCD.Text);
            gia = int.Parse(txt_DonGia.Text);
            thanhtien = soluong * gia;
            soCDKhuyenMai = soluong / 5;
            if (soCDKhuyenMai > 0)
            {
                thanhtien = (soluong - soCDKhuyenMai) * gia;
            }
            if (chk_DungHan.Checked)
            {
                thanhtien = thanhtien - (float)0.03 * thanhtien;
            }
            txt_ThanhTien.Text = thanhtien.ToString();
            TongThanhTien = TongThanhTien + thanhtien;
            TongSoLuong = TongSoLuong + (soluong - soCDKhuyenMai);
            txt_MaKH.Enabled = false;
            txt_HoTenKH.Enabled = false;
            btn_XemThongKe.Enabled = true;
        }

        private void btn_KhachMoi_Click(object sender, EventArgs e)
        {
            txt_MaKH.Clear();
            txt_HoTenKH.Clear();
            txt_DonGia.Clear();
            txt_SoLuongCD.Clear();
            txt_ThanhTien.Clear();
            chk_DungHan.Checked = false;
            txt_TongTien.Clear();
            txt_TongSoLuongCD.Clear();
            txt_TB.Clear();
            txt_MaKH.Enabled = true;
            txt_HoTenKH.Enabled = true;
            TongThanhTien = 0;
            TongSoLuong = 0;
        }

        private void btn_XemThongKe_Click(object sender, EventArgs e)
        {
            txt_TongTien.Text = TongThanhTien.ToString();
            txt_TongSoLuongCD.Text = TongSoLuong.ToString();
            float TB = TongThanhTien / TongSoLuong;
            txt_TB.Text = TB.ToString();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dlg;
            dlg = MessageBox.Show("Bạn có muốn thoát không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}