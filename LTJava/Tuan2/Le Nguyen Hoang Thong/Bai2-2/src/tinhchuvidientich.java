import java.util.Scanner;

public class tinhchuvidientich {
    public static double ChuVi(double radius)
    {
        double chuVi;
        chuVi = 2 * Math.PI * radius;
        return chuVi;
    }
    public static double DienTich(double radius)
    {
        double dienTich;
        dienTich = Math.PI * Math.pow(radius,2);
        return dienTich;
    }
    public static void main(String[] args) {
        double radius, ChuVi, DienTich;
        Scanner input = new Scanner(System.in);
        System.out.print("Nhập bán kính: ");
        radius = input.nextDouble();
        ChuVi = ChuVi(radius);
        DienTich = DienTich(radius);
        System.out.print("Chu vi là: ");
        System.out.println(ChuVi);
        System.out.print("Dien tích là: ");
        System.out.print(DienTich);
    }
}