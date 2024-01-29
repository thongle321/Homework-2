using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double doanh_thu, luong;
            while (true)
            {
                Console.Write("Nhap doanh thu cua nhan vien (-1 de ket thuc): ");
                doanh_thu = float.Parse(Console.ReadLine());
                if (doanh_thu == -1)
                {
                    break;
                }

                luong = doanh_thu * 0.09 + 200;
                Console.WriteLine("Luong cua nhan vien la: ${0:#.00}", luong);
            }

            Console.ReadKey();
        }
    }
}