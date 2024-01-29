using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static char ToLowerCase(char kytu)
        {
            return char.ToLower(kytu);
        }
        static void SolvePTB1(double a, double b)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phuong trinh co vo so nghiem");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            }
            else
            {
                Console.WriteLine("Phuong trinh co nghiem la {0}", (-b/a));
            }

        }
        static void SolvePTB2(double a, double b, double c)
        {
            if(a == 0)
            {
                SolvePTB1(b,c);
            }
            else
            {
                double delta = (b * b) - (4 * a * c);
                if(delta < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
                else if(delta == 0)
                {
                    Console.WriteLine("Phuong trinh co nghiem kep x1 = x2= {0}", -b/(2*a));
                }
                else
                {
                    Console.WriteLine("Phuong trinh co nghiem x1 = {0}", (-b + Math.Sqrt(delta)) / 2 * a);
                    Console.WriteLine("Phuong trinh co nghiem x2 = {0}", (-b - Math.Sqrt(delta)) / 2 * a);
                }
            }
        }
        static void HoanVi(ref double a, ref double b)
        {
            double temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int chon;
            do
            {
                Console.WriteLine("\t\tMenu");
                Console.WriteLine("1. Chuyen ky tu hoa sang thuong");
                Console.WriteLine("2. Giai phuong trinh bac nhat");
                Console.WriteLine("3. Giai phuong trinh bac hai");
                Console.WriteLine("4. Tra ve gia tri nho nhat cua 4 so nguyen");
                Console.WriteLine("5. Hoan vi hai so nguyen");
                Console.WriteLine("6. Kiem tra chuoi doi xung");
                Console.Write("Nhap lua chon: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        {
                            char kytu;
                            Console.Write("Nhap mot ky tu hoa: ");
                            kytu = char.Parse(Console.ReadLine());
                            Console.Write("Ky tu thuong la: " + ToLowerCase(kytu));
                        }
                        break;
                    case 2:
                        {
                            double a, b;
                            Console.Write("Nhap a: ");
                            a = double.Parse(Console.ReadLine());
                            Console.Write("Nhap b: ");
                            b = double.Parse(Console.ReadLine());
                            Console.Write("Phuong trinh bac nhat: {0}x + {1} = 0", a, b);
                            Console.WriteLine();
                            SolvePTB1(a, b);
                        }
                        break;
                    case 3:
                        {
                            double a, b, c;
                            Console.Write("Nhap a: ");
                            a = double.Parse(Console.ReadLine());
                            Console.Write("Nhap b: ");
                            b = double.Parse(Console.ReadLine());
                            Console.Write("Nhap c: ");
                            c = double.Parse(Console.ReadLine());
                            Console.Write("Phuong trinh bac hai: {0}x^2 + {1}x + {2} = 0", a, b, c);
                            Console.WriteLine();
                            SolvePTB2(a, b, c);
                        }
                        break;

                    case 4:
                        {

                        }
                        break;
                    case 5:
                        {
                            double a, b;
                            Console.Write("Nhap so thu nhat: ");
                            a = double.Parse(Console.ReadLine());
                            Console.Write("Nhap so thu hai: ");
                            b = double.Parse(Console.ReadLine());
                            HoanVi(ref a,ref b);
                            Console.Write("Sau khi hoan vi so thu nhat la {0} va so thu hai la {1}", a, b);
                        }
                        break;
                    default:
                        Console.WriteLine("Khong co lua chon");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Nhan enter de tiep tuc hoac nhan esc de thoat");
            } while (Console.ReadKey().KeyChar != 27);
        }
    }
}
