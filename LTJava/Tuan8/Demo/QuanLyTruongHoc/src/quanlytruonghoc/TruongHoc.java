/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package quanlytruonghoc;

import java.util.LinkedList;
import java.util.Scanner;

/**
 *
 * @author Trinh Thanh Duy
 */
public class TruongHoc {
    private LinkedList<Nguoi> dsThanhVien;

    public TruongHoc() {
        this.dsThanhVien = new LinkedList<>();
    }
    public void nhap(){
        Nguoi nguoi = new Nguoi();
        String chonTiep = "";
        String chon="";
        Scanner input = new Scanner(System.in);
        do{
            System.out.println("Ban muon nhap giao vien hay hoc sinh?-gv-hs:");
            chon = input.nextLine();
            if(chon.equals("gv"))
                nguoi = new GiaoVien();
            else if(chon.equals("hs"))
                nguoi = new HocSinh();
            
            nguoi.nhap();
            this.dsThanhVien.add(nguoi);
            
            System.out.println("Nhan y de tiep:");
            chonTiep = input.nextLine();
        }while(chonTiep.equals("y"));
    }
    public void xuat(){
        for(Nguoi ng: this.dsThanhVien){
            ng.xuat();
        }
    }
    public void xuat(LinkedList<HocSinh> dsHocSinh){
        for(HocSinh hs: dsHocSinh){
            hs.xuat();
        }            
    }
//    public void xuat(LinkedList<GiaoVien> dsGiaoVien){
//         for(GiaoVien gv: dsGiaoVien){
//            gv.xuat();
//        }
//    }
    public float timDiemTrungBinhCaoNhat(){
        float diemTrungBinhMax=0;
        for(Nguoi nguoi:this.dsThanhVien){
            if(nguoi instanceof HocSinh){
                if( ((HocSinh) nguoi).tinhDiemTrungBinh() > diemTrungBinhMax )
                    diemTrungBinhMax = ((HocSinh) nguoi).tinhDiemTrungBinh();
            }
        }
        return diemTrungBinhMax;
    }
    public LinkedList<HocSinh> timHocSinhCoDiemTrungBinhMax(){
        LinkedList<HocSinh> dsKeQua = new LinkedList<HocSinh>();
        float diemTrungBinhMax = timDiemTrungBinhCaoNhat();
        for(Nguoi nguoi:this.dsThanhVien){
            if(nguoi instanceof  HocSinh){
                if(((HocSinh) nguoi).tinhDiemTrungBinh()==diemTrungBinhMax)
                    dsKeQua.add((HocSinh)nguoi);                            
            }
        }
        return dsKeQua;
    }
}
