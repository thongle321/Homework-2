/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.demohocsinh_gui;

/**
 *
 * @author Levisa
 */
public class HocSinh {
    private String maHocSinh;
    private String hoTen;
    private float diemToan;
    private float diemVan;

    public HocSinh() {
        this.maHocSinh = null;
        this.hoTen = null;
        this.diemToan = 0;
        this.diemVan = 0;
    }

    public HocSinh(String maHocSinh, String hoTen, float diemToan, float diemVan) {
        this.maHocSinh = maHocSinh;
        this.hoTen = hoTen;
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
