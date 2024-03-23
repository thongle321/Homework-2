/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package demotruonghoc;

import java.util.Scanner;

/**
 *
 * @author SV
 */
public class HocSinh extends Nguoi {
    private float diemToan;
    private float diemVan;
    private float diemNgoaiNgu;

    public HocSinh() {
        this.diemToan = 0;
        this.diemVan = 0;
        this.diemNgoaiNgu = 0;
    }

    public HocSinh(float diemToan, float diemVan, float diemNgoaiNgu) {
        this.diemToan = diemToan;
        this.diemVan = diemVan;
        this.diemNgoaiNgu = diemNgoaiNgu;
    }

    public HocSinh(float diemToan, float diemVan, float diemNgoaiNgu, String hoTen, int namSinh, String noiSinh, String diaChi) {
        super(hoTen, namSinh, noiSinh, diaChi);
        this.diemToan = diemToan;
        this.diemVan = diemVan;
        this.diemNgoaiNgu = diemNgoaiNgu;
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

    public float getDiemNgoaiNgu() {
        return diemNgoaiNgu;
    }

    public void setDiemNgoaiNgu(float diemNgoaiNgu) {
        this.diemNgoaiNgu = diemNgoaiNgu;
    }
    
    @Override
    public void nhap() {
        Scanner input = new Scanner(System.in);
        super.nhap();
        System.out.println("Nhap diem toan: ");
        this.diemToan = Float.parseFloat(input.nextLine());
        System.out.println("Nhap diem van: ");
        this.diemVan = Float.parseFloat(input.nextLine());
        System.out.println("Nhap diem ngoai ngu");
        this.diemNgoaiNgu = Float.parseFloat(input.nextLine());
    }
    @Override
    public void xuat() {
        super.xuat();
        System.out.println("Diem toan la: " + this.diemToan);
        System.out.println("Diem van la: " + this.diemVan);
        System.out.println("Diem ngoai ngu la: " + this.diemNgoaiNgu);
    }
    public float diemTrungBinh() {
        return (this.diemToan + this.diemVan + this.diemNgoaiNgu) /3;
    }
}
