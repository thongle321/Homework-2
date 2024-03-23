/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package demotruonghoc;

import java.util.LinkedList;
import java.util.Scanner;

/**
 *
 * @author SV
 */
public class TruongHoc {
    private LinkedList<Nguoi> ds;
    private int soLuong;

    public TruongHoc(){
        this.ds = new LinkedList<Nguoi>();
    }

    public TruongHoc(LinkedList<Nguoi> ds) {
        this.ds = ds;
    }

    public LinkedList<Nguoi> getDs() {
        return ds;
    }

    public void setDs(LinkedList<Nguoi> ds) {
        this.ds = ds;
    }

    public int getSoLuong() {
        return soLuong;
    }

    public void setSoLuong(int soLuong) {
        this.soLuong = soLuong;
    }
    
    public void nhap() {
        Scanner input = new Scanner(System.in);
        Nguoi nguoi = new Nguoi();
        String chon = null;
        int loai = 0;
        System.out.println("Nhap so luong nguoi: ");
        soLuong = Integer.parseInt(input.nextLine());
        for (int i = 0; i < soLuong; i++) {
            nguoi = null;
            System.out.println("Nhap loai (1. hoc sinh, 2. giao vien)");
            loai = Integer.parseInt(input.nextLine());
            if (loai == 1) {
                nguoi = new HocSinh();
            }
            else if (loai == 2) {
                nguoi = new GiaoVien();
            }
            nguoi.nhap();
            this.ds.add(nguoi);
        }
    }
    public void xuat() {
        for(Nguoi nguoi: ds) {
            nguoi.xuat();
        }
    }
    public void xuat(LinkedList<HocSinh> dsHocSinh) {
        for(HocSinh hs: dsHocSinh) {
            hs.xuat();
        }
    }
    public float timDiemTrungBinhCaoNhat(){
        float diemTrungBinhMax=0;
        for(Nguoi nguoi:this.ds){
            if(nguoi instanceof HocSinh){
                if( ((HocSinh) nguoi).diemTrungBinh() > diemTrungBinhMax )
                    diemTrungBinhMax = ((HocSinh) nguoi).diemTrungBinh();
            }
        }
        return diemTrungBinhMax;
    }
    public int timThamNienCaoNhat() {
        int thamNien = 0;
        for (Nguoi nguoi: this.ds) {
            if(nguoi instanceof GiaoVien) {
                if(thamNien > ((GiaoVien)nguoi).tinhThamNien()) {
                    thamNien = ((GiaoVien) nguoi).tinhThamNien();
                }
            }
        }
        return thamNien;
    }
}
