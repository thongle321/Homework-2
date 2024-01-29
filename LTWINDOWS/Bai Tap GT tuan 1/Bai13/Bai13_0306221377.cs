using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = int.Parse(Console.ReadLine());
            int bcnn = (a > b) ? a : b;
            while (true)
            {
                if (bcnn % a == 0 && bcnn % b == 0)
                {
                    Console.WriteLine("Boi chung nho nhat là: " + bcnn);
                    break;
                }

                bcnn++;
            }
            Console.ReadKey();
        }
    }
}