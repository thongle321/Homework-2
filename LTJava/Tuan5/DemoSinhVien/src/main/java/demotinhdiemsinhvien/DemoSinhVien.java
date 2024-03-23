/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package demotinhdiemsinhvien;

/**
 *
 * @author SV
 */
public class DemoSinhVien {

    public static void main(String[] args) {
        SinhVien sv = new SinhVien();
        sv.nhap();
        sv.xuat();
        double diemTB = sv.diemTB();
        String loai = sv.xepLoai();
        System.out.println("Diem trung binh la: " + diemTB);
        System.out.println("Xep loai la: " + loai);
    }
}
