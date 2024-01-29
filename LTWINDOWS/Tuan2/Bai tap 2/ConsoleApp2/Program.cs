using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hoten;
            string[] arr;
            Console.Write("Nhap ho ten: ");
            hoten = Console.ReadLine();
            //int vt = hoten.Trim().IndexOf(" ");
            //Console.Write("Ho la: " + hoten.Trim().Substring(0,vt));
            arr = hoten.Trim().Split(' ');
            Console.Write("Ho la: " + arr[0]);
            Console.WriteLine();
            Console.Write("Ten la: " + arr[arr.Length - 1]);
            Console.ReadKey();
        }
    }
}
