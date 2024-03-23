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
public class Nguoi {
    protected String hoTen;
    protected int namSinh;
    protected String noiSinh;
    protected String diaChi;

    public Nguoi() {
        this.hoTen = "";
        this.namSinh = 0;
        this.noiSinh = "";
        this.diaChi = "";
    }

    public Nguoi(String hoTen, int namSinh, String noiSinh, String diaChi) {
        this.hoTen = hoTen;
        this.namSinh = namSinh;
        this.noiSinh = noiSinh;
        this.diaChi = diaChi;
    }

    public String getHoTen() {
        return hoTen;
    }

    public void setHoTen(String hoTen) {
        this.hoTen = hoTen;
    }

    public int getNamSinh() {
        return namSinh;
    }

    public void setNamSinh(int namSinh) {
        this.namSinh = namSinh;
    }

    public String getNoiSinh() {
        return noiSinh;
    }

    public void setNoiSinh(String noiSinh) {
        this.noiSinh = noiSinh;
    }

    public String getDiaChi() {
        return diaChi;
    }

    public void setDiaChi(String diaChi) {
        this.diaChi = diaChi;
    }
    public void nhap(){
        Scanner input = new Scanner(System.in);
        System.out.println("Nhap ho va ten: ");
        this.hoTen = input.nextLine();
        System.out.println("Nhap nam sinh: ");
        this.namSinh = Integer.parseInt(input.nextLine());
        System.out.println("Nhap noi sinh: ");
        this.noiSinh = input.nextLine();
        System.out.println("Nhap dia chi: ");
        this.diaChi = input.nextLine();
    }
    public void xuat(){
        System.out.println("Ho va ten la: " + this.hoTen);
        System.out.println("Nam sinh la: " + this.namSinh);
        System.out.println("Noi sinh la: " + this.noiSinh);
        System.out.println("Dia chi la: " + this.diaChi);
    }
}
