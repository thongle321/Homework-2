/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package demohinhtron;

import java.util.Scanner;

/**
 *
 * @author SV
 */
public class HinhTron {
    private double radius;

    public HinhTron() {
        this.radius = 0;

    }

    public HinhTron(double radius) {
        this.radius = radius;
    }

    public double getRadius() {
        return radius;
    }

    public void setRadius(double radius) {
        this.radius = radius;
    }
    public void nhap(){
        Scanner input = new Scanner(System.in);
        System.out.println("Nhap ban kinh: ");
        this.radius = Double.parseDouble(input.nextLine());
    }
    public void xuat(){
        System.out.println("Ban kinh la: " + this.radius);
    }
    public double tinhChuVi(){
        return 2 * Math.PI * this.radius;
    }
    public double tinhDienTich(){
        return Math.PI * Math.pow(radius, 2);
    }
}
