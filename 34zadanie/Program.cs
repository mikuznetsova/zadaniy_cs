using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1, t2;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            double a, b;
            a = double.Parse(t1);
            b = double.Parse(t2);
            double r;
            r = 3*Math.Sin(2*(a * Math.PI / 180)) * Math.Cos(3*(b * Math.PI / 180));
            Console.WriteLine("{0:F4}", r);
        }
    }
}
