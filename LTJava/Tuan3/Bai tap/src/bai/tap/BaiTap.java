/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bai.tap;

import java.util.Scanner;

/**
 *
 * @author SV
 */
public class BaiTap {

    /**
     * @param args the command line arguments
     */
    private static int[] mang = new int[6];
    private static int n = 0;
    public static void nhapMang(int[] a)
    {
        Scanner input = new Scanner(System.in);
        System.out.print("Nhap phan tu mang: ");
        n = Integer.parseInt(input.nextLine());
        for (int i = 0; i < n; i++) {
            System.out.print("a[" + i + "]:");
            a[i] = Integer.parseInt(input.nextLine());
        }
    }
    public static void xuatMang(int[] a)
    {
        System.out.print("Danh sach mang la: ");
        for(int item: a)
        {
            System.out.print(item + " ");
        }
    }
    public static int maxMang(int[] a)
    {
        int max = a[0];
        for (int i = 0; i < a.length; i++) {
            if(a[i] > max)
            {
                max = a[i];
            }
        }
        return max;
    }
    public static int demMang(int[] a)
    {
        int dem = 0;
        int max = a[0];
        for (int i = 0; i < a.length; i++) {
            if(a[i] > max)
            {
                max = a[i];
            }
        }
        for (int i = 0; i < a.length; i++) {
            if(a[i] == max)
            {
                dem++;
            }
        }
        return dem;
    }
    public static void main(String[] args) {
        nhapMang(mang);
        xuatMang(mang);
        System.out.println("");
        int timMax = maxMang(mang);
        System.out.print("Max la: " + timMax);
        System.out.println("");
        int demMax = demMang(mang);
        System.out.print("So lan xuat hien la: " + demMax);
        System.err.println("");
    }
    
}
