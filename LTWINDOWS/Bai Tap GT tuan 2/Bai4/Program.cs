using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Program
    {
        static void Seconds(int gio, int phut, int giay, out int tonggiay)
        {
            tonggiay = gio * 3600 + phut * 60 + giay;
        }
        static void Main(string[] args)
        {
            int h1, m1, s1, h2, m2, s2;
            int t1, t2;
            do
            {
                Console.Write("Nhap gio thu nhat: ");
                h1 = int.Parse(Console.ReadLine());
            } while (h1 < 0 || h1 > 23);
            do
            {
                Console.Write("Nhap phut thu nhat: ");
                m1 = int.Parse(Console.ReadLine());
            } while (m1 < 0 || m1 > 59);
            do
            {
                Console.Write("Nhap giay thu nhat: ");
                s1 = int.Parse(Console.ReadLine());
            } while (s1 < 0 || s1 > 59);
            Seconds(h1, m1, s1, out t1);
            do
            {
                Console.Write("Nhap gio thu hai: ");
                h2 = int.Parse(Console.ReadLine());
            } while (h2 < 0 || h2 > 23);
            do
            {
                Console.Write("Nhap phut thu hai: ");
                m2 = int.Parse(Console.ReadLine());
            } while (m2 < 0 || m2 > 59);
            do
            {
                Console.Write("Nhap giay thu hai: ");
                s2 = int.Parse(Console.ReadLine());
            } while (s2 < 0 || s2 > 59);
            Seconds(h2, m2, s2, out t2);
            Console.Write("Khoang cach giua hai gio: " + Math.Abs(t2 - t1));
            Console.ReadKey();
        }
    }
}
