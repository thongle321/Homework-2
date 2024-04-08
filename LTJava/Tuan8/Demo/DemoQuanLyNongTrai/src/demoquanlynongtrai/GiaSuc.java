/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package demoquanlynongtrai;

/**
 *
 * @author Trinh Thanh Duy
 */
public abstract class GiaSuc {
    protected String maSo;
    protected float canNang;
    protected  int tuoi;

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
    public void nhap(){
        
    }
    public void xuat(){
        
    }
    public abstract float tinhLuongSua();
    
            
}
