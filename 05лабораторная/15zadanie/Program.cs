using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1, t2, t3;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            t3 = Console.ReadLine();
            double x, y, z;
            x = double.Parse(t1);
            y = double.Parse(t2);
            z = double.Parse(t3);
            if (x < 0)
            {
                Console.Write("Значение X должно быть неотрицательным");
            }
            if (z<0)
            {
                Console.Write("Значение C должно быть неотрицательным");
            }
            if (y < 0)
            {
                Console.Write("Значение B должно быть неотрицательным");
            }
            if (x == y|| y==z||x==z)
            {
                Console.Write("Треугольник является равнобедренным.");
            }
            else
            {
                Console.Write("Треугольник не является равнобедренным.");
            }
        }
    }
}
