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
            double khoi_luong;
            Console.WriteLine("Nhap khoi luong: ");
            khoi_luong = double.Parse(Console.ReadLine());
            if (khoi_luong <= 0)
            {
                Console.WriteLine("Khoi luong phai lon hon 0");
            }
            else if (khoi_luong > 0 && khoi_luong < 10)
            {
                Console.WriteLine("Phi van chuyen: 5000 dong");
            }
            else if (khoi_luong >= 10 && khoi_luong < 20)
            {
                Console.WriteLine("Phi van chuyen: 9000 dong");
            }
            else if (khoi_luong >= 20 && khoi_luong < 50)
            {
                Console.WriteLine("Phi van chuyen: 15000 dong");
            }
            else { Console.WriteLine("Phi van chuyen: 20000 dong"); }
            Console.ReadKey();
        }
    }
}
