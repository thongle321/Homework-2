using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int so_ngay, bat_dau, ngay = 1;
            Console.WriteLine("\t\tCHUONG TRINH XUAT LEN LICH MOT THANG");
            Console.Write("Nhap so ngay cua mot thang: ");
            so_ngay = int.Parse(Console.ReadLine());
            Console.Write("Nhap ngay bat dau cua mot thang: ");
            bat_dau = int.Parse(Console.ReadLine());
            Console.WriteLine("CN\tT2\tT3\tT4\tT5\tT6\tT7");
            for (int i = 1; i < so_ngay + bat_dau; i++)
            {
                if (i < bat_dau)
                {
                    Console.Write(" \t");
                }
                else
                {
                    if (i % 7 == 0)
                    {
                        Console.WriteLine(ngay);
                    }
                    else
                    {
                        Console.Write("{0}\t", ngay);
                    }

                    ngay++;
                }
            }
            Console.ReadKey();
        }
    }
}