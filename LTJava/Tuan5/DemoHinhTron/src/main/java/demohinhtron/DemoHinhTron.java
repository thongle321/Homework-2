/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package demohinhtron;

/**
 *
 * @author SV
 */
public class DemoHinhTron {

    public static void main(String[] args) {
        HinhTron ht = new HinhTron();
        ht.nhap();
        ht.xuat();
        double chuVi = ht.tinhChuVi();
        double dienTich = ht.tinhDienTich();
        System.out.println("Chu vi hinh tron la: " + chuVi);
        System.out.println("Dien tich hinh tron la: " + dienTich);
    }
}
