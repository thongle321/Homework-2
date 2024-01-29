using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            while (true)
            {
                Console.Write("Hay nhap hai so nguyen (nhap -1 de ket thuc): ");
                a = int.Parse(Console.ReadLine());

                if (a == -1)
                {
                    break;
                }
                int min = a, max = 0;
                char[] chuoi_chu_so = a.ToString().ToCharArray();
                foreach (char chu_so in chuoi_chu_so)
                {
                    int chu_so_hien_tai = int.Parse(chu_so.ToString());
                    max = Math.Max(max, chu_so_hien_tai);
                    min = Math.Min(min, chu_so_hien_tai);
                }
                Console.Write("Ky so lon nhat: " + max);
                Console.WriteLine();
                Console.Write("Ky so nho nhat: " + min);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}