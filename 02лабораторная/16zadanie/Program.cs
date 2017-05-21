using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1, t2;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            double x, y;
            x = double.Parse(t1);
            y = double.Parse(t2);
                        if (y< 0)
            {
                
                    Console.WriteLine("Значение y должно быть неотрицательным");
                    return;
            }
            if ( 0>x+Math.Sqrt(y))
            {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return;
            }
            double R;
            R = -5 * Math.Sqrt(x+Math.Sqrt(y));
            Console.WriteLine("{0:F4}", R);
        }
    }
    
}
