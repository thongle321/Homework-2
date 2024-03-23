/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package quanlylophoc;
import java.util.Collections;
import java.util.Comparator;
import java.util.LinkedList;
import java.util.Scanner;

/**
 *
 * @author Levisa
 */
public class LopHoc {
    private String tenLop;
    private LinkedList<HocSinh> dsHocSinh;

    public LopHoc() {
        this.tenLop = "";
        this.dsHocSinh = new LinkedList<>();
    }

    public LopHoc(String tenLop, LinkedList<HocSinh> dsHocSinh) {
        this.tenLop = tenLop;
        this.dsHocSinh = dsHocSinh;
    }

    public String getTenLop() {
        return tenLop;
    }

    public void setTenLop(String tenLop) {
        this.tenLop = tenLop;
    }

    public LinkedList<HocSinh> getDsHocSinh() {
        return dsHocSinh;
    }

    public void setDsHocSinh(LinkedList<HocSinh> dsHocSinh) {
        this.dsHocSinh = dsHocSinh;
    }
    public void nhap() {
        String chon = null;
        Scanner input = new Scanner(System.in);
        do {            
            HocSinh hs = new HocSinh();
            hs.nhap();
            this.dsHocSinh.add(hs);
            System.out.println("Ban co muon tiep tuc khong?");
            chon = input.nextLine();
        } while (chon.equals("c"));
    }
    public void xuat() {
        //for(int i = 0;i < this.dsHocSinh.size();i++) {
        //    this.dsHocSinh.get(i).xuat();
        //}
        //foreach - C#
        for(HocSinh hs : this.dsHocSinh) {
            hs.xuat();
        }
    }
    
    public LinkedList<HocSinh> timHocSinhTheoTen() {
        LinkedList<HocSinh> dsKetQua = new LinkedList<>();
        Scanner input = new Scanner(System.in);
        System.out.println("Nhập tên cần tìm: ");
        String tenCanTim = input.nextLine();
        for (HocSinh hs : this.dsHocSinh) {
            if (hs.tachTen().equals(tenCanTim)) {
                dsKetQua.add(hs);
            }
        }
        if(dsKetQua.isEmpty()) {
            System.out.println("Không tìm thấy học sinh tên là: " + tenCanTim);
        }
        else {
            System.out.println("Tìm thấy học sinh tên là: " + tenCanTim);
        }
        return dsKetQua;
    }
    
    public LinkedList<HocSinh> timHocSinhTheoMa() {
        LinkedList<HocSinh>  dsKetQua = new LinkedList<>();
        Scanner input = new Scanner(System.in);
        System.out.println("Nhập mã cần tìm: ");
        String maCanTim = input.nextLine();
        for(HocSinh hs : this.dsHocSinh) {
            if(hs.getMaHocSinh().equals(maCanTim)) {
                dsKetQua.add(hs);
            }
        }
        if(dsKetQua.isEmpty()) {
            System.out.println("Không tìm thấy học sinh có mã là: " + maCanTim);
        }
        else {
            System.out.println("Tìm thấy mã học sinh là: " + maCanTim);
        }
        return dsKetQua;
    }
    
    public LinkedList<HocSinh> timHocSinhGioi() {
    LinkedList<HocSinh> dsHocSinhGioi = new LinkedList<>();
    for (HocSinh hs : dsHocSinh) {
        String xepLoai = hs.xepLoai();
        if (xepLoai.equals("Giỏi")) {
            dsHocSinhGioi.add(hs);
            }
        }
    return dsHocSinhGioi; 
    }
    
    public void sapXepHocSinhTheoDiemTrungBinh() {
        Collections.sort(dsHocSinh, (HocSinh hs1, HocSinh hs2) -> Float.compare(hs1.tinhDiemTrungBinh(), hs2.tinhDiemTrungBinh()));
    }
    
    public void sapXepHocSinhTheoTen() {
        Collections.sort(dsHocSinh, (HocSinh hs1, HocSinh hs2) -> hs1.tachTen().compareTo(hs2.tachTen()));
    }
    
    public void xuat(LinkedList<HocSinh> danhSach) {
        for (HocSinh hs : danhSach) {
            hs.xuat();
        }
    }
//    public float tinhDiemTrungBinhChung() {
//        float tongDiem = 0;
//        for(HocSinh hs : dsHocSinh) {
//            tongDiem += hs.tinhDiemTrungBinh();
//        }
//        return tongDiem / dsHocSinh.size();
//    }
//    
//    public LinkedList<HocSinh> timHocSinhCoDiemTrungBinhMax() {
//        float diemTrungBinhChung = tinhDiemTrungBinhChung();
//        LinkedList<HocSinh> dsHocSinhMax = new LinkedList<>();
//        for (HocSinh hs : dsHocSinh) {
//            if (hs.tinhDiemTrungBinh() > diemTrungBinhChung) {
//                dsHocSinhMax.add(hs);
//            }
//        }
//        return dsHocSinhMax;
//    }

}
