using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1, t2, t3, t4;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            t3 = Console.ReadLine();
            t4 = Console.ReadLine();
            double a, b, c, x;
            a = double.Parse(t1);
            b = double.Parse(t2);
            c = double.Parse(t3);
            x = double.Parse(t4);
            if (a< 0)
            {

                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return;
            }
            if (a == 0&&b==0&&c==0&&x==0)
            {
                Console.WriteLine("Знаменатель не может быть равен нулю");
                return;
            }
            double r;
            r = 1 / (Math.Sqrt(a * x * x + b * x + c));
            Console.WriteLine("{0:F4}", r);
        }
    }
}
