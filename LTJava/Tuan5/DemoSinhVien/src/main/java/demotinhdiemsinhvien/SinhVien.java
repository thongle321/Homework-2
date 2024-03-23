/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package demotinhdiemsinhvien;

import java.util.Scanner;

/**
 *
 * @author SV
 */
public class SinhVien {
    private String hoTen;
    private double toan;
    private double van;

    public SinhVien() {
        this.hoTen = "";
        this.toan = 0;
        this.van = 0;
    }

    public SinhVien(String hoTen, double toan, double van) {
        this.hoTen = hoTen;
        this.toan = toan;
        this.van = van;
    }

    public String getHoTen() {
        return hoTen;
    }

    public void setHoTen(String hoTen) {
        this.hoTen = hoTen;
    }

    public double getToan() {
        return toan;
    }

    public void setToan(double toan) {
        this.toan = toan;
    }

    public double getVan() {
        return van;
    }

    public void setVan(double van) {
        this.van = van;
    }
    public void nhap(){
        Scanner input = new Scanner(System.in);
        System.out.println("Nhap ho va ten:");
        this.hoTen = input.nextLine();
        System.out.println("Nhap diem toan:");
        this.toan = Double.parseDouble(input.nextLine());
        System.out.println("Nhap diem van:");
        this.van = Double.parseDouble(input.nextLine());
    }
    public void xuat(){
        System.out.println("Ho va ten la: " + this.hoTen);
        System.out.println("Diem toan la: " + this.toan);
        System.out.println("Diem van la: " + this.van);
    }
    public double diemTB(){
        return (this.toan + this.van) / 2;
    }
    public String xepLoai(){
        double kq = diemTB();
        if(kq >= 8)
        {
            return "Gioi";
        }
        else if(kq < 8 && kq >= 6.5)
        {
            return "Kha";
        }
        else
        {
            return "Trung Binh";
        }
    }
}
