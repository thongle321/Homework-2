/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package demonongtrai;

import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;
import java.util.Scanner;

/**
 *
 * @author SV
 */
public class NongTrai {
    LinkedList<GiaSuc> NongTraiGiaSuc;

    public NongTrai() {
        this.NongTraiGiaSuc = new LinkedList<GiaSuc>();

    }

    public NongTrai(LinkedList<GiaSuc> NongTraiGiaSuc) {
        this.NongTraiGiaSuc = NongTraiGiaSuc;
    }

    public LinkedList<GiaSuc> getNongTraiGiaSuc() {
        return NongTraiGiaSuc;
    }

    public void setNongTraiGiaSuc(LinkedList<GiaSuc> NongTraiGiaSuc) {
        this.NongTraiGiaSuc = NongTraiGiaSuc;
    }
    public void nhap() {
        Scanner input = new Scanner(System.in);
        String chon = null;
        int loai = 0;
        do {
            GiaSuc gs = null;
            System.out.println("Nhap loai gia suc (1. bo 2.de): ");
            loai = Integer.parseInt(input.nextLine());
            if(loai == 1) {
                gs = new Bo();
            }
            else if (loai == 2) {
                gs = new De();
            }
            this.NongTraiGiaSuc.add(gs);
            System.out.println("Ban co muon tiep tuc khong");
            chon = input.nextLine();
        } while (chon.equals("y"));
    }
    public void xuat() {
        for(GiaSuc gs : this.NongTraiGiaSuc) {
            gs.xuat();
        }
    }
    public void xuat(LinkedList<GiaSuc> ds) {
        for (GiaSuc gs : ds) {
            gs.xuat();
        }
    }
    public float tinhTongLuongSuaBo() {
        float tong = 0;
        for(GiaSuc gs : this.NongTraiGiaSuc) {
            if(gs instanceof Bo) {
                tong += tinhTongLuongSuaBo();
            }
        }
        return tong;
    }
    public float tinhTongLuongSuaDe() {
        float tong = 0;
        for(GiaSuc gs : this.NongTraiGiaSuc) {
            if(gs instanceof De) {
                tong += tinhTongLuongSuaDe();
            }
        }
        return tong;
    }
}
