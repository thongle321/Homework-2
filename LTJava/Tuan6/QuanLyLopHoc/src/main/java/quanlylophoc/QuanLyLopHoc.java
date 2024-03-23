/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package quanlylophoc;

import java.util.LinkedList;

/**
 *
 * @author Levisa
 */
public class QuanLyLopHoc {

    public static void main(String[] args) {
        LopHoc lop = new LopHoc();
        lop.nhap();
        lop.xuat();
        lop.timHocSinhTheoMa();
        lop.timHocSinhTheoTen();
        LinkedList<HocSinh> dsHocSinhGioi = lop.timHocSinhGioi();
        System.out.println("Danh sách học sinh giỏi:");
        lop.xuat(dsHocSinhGioi);
        lop.sapXepHocSinhTheoDiemTrungBinh();
        System.out.println("Danh sách học sinh sau khi sắp xếp theo điểm trung bình:");
        lop.xuat();
        lop.sapXepHocSinhTheoTen();
        System.out.println("Danh sách học sinh sau khi sắp xếp theo tên:");
        lop.xuat();
    }
}
