/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package quanlytruonghoc;

import java.util.LinkedList;

/**
 *
 * @author Trinh Thanh Duy
 */
public class QuanLyTruongHoc {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        TruongHoc truong = new TruongHoc();
        truong.nhap();
        truong.xuat();
        
        float diemTrungBinhMax = truong.timDiemTrungBinhCaoNhat();
        LinkedList<HocSinh> dsHocSinhCoDiemTrungBinhMax = new LinkedList<HocSinh>();
        dsHocSinhCoDiemTrungBinhMax = truong.timHocSinhCoDiemTrungBinhMax();
        
        System.out.println("Danh sach hoc sinh co DTB max la:");
        truong.xuat(dsHocSinhCoDiemTrungBinhMax);
        
    }
    
}
