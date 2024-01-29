using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, ket_qua = 0;
            do
            {
                Console.WriteLine("Nhap so nguyen: ");
                a = int.Parse(Console.ReadLine());
                if (a < 0 && a % 2 == 0 && (ket_qua == 0 || a > ket_qua))
                {
                    ket_qua = a;
                }
            }while (a != 0);

            if (ket_qua == 0)
            {
                Console.WriteLine("Khong co so am chan lon nhat");
            }
            else
            {
                Console.WriteLine("So am chan la: " + ket_qua);
            }
            Console.ReadKey();
        }
    }
}
