using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan2
{
    internal class Program
    {
        static void HoanVi(ref int n1,ref int n2)
        {
            int temp;
            temp = n1;
            n1 = n2;
            n2 = temp;
        }
        static void Main(string[] args)
        {
            int n1, n2;
            Console.Write("Hay nhap so thu nhat, sau do enter: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Hay nhap so thu hai, sau do enter: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("Ban nhap cac so la {0} va {1}", n1, n2);
            HoanVi(ref n1, ref n2);
            Console.WriteLine();
            Console.Write("Sau khi hoan vi, so thu nhat co gia tri {0}", n1);
            Console.WriteLine();
            Console.Write("So thu hai co gia tri la {0}", n2);
            Console.ReadKey();
            
        }
    }
}
