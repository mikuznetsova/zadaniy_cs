using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02лабораторная
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            t = Console.ReadLine();
            double x;
            x = double.Parse(t);
            double y;
            y = x + 7;
            Console.WriteLine("{0:F4}",y);
        }
    }
}
