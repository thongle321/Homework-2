/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package demongaytruocngaysau;

/**
 *
 * @author SV
 */
public class NgayThangNam {
    protected int ngay, thang, nam;

    public NgayThangNam() {
        this.ngay = 0;
        this.thang = 0;
        this.nam = 0;
    }

    public NgayThangNam(int ngay, int thang, int nam) {
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
    public NgayThangNam ngayTruoc() {
        NgayThangNam ngayTruoc = new NgayThangNam();
        ngayTruoc.ngay = this.ngay - 1;
        if(ngayTruoc.ngay <= 0) {
            ngayTruoc.ngay = timNgayToiDa(this.thang - 1, this.nam - 1);
            ngayTruoc.thang = this.thang - 1;
            if (ngayTruoc.thang <= 0) {
                ngayTruoc.ngay = 1;
                ngayTruoc.thang = 12;
                ngayTruoc.nam = this.nam - 1;
            }
            else {
                ngayTruoc.nam = this.nam;   
            }
        } else {
            ngayTruoc.thang = this.thang;
            ngayTruoc.nam = this.nam;
        }
        return ngayTruoc;
    }
    public NgayThangNam ngaySau() {
        NgayThangNam ngaySau = new NgayThangNam();
        ngaySau.ngay = this.ngay + 1;
        if(ngaySau.ngay > timNgayToiDa(thang, nam)) {
            ngaySau.ngay  = 1;
            ngaySau.thang = this.thang + 1;
            if(ngaySau.thang > 12) {
                ngaySau.thang = 1;
                ngaySau.nam = this.nam + 1;
            }
            else {
                ngaySau.nam = this.nam;
            }
        } else {
            ngaySau.thang = this.thang;
            ngaySau.nam = this.nam;
        }
        return ngaySau;
    }
    public int timNgayToiDa(int thang, int nam) {
        int ngayToiDa = 0;
        int [] maNgayToiDa = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        if(nam % 4 == 0 && nam % 100 != 0 || nam % 400 == 0) {
            maNgayToiDa[2] = 29; 
        }
        ngayToiDa = maNgayToiDa[thang];
        return ngayToiDa;
    }
}
