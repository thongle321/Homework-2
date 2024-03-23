/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package demonongtrai;

import java.util.Scanner;

/**
 *
 * @author SV
 */
public abstract class GiaSuc {
    private String maSo;
    private float canNang;
    private int tuoi;

    public GiaSuc() {
        this.maSo = "";
        this.canNang = 0;
        this.tuoi = 0;
    }

    public GiaSuc(String maSo, float canNang, int tuoi) {
        this.maSo = maSo;
        this.canNang = canNang;
        this.tuoi = tuoi;
    }

    public String getMaSo() {
        return maSo;
    }

    public void setMaSo(String maSo) {
        this.maSo = maSo;
    }

    public float getCanNang() {
        return canNang;
    }

    public void setCanNang(float canNang) {
        this.canNang = canNang;
    }

    public int getTuoi() {
        return tuoi;
    }

    public void setTuoi(int tuoi) {
        this.tuoi = tuoi;
    }
    public void nhap() {
        Scanner input = new Scanner(System.in);
        System.out.println("Nhap ma so: ");
        this.maSo = input.nextLine();
        System.out.println("Nhap can nang: ");
        this.canNang = Float.parseFloat(input.nextLine());
        System.out.println("Nhap tuoi: ");
        this.tuoi = Integer.parseInt(input.nextLine());
        
    }
    public void xuat() {
        System.out.println("Ma so la: " + this.maSo);
        System.out.println("Can nang la: " + this.canNang);
        System.out.println("Tuoi la: " + this.tuoi);

    }
    public abstract float tinhLuongSua();
    
}
