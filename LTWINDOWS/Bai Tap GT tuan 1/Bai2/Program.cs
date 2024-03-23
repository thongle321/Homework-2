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
            int n, max1 = 0,max2 =0, count = 0;      
            while (count < 10)
            {
                Console.Write("Nhap vao 10 so nguyen: ");
                n = int.Parse(Console.ReadLine());
                if (count == 0)
                {
                    max1 = n;
                }
                else
                {
                    if (n > max1)
                    {
                        max2 = max1;
                        max1 = n;
                    }
                    else if (count == 1  || n > max2)
                    {
                        max2 = n;
                    }
                }
                Console.WriteLine("So lon nhat: " + max1 + " va " + max2);
                count++;
            }
            Console.ReadKey();
        }
    }
}
