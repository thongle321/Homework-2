using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static double TocDo(double Km, int Hours,out double KmPerHour)
        {
            KmPerHour = Km / Hours;
            return KmPerHour;
        }
        static void Main(string[] args)
        {
            int Hours; 
            double Km, KmPerHour, kq;
            Console.Write("Hay nhap so km da di du lich: ");
            Km = double.Parse(Console.ReadLine());
            Console.Write("Hay nhap so gio da di du lich: ");
            Hours = int.Parse(Console.ReadLine());
            kq = TocDo(Km, Hours, out KmPerHour);
            Console.Write("Toc do cua ban la {0:#.00} km tren gio", kq);
            Console.ReadKey();  
        }
    }
}
