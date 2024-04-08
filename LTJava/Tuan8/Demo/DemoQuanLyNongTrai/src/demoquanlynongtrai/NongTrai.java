/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package demoquanlynongtrai;

import java.util.LinkedList;
import java.util.Scanner;

/**
 *
 * @author Trinh Thanh Duy
 */
public class NongTrai {
    private LinkedList<GiaSuc> dsGiaSuc;

    public NongTrai() {
        this.dsGiaSuc = new LinkedList<GiaSuc>();
    }
    public void nhap(){
        String chon = "";
        Scanner input = new Scanner(System.in);
        do{
            GiaSuc gs = null;
            String loai = "";
            System.out.println("Nhap loai gia suc: bo-de:");
            loai = input.nextLine();
            if(loai.equals("bo"))
                gs = new Bo();
            else
                gs = new De();
            gs.nhap();
            this.dsGiaSuc.add(gs);
            
            System.out.println("Ban co muon tiep hay khong?");
            chon = input.nextLine();
            
        }while(chon.equals("y"));
    }
    public void xuat(){
        for(GiaSuc gs : this.dsGiaSuc){
            gs.xuat();
        }
    }
    
}
