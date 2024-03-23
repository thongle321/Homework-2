/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.demohinhchunhat;

import java.util.Scanner;

/**
 *
 * @author SV
 */
public class HinhChuNhat {
    private float chieuDai;
    private float chieuRong;
    public HinhChuNhat() {
        this.chieuDai = 0;
        this.chieuRong = 0;
    }

    public HinhChuNhat(float chieuDai, float chieuRong) {
        this.chieuDai = chieuDai;
        this.chieuRong = chieuRong;
    }

    public double getChieuDai() {
        return chieuDai;
    }

    public void setChieuDai(float chieuDai) {
        this.chieuDai = chieuDai;
    }

    public double getChieuRong() {
        return chieuRong;
    }

    public void setChieuRong(float chieuRong) {
        this.chieuRong = chieuRong;
    }
    public void nhap(){
        Scanner input = new Scanner(System.in);
        System.out.println("Nhap chieu dai: ");
        this.chieuDai = Float.parseFloat(input.nextLine());
        System.out.println("Nhap chieu rong: ");
        this.chieuRong = Float.parseFloat(input.nextLine());
    }
    public void xuat(){
        System.out.println("Chieu dai la: " + this.chieuDai);
        System.out.println("Chieu rong la: " + this.chieuRong);
    }
    public float tinhChuVi(){
        return (this.chieuDai + this.chieuRong) * 2;
    }
    public float tinhDienTich(){
        return this.chieuDai * this.chieuRong;
    }
}
