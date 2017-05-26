using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String x, y;
            x = Console.ReadLine();
            y = Console.ReadLine();
            double R, A,r,a;
            R = double.Parse(x);
            A = double.Parse(y);
            if (R < 0)
            {
                Console.WriteLine("Значение R должно быть неотрицательным");
                return;
            }
            if (A < 0)
            {
                Console.WriteLine("Значение A должно быть неотрицательным");
                return;
            }
            r = R * R * Math.PI;
            a = A * A;
            if ( r<a)
            {
                Console.WriteLine("Площадь квадрата больше площади круга");
            }
            else
            {
                Console.WriteLine("Площадь круга больше площади квадрата");
            }
        }
    }
}
