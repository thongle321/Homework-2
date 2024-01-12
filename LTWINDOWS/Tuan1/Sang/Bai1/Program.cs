using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chuyen_can, tb_kt, diem_thi;
            Console.Write("Nhap diem chuyen can: ");
            chuyen_can = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem trung binh kiem tra: ");
            tb_kt = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem thi: ");
            diem_thi = double.Parse(Console.ReadLine());
            Console.WriteLine("DIEM MON HOC LAP TRINH WIN");
            Console.WriteLine("Ho ten: Lu Cao Tien \nMSSV: 0306221377\nLop: CD QTM 17B ");
            //Console.WriteLine("Chuyen can: " + chuyen_can + " TBKT: " + tb_kt  + " Diem thi: " + diem_thi);
            Console.WriteLine("Chuyen can: {0} tb_kt: {1} diem_thi: {2}", chuyen_can, tb_kt, diem_thi);
            Console.ReadKey();
        }
    }
}
