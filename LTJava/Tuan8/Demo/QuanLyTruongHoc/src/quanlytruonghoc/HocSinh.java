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
public class HocSinh extends Nguoi{
    private float diemToan;
    private float diemVan;
    private float diemNgoaiNgu;

    public HocSinh() {
    }

    public HocSinh(float diemToan, float diemVan, float diemNgoaiNgu) {
        this.diemToan = diemToan;
        this.diemVan = diemVan;
        this.diemNgoaiNgu = diemNgoaiNgu;
    }

    public HocSinh(float diemToan, float diemVan, float diemNgoaiNgu, String hoTen, int namSinh, String noiSinh, String diaChi) {
        super(hoTen, namSinh, noiSinh, diaChi);
        this.diemToan = diemToan;
        this.diemVan = diemVan;
        this.diemNgoaiNgu = diemNgoaiNgu;
    }

    public float getDiemToan() {
        return diemToan;
    }

    public void setDiemToan(float diemToan) {
        this.diemToan = diemToan;
    }

    public float getDiemVan() {
        return diemVan;
    }

    public void setDiemVan(float diemVan) {
        this.diemVan = diemVan;
    }

    public float getDiemNgoaiNgu() {
        return diemNgoaiNgu;
    }

    public void setDiemNgoaiNgu(float diemNgoaiNgu) {
        this.diemNgoaiNgu = diemNgoaiNgu;
    }
    public float tinhDiemTrungBinh(){
        return (this.diemToan + this.diemVan + this.diemNgoaiNgu)/3;
    }
    public String xepLoai(){
        String loai = "";
        float diemTrungBinh = tinhDiemTrungBinh();
        
        return loai;
    }
}
