using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02задание
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            t = Console.ReadLine();
            double a;
            a= double.Parse(t);
            if (a <= 0) 
            {
                Console.WriteLine("Значение A должно быть положительным");
                return;
            }
            double S;
            S = 6 * Math.Pow(a,2);
            Console.WriteLine(S);
        }
    }
}
