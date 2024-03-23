using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static int TB(ref int tong, ref int n)
        {
            int tbcong = tong / n;
            return tbcong;
        }
        static void Main(string[] args)
        {
            int n, tong = 0, tbcong; 
            int[] diem;
            Console.Write("Nhap so luong diem so: ");
            n = int.Parse(Console.ReadLine());
            diem = new int[n];
            for (int i = 0; i < diem.Length; i++)
            {
                Console.Write("Diem thu {0}: ", i + 1);
                diem[i] = int.Parse(Console.ReadLine());
                tong += diem[i];
            }
            Console.WriteLine();
            tbcong = TB(ref tong,ref n);
            if(tbcong >= 90 && tbcong <= 100)
            {
                Console.WriteLine("Diem tuong ung la A");
            }
            else if (tbcong >= 80 && tbcong <= 89)
            {
                Console.WriteLine("Diem tuong ung la B");
            }
            else if (tbcong >= 70 && tbcong <= 79)
            {
                Console.WriteLine("Diem tuong ung la C");
            }
            else if (tbcong >= 60 && tbcong <= 69)
            {
                Console.WriteLine("Diem tuong ung la D");
            }
            else if (tbcong >= 0 && tbcong <= 59)
            {
                Console.WriteLine("Diem tuong ung la F");
            }
            Console.ReadKey();
        }
    }
}
