using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1,y1, x2, y2, khoang_cach;
            Console.WriteLine("Nhap diem toa do thu nhat: ");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem toa do thu hai: ");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            khoang_cach = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow(y2-y1,2));
            Console.WriteLine("Khoang cach giua 2 diem: " + khoang_cach);
            Console.ReadKey();
        }
    }
}
