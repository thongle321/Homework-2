import java.util.Scanner;

public class Main {
    private static long phut = 0;
    public static long nhapPhut()
    {
        Scanner input = new Scanner(System.in);
        System.out.print("Nhập phút: ");
        phut = input.nextLong();
        return phut;
    }
    /*
    public static long chuyendoiNgay(long phut)
    {
        long ngay = (int)phut / 60;
        return ngay;

    }
    public static long chuyendoiNam(long phut)
    {
        long nam = (int)phut / 525600;
        return nam;
    }
    public static void In(long nam, long ngaymoi)
    {
        System.out.println("Năm là: " + nam + " Ngày là: " + ngaymoi);
    }
     */
    public static void xuLy(long phut)
    {
        int h = (int)phut / 60;
        int ngay = h / 24;
        int nam = ngay / 365;
        int ngaymoi = ngay - (nam * 365);
        System.out.print("Nam là: " + nam + "Ngày là: " + ngaymoi);

    }
    public static void main(String[] args) {
        phut = nhapPhut();
        xuLy(phut);
    }
}