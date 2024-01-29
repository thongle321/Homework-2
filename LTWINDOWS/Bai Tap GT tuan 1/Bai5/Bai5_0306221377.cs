using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, temp;

            while (true)
            {
                Console.Write("Hay nhap hai so nguyen (nhap -1 de ket thuc): ");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());

                if (a == -1 || b == -1)
                {
                    break;
                }

                while (b != 0)
                {
                    temp = b;
                    b = b % a;
                    a = temp;
                }

                Console.WriteLine("Uoc chung lon nhat: " + a);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}