/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package demoptb2;

/**
 *
 * @author SV
 */
public class PTB2 {
    protected int a,b,c;

    public PTB2() {
        this.a = 0;
        this.b = 0;
        this.c = 0;
    }

    public PTB2(int a, int b, int c) {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public int getA() {
        return a;
    }

    public void setA(int a) {
        this.a = a;
    }

    public int getB() {
        return b;
    }

    public void setB(int b) {
        this.b = b;
    }

    public int getC() {
        return c;
    }

    public void setC(int c) {
        this.c = c;
    }
    public String nghiem() {
        if (a == 0) {
            if (b == 0) {
                return "Phương trình vô nghiệm";
            }
            else {
                float kq = -this.c / this.b;
                return "Phương trình có một nghiệm: x = " + kq;
            }
        }
        float delta = this.b*this.b - 4*this.a*this.c;
        float x1, x2;
        if (delta > 0) {
            x1 = (float) ((-b + Math.sqrt(delta)) / (2*a));
            x2 = (float) ((-b - Math.sqrt(delta)) / (2*a));
            return "Phương trình có 2 nghiệm là: x1 = " + x1 + "và x2 = " + x2;
        }
        else if (delta == 0) {
            x1 = (-b / (2*a));
            return "Phương trình có nghiệm kép: x1 = x2 = " + x1; 
        }
        else {
            return "Phương trình vô nghiệm";
        }
    }
}
