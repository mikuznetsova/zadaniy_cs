using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1, t2, t3;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            t3 = Console.ReadLine();
            double v1, v2, s;
            v1 = double.Parse(t1);
            v2 = double.Parse(t2);
            s = double.Parse(t3);
            if (v1 < 0)
            {

                Console.WriteLine("Значение v1 должно быть неотрицательным");
                return;
            }
            if (v2 < 0)
            {
                Console.WriteLine("Значение v2 должно быть неотрицательным");
                return;
            }
            double t;
            t = s / (v1 + v2);
            Console.WriteLine("{0:F4}", t);
        }
    }
}
