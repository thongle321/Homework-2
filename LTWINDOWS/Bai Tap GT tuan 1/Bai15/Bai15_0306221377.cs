using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            
            double tong1 = 0;
            for (int i = 1; i <= n; i++)
            {
                tong1 += i;
            }
            double S1 = tong1 / n;
            Console.WriteLine("S1 = " + S1);

            double tong2 = 0;
            for (int i = 1; i <= n; i++)
            {
                tong2 += Math.Pow(i, 2);
            }
            double S2 = Math.Sqrt(tong2);
            Console.WriteLine("S2 = " + S2);

            double tong3 = 0;
            for (int i = 1; i <= n; i++)
            {
                tong3 += Math.Pow(3, i);
            }
            double S3 = Math.Sqrt(tong3);
            Console.WriteLine("S3 = " + S3);
            
            double S4 = 1;
            for (int i = 1; i <= n; i++)
            {
                S4 = 1 / (2 + S4);
            }
            Console.WriteLine("S4 = " + S4);
            Console.ReadKey();
        }
    }
}