import java.util.Scanner;

public class doinhietdo {
    private static int doC = 0;
    public static int nhapdoC()
    {
        Scanner input = new Scanner(System.in);
        System.out.print("Nhập độ C: ");
        doC = Integer.parseInt(input.nextLine());
        return doC;
    }
    public static int doiNhietDo(int doC)
    {
        return (9 / 5) * doC + 32;
    }
    public static void inDoF(int doF)
    {
        System.out.print("Độ F là: " + doF);
    }
    public static void main(String[] args) {
        int doC = nhapdoC();
        int doF = doiNhietDo(doC);
        inDoF(doF);
    }
}