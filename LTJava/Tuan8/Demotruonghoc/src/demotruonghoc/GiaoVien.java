/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package demotruonghoc;

import java.time.LocalDate;
import java.time.LocalDateTime;
import java.time.Year;
import java.util.Date;
import java.util.Scanner;
import javax.print.attribute.standard.DateTimeAtCompleted;

/**
 *
 * @author SV
 */
public class GiaoVien extends Nguoi {
    private int namBatDau;
    private String chuyenMon;

    public GiaoVien() {
        this.namBatDau = 0;
        this.chuyenMon = "";
    }

    public GiaoVien(int namBatDau, String chuyenMon) {
        this.namBatDau = namBatDau;
        this.chuyenMon = chuyenMon;
    }

    public GiaoVien(int namBatDau, String chuyenMon, String hoTen, int namSinh, String noiSinh, String diaChi) {
        super(hoTen, namSinh, noiSinh, diaChi);
        this.namBatDau = namBatDau;
        this.chuyenMon = chuyenMon;
    }

    public int getNamBatDau() {
        return namBatDau;
    }

    public void setNamBatDau(int namBatDau) {
        this.namBatDau = namBatDau;
    }

    public String getChuyenMon() {
        return chuyenMon;
    }

    public void setChuyenMon(String chuyenMon) {
        this.chuyenMon = chuyenMon;
    }
    
    @Override
    public void nhap() {
        Scanner input = new Scanner(System.in);
        super.nhap();
        System.out.println("Nhap ngay bat dau: ");
        this.namBatDau = Integer.parseInt(input.nextLine());
        System.out.println("Nhap chuyen mon: ");
        this.chuyenMon = input.nextLine();
    }
    @Override
    public void xuat() {
        super.xuat();
        System.out.println("Nam bat dau la: " + this.namBatDau);
        System.out.println("Chuyen mon la: " + this.chuyenMon);
    }
    public int tinhThamNien() {
        int namHienTai, thamNien;
        namHienTai = LocalDate.now().getYear();
        thamNien = namHienTai - this.namBatDau;
        return thamNien;
    }
}
