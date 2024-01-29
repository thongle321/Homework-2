using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int demkytu(String chuoi, out int kytu)
        {
            int count = 0;
            for (int i = 0; i < chuoi.Length; i++)
            {
                if (!char.IsWhiteSpace(chuoi[i]))
                {
                    count++;
                }
            }
            kytu = count;
            return kytu;
        }
        static void Main(string[] args)
        {
            String chuoi;
            int sokytu, kq;
            Console.Write("Nhap vao mot chuoi:");
            chuoi = Console.ReadLine();
            //int count = 0;
            //for (int i = 0; i < chuoi.Length; i++)
            //{
            //    if (!char.IsWhiteSpace(chuoi[i]))
            //    {
            //        count++;
            //    }
            //}
            sokytu = demkytu(chuoi, out kq);
            Console.Write("So ky tu la {0}", kq);
            Console.ReadKey();
        }
    }
}
