using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String x1, x2, x3, x4;
            x1 = Console.ReadLine();
            x2 = Console.ReadLine();
            x3 = Console.ReadLine();
            x4 = Console.ReadLine();
            double v1,v2, t1,t2;
            v1 = double.Parse(x1);
            t1 = double.Parse(x2);
            v2 = double.Parse(x3);
            t2 = double.Parse(x4);
            if (v1<0)
            {
                Console.WriteLine("Значение v1 должно быть неотрицательным");
                return;
            }
            if (v2 < 0)
            {
                Console.WriteLine("Значение v2 должно быть неотрицательным");
                return;
            }
            double R;
            R =(t1*v1 +t2*v2) /(v1+v2);
            Console.WriteLine("{0:F4}", R);
        }
    }
}
