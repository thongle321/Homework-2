/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package quanlylophoc;

import java.util.Scanner;

/**
 *
 * @author Levisa
 */
public class HocSinh {
    private String maHocSinh;
    private String hoTen;
    private String gioiTinh;
    private float diemToan;
    private float diemVan;

    public HocSinh() {
        this.maHocSinh = "";
        this.hoTen = "";
        this.gioiTinh = "";
        this.diemToan = 0;
        this.diemVan = 0;
    }

    public HocSinh(String maHocSinh, String hoTen, String gioiTinh, float diemToan, float diemVan) {
        this.maHocSinh = maHocSinh;
        this.hoTen = hoTen;
        this.gioiTinh = gioiTinh;
        this.diemToan = diemToan;
        this.diemVan = diemVan;
    }

    public String getMaHocSinh() {
        return maHocSinh;
    }

    public void setMaHocSinh(String maHocSinh) {
        this.maHocSinh = maHocSinh;
    }

    public String getHoTen() {
        return hoTen;
    }

    public void setHoTen(String hoTen) {
        this.hoTen = hoTen;
    }

    public String getGioiTinh() {
        return gioiTinh;
    }

    public void setGioiTinh(String gioiTinh) {
        this.gioiTinh = gioiTinh;
    }

    public float getDiemToan() {
        return diemToan;
    }

    public void setDiemToan(float diemToan) {
        this.diemToan = diemToan;
    }

    public float getDiemVan() {
        return diemVan;
    }

    public void setDiemVan(float diemVan) {
        this.diemVan = diemVan;
    }

    
    public void nhap() {
        Scanner input = new Scanner(System.in);
        System.out.println("Nhap mã học sinh: ");
        this.maHocSinh = input.nextLine();
        System.out.println("Nhập họ tên: ");
        this.hoTen = input.nextLine();
        System.out.println("Nhập giới tính: ");
        this.gioiTinh = input.nextLine();
        System.out.println("Nhập điểm toán: ");
        this.diemToan = Float.parseFloat(input.nextLine());
        System.out.println("Nhập điểm văn: ");
        this.diemVan = Float.parseFloat(input.nextLine());
    }
    public void xuat() {
        System.out.println("Ma hoc sinh: " + this.maHocSinh);
        System.out.println("Ho ten: " + this.hoTen);
        System.out.println("Gioi tinh: " + this.gioiTinh);
        System.out.println("Diem toan: " + this.diemToan);
        System.out.println("Diem van: " + this.diemVan);
    }
    public float tinhDiemTrungBinh() {
        return (this.diemToan + this.diemVan) / 2;
    }
    public String xepLoai() {
        String loai = null;
        float diemTB = tinhDiemTrungBinh();
        if (diemTB >= 8) {
            loai = "Giỏi";
        }
        else if (diemTB >= 7 && diemTB < 8) {
            loai = "Khá";
        }
        else if (diemTB >=5 && diemTB < 7) {
            loai = "Trung Bình";
        }
        else {
            loai = "Yêú";
        }
        return loai;
    }
    public String tachTen() {
        int viTriKhoangTrangCuoi = this.hoTen.trim().lastIndexOf(" ");
        return this.hoTen.substring(viTriKhoangTrangCuoi + 1);
    }
}
