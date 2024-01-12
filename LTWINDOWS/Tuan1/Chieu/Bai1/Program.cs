using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, max = 0, count = 0;
            Console.Write("Nhap vao 10 so nguyen: ");
            n = int.Parse(Console.ReadLine());
            while (count < 10)
            {
                Console.Write("Nhap vao 10 so nguyen: ");
                n = int.Parse(Console.ReadLine());
                if (n > max)
                {
                    max = n;
                }
                count++;
            }
            Console.WriteLine("So lon nhat: " + max);
            Console.ReadKey();
        }
    }
}
