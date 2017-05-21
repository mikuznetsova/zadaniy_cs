using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            t = Console.ReadLine();
            double a;
            a = double.Parse(t);
            if (a <= 0)
            {
                Console.WriteLine("Значение A должно быть положительным");
                return;
            }
            double V;
            V= Math.Pow (a, 3);
            Console.WriteLine(V);
        }
    }
}
