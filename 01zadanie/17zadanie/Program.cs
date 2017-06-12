using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double r = 0;
            double s = 0;
            if (b >= a)
            {
                while (a <b)
                {
                    r =a * a;
                    s = s + r;
                  a++;
                }
            }
            else
            {
                while (b < a)
                {
                    r = Math.Pow(a,2);
                    s = s + r;
                    a--;
                }
            }
            Console.WriteLine(s+b*b);

        }
    }
}
