import java.util.Scanner;

public class Main {
    private static double pound = 0;
    public static double nhapPound()
    {
        Scanner input = new Scanner(System.in);
        System.out.print("Nhập pound: ");
        pound = input.nextDouble();
        return pound;
    }
    public static double chuyenKg(double pound)
    {
        return pound * 0.454;
    }
    public static void inKg(double kg)
    {
        System.out.print("kg là: " + kg);
    }
    public static void main(String[] args) {
        double pound = nhapPound();
        double kg = chuyenKg(pound);
        inKg(kg);
    }
}