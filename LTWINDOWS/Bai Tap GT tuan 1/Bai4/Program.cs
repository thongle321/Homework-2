using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double doanh_thu, luong;
            Console.Write("Nhap doanh thu cua nhan vien (-1 de ket thuc): ");
            doanh_thu = float.Parse(Console.ReadLine());
            while (doanh_thu != 1) 
            {
                luong = doanh_thu * 0.09 + 200;
                Console.WriteLine("Luong cua nhan vien la: " + luong);
                break;
            }
        }
    }
}
