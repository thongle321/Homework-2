// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a;
            int n;
            do
            {
                Console.Write("Nhap so luong phan tu mang: ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0) break;
            } while (n <= 0); 
            a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Phan thu thu [{0}]: ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Danh sach mang la: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0} ", a[i]);
            }

            int k;
            Console.WriteLine();
            Console.Write("Nhap vi tri can xoa trong mang: ");
            k = int.Parse(Console.ReadLine());
            Array.Resize(ref a, a.Length - 1);
            if (k >= 0 || k <= n)
            {
                for (int i = k; i < a.Length; i++)
                {
                    a[i] = a[i] + 1;
                }
            }
            else
            {
                Console.Write("Nhap sai vi tri");
            }
            Console.Write("Danh sach mang sau khi xoa la: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0} ", a[i]);
            }

            Console.ReadKey();
        }
    }
}
