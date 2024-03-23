using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double so_lit, km, km_lit, tb = 0, count = 0;
            do
            {
                Console.Write("Hay nhap vao so lit xang da dung (-1 de ket thuc): ");
                so_lit = double.Parse(Console.ReadLine());
                Console.Write("Hay nhap vao so km da chay: ");
                km = double.Parse(Console.ReadLine());
                km_lit = km / so_lit;
                Console.WriteLine("So km/lit cho binh xang nay la: " + km_lit);
                count++;
            } while (so_lit != -1);
            tb += km_lit / count;
            Console.WriteLine("Trung binh la: " + tb);
            Console.ReadKey();
        }
    }
}
