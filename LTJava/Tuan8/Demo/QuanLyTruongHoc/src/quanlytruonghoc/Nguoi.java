/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package quanlytruonghoc;

/**
 *
 * @author Trinh Thanh Duy
 */
public class Nguoi {
    protected String hoTen;
    protected int namSinh;
    protected String noiSinh;
    protected String diaChi;

    public Nguoi() {
        this.hoTen = "";
        this.namSinh = 0;
        this.noiSinh = "";
        this.diaChi = "";
    }

    public Nguoi(String hoTen, int namSinh, String noiSinh, String diaChi) {
        this.hoTen = hoTen;
        this.namSinh = namSinh;
        this.noiSinh = noiSinh;
        this.diaChi = diaChi;
    }

    public String getHoTen() {
        return hoTen;
    }

    public void setHoTen(String hoTen) {
        this.hoTen = hoTen;
    }

    public int getNamSinh() {
        return namSinh;
    }

    public void setNamSinh(int namSinh) {
        this.namSinh = namSinh;
    }

    public String getNoiSinh() {
        return noiSinh;
    }

    public void setNoiSinh(String noiSinh) {
        this.noiSinh = noiSinh;
    }

    public String getDiaChi() {
        return diaChi;
    }

    public void setDiaChi(String diaChi) {
        this.diaChi = diaChi;
    }
    public void nhap(){
        
    }
    public void xuat(){
        
    }
}
