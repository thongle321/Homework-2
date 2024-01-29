import java.util.Scanner;

public class Main {
    private static double feet = 0;
    public static double nhapFeet()
    {
        Scanner input = new Scanner(System.in);
        System.out.print("Nhập feet: ");
        double feet = input.nextDouble();
        return feet;
    }

    public static double chuyenDoi(double feet)
    {
        return feet * 0.305;
    }
    public static void inMet(double met)
    {
        System.out.print("Mét là: " + met);
    }
    public static void main(String[] args) {
        feet = nhapFeet();
        double m = chuyenDoi(feet);
        inMet(m);
    }
}