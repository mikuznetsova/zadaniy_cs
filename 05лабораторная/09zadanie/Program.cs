using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String x, y;
            x = Console.ReadLine();
            y = Console.ReadLine();
            double c,s, r;
            c = double.Parse(x);
            s = double.Parse(y);
            if (s < 0)
            {
                Console.WriteLine("Площадь квадрата должна быть положительной");
                return;
            }
            if (c < 0)
            {
                Console.WriteLine("Площадь круга должна быть положительной");
                return;
            }
            r = s * Math.Sqrt(2)/ 2;
            if (c <= r)
            {
                Console.WriteLine("Круг уместится в квадрате");
            }
            else
            {
                Console.WriteLine("Круг не поместится в квадрате");
            }
      
        }
    }
}
