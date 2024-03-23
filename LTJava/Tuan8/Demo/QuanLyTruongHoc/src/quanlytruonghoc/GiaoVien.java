/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package quanlytruonghoc;

import java.time.LocalDateTime;
import java.util.Scanner;

/**
 *
 * @author Trinh Thanh Duy
 */
public class GiaoVien extends Nguoi{
    private int namBatDau;
    private String chuyenMon;

    public GiaoVien() {
        
    }

    public GiaoVien(String hoTen, int namSinh, String noiSinh, String diaChi) {
        super(hoTen, namSinh, noiSinh, diaChi);
    }
    public void nhap(){
        super.nhap();
        Scanner input = new Scanner(System.in);
        System.out.println("Nhap nam bat dau:");
        this.namBatDau = Integer.parseInt(input.nextLine());
        System.out.println("Nhap chuyen mon:");
        this.chuyenMon = input.nextLine();
        
    }
    public void xuat(){
        super.xuat();
        System.out.println("Nam bat dau:" + this.namBatDau);
        System.out.println("Chuyen mon: " + this.chuyenMon);
    }
    public int tinhThamNien(){
        return LocalDateTime.now().getYear() - this.namBatDau;
              
    }
}
