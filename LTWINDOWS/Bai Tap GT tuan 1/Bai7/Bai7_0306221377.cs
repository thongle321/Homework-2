using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            while (true)
            {
                Console.Write("Hay nhap so nguyen duong (-1 de ket thuc): ");
                a = int.Parse(Console.ReadLine());
                if (a == -1)
                {
                    break;
                }

                String chuoia = a.ToString();
                int sokytu = chuoia.Length;
                Console.Write("So {0} co {1} ky so!", a, sokytu);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}