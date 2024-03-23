/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.demohinhchunhat;

/**
 *
 * @author SV
 */
public class DemoHinhChuNhat {

    public static void main(String[] args) {
        HinhChuNhat hcn = new HinhChuNhat();
        hcn.nhap();
        hcn.xuat();
        float chuVi = hcn.tinhChuVi();
        float dienTich = hcn.tinhDienTich();
        System.out.println("Chu vi la: " + chuVi);
        System.out.println("Dien tich la: " + dienTich);
    }
}
