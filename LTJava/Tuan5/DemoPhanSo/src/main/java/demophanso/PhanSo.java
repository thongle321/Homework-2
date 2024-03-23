/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package demophanso;

import java.util.Scanner;

/**
 *
 * @author SV
 */
public class PhanSo {
    private int tu;
    private int mau;
    

    public PhanSo() {
    }

    public PhanSo(int tu, int mau) {
        this.tu = tu;
        this.mau = mau;
    }

    public int getTu() {
        return tu;
    }

    public void setTu(int tu) {
        this.tu = tu;
    }

    public int getMau() {
        return mau;
    }

    public void setMau(int mau) {
        this.mau = mau;
    }
    public void nhap(PhanSo ps){
        Scanner input = new Scanner(System.in);
        System.out.println("Nhap tu 1: ");
        this.tu = Integer.parseInt(input.nextLine());
        System.out.println("Nhap mau 1: ");
        this.mau = Integer.parseInt(input.nextLine());
        System.out.println("Nhap tu 2: ");
        ps.tu = Integer.parseInt(input.nextLine());
        System.out.println("Nhap mau 2: ");
        ps.mau = Integer.parseInt(input.nextLine());
    }
    public void xuat(PhanSo ps){
        System.out.println("Phan so 1 la: " + this.tu + "/" + this.mau);
        System.out.println("Phan so 2 la: " + ps.tu + "/" + ps.mau); 
    }
    public void cong(PhanSo ps){
        int tuSo = this.getTu() * ps.getMau() + this.getMau() * ps.getTu();
        int mauSo = this.mau * ps.getMau();
        PhanSo psCong = new PhanSo(tuSo, mauSo);
        System.out.println("Tong hai phan so la: " + psCong);
    }
}
