using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i <= 99; i++)
            {
                int a = i / 10;
                int b = i % 10;
                int tich = a * b;
                int tong = a + b;
                if (tich == (2 * tong))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}