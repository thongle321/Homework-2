using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai9
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

                char[] chuoi_a = a.ToString().ToCharArray();
                Array.Reverse(chuoi_a);
                string chuoi_dao_nguoc = new string (chuoi_a);
                int dao_nguoc = int.Parse(chuoi_dao_nguoc);
                if (a == dao_nguoc)
                {
                    Console.Write("{0} la so doi xung!", a);

                }
                else
                {
                    Console.Write("{0} khong la so doi xung!", a);

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}