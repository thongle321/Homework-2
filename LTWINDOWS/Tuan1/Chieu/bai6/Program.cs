using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tu, mau, tempt, tempm;
            do 
            {
                Console.WriteLine("Nhap mot phan so: ");
                tu = int.Parse(Console.ReadLine());
                mau = int.Parse(Console.ReadLine());
                tempt = Math.Abs(tu);
                tempm = Math.Abs(mau);
                if (tempt != tempm)
                {
                    if(tempt > tempm)
                    {
                        tempt -= tempm;
                    }
                    else
                        tempm -= tempt;
                }
                tu = tu / tempt;
                mau = mau /tempm;
                Console.WriteLine("Phan so rut gon: {0}/{1}",tu,mau);
            } while (tu != -1 && mau != -1);
            Console.ReadKey();
        }
    }
}
