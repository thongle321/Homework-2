/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.demophuongtrinhbac2_gui;

/**
 *
 * @author Levisa
 */
public class PhuongTrinhBac2 {
    private float a,b,c;

    public PhuongTrinhBac2() {
        this.a = 0;
        this.b = 0;
        this.c = 0;
    }

    public PhuongTrinhBac2(float a, float b, float c) {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public float getA() {
        return a;
    }

    public void setA(float a) {
        this.a = a;
    }

    public float getB() {
        return b;
    }

    public void setB(float b) {
        this.b = b;
    }

    public float getC() {
        return c;
    }

    public void setC(float c) {
        this.c = c;
    }
    
    public String giaiPTBac2() {    
    StringBuilder result = new StringBuilder();
    if (this.a == 0) {
        if (this.b == 0) {
            result.append("Phương trình vô nghiệm!");
        } else {
            result.append("Phương trình có một nghiệm: x = ").append(-this.c / this.b);
        }
    } else {
        float delta = this.b*this.b - 4*this.a*this.c;
        if (delta > 0) {
            float x1 = (float) ((-this.b + Math.sqrt(delta)) / (2*this.a));
            float x2 = (float) ((-this.b - Math.sqrt(delta)) / (2*this.a));
            result.append("Phương trình có 2 nghiệm là: x1 = ").append(x1).append(" và x2 = ").append(x2);
        } else if (delta == 0) {
            float x1 = (-this.b / (2 * this.a));
            result.append("Phương trình có nghiệm kép: x1 = x2 = ").append(x1);
        } else {
            result.append("Phương trình vô nghiệm!");
        }
    }
    return result.toString();
    }
}
