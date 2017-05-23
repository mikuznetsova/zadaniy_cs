using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1, t2, t3;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            t3 = Console.ReadLine();
            double v, t, a;
            v = double.Parse(t1);
            t = double.Parse(t2);
            a = double.Parse(t3);
            double r;
            r = v*t+a*Math.Pow(t,2)/2;
            Console.WriteLine("{0:F1}", r);
        }
    }
}
