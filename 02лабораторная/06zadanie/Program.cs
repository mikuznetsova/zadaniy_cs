using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1,t2;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            double a,h;
            a = double.Parse(t1);
            h = double.Parse(t2);
            if (a <= 0)
            {
                Console.WriteLine("Значение A должно быть положительным");
                return;
            }
            if (h <= 0)
            {
                Console.WriteLine("Значение H должно быть положительным");
                return;
            }
            double S;
            S= (a*h)/2;
            Console.WriteLine("{0:F2}", S);
        }
    }
}
