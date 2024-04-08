/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.demohinhchunhat_gui;

/**
 *
 * @author Levisa
 */
public class HinhChuNhat {
    private float chieuDai;
    private float chieuRong;

    public HinhChuNhat() {
        this.chieuDai = 0;
        this.chieuRong = 0;
    }

    public HinhChuNhat(float chieuDai, float chieuRong) {
        this.chieuDai = chieuDai;
        this.chieuRong = chieuRong;
    }

    public float getChieuDai() {
        return chieuDai;
    }

    public void setChieuDai(float chieuDai) {
        this.chieuDai = chieuDai;
    }

    public float getChieuRong() {
        return chieuRong;
    }

    public void setChieuRong(float chieuRong) {
        this.chieuRong = chieuRong;
    }
    
    public float tinhChuVi() {
        return (this.chieuDai + this.chieuRong) * 2;
    }
    public float tinhDienTich() {
        return this.chieuDai * this.chieuRong;
    }
}
