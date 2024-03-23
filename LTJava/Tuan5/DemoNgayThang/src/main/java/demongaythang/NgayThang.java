/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package demongaythang;

/**
 *
 * @author SV
 */
public class NgayThang {
    private int ngay;
    private int thang;
    private int nam;

    public NgayThang() {
        this.ngay = 0;
        this.thang = 0;
        this.nam = 0;
    }

    public NgayThang(int ngay, int thang, int nam) {
        this.ngay = ngay;
        this.thang = thang;
        this.nam = nam;
    }

    public int getNgay() {
        return ngay;
    }

    public void setNgay(int ngay) {
        this.ngay = ngay;
    }

    public int getThang() {
        return thang;
    }

    public void setThang(int thang) {
        this.thang = thang;
    }

    public int getNam() {
        return nam;
    }

    public void setNam(int nam) {
        this.nam = nam;
    }
    public NgayThang ngayTruoc(){
        NgayThang ngayTruoc = new NgayThang();
        ngayTruoc.ngay = this.ngay - 1;
        if(ngayTruoc.ngay <= 0){
            ngayTruoc.ngay = timNgayToiDa(this.thang - 1);
            ngayTruoc.thang = this.thang - 1;
            if(ngayTruoc.thang <= 0)
            {
                ngayTruoc.thang = 12;
                ngayTruoc.nam = this.nam - 1;
            }
            else {
            }
        }
        else{
            
        }
        return ngayTruoc;
    }
    public NgayThang ngaySau(){
        NgayThang ngaySau = new NgayThang();
        return ngaySau;
    }
    private int timNgayToiDa(int thang){
    }
}
