using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            t = Console.ReadLine();
            double x;
            x = double.Parse(t);
            double r;
            r = 7*x*x-3*x+6;
            Console.WriteLine("{0:F0}", r);

        }
    }
}
