using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String chuoi;
            Console.Write("Nhap chuoi: ");
            chuoi = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < chuoi.Length; i++)
            {
                if (!char.IsWhiteSpace(chuoi[i]))
                {
                    count++;
                }
            }
            Console.Write("So ky tu: {0}", count);
            Console.WriteLine();
            String hoten, ho;
            String[] hovaten;
            Console.Write("Nhap ho va ten: ");
            hoten = Console.ReadLine();
            hovaten = hoten.Split(' ');
            ho = hovaten[0];
            Console.Write("Ho cua ban la: {0}", ho);
        }
    }
}