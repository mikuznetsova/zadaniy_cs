using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05лабораторная
{
    class Program
    {
        static void Main(string[] args)
        {
            String x, y;
            x = Console.ReadLine();
            y = Console.ReadLine();
            double a, b;
            a = double.Parse(x);
            b = double.Parse(y);
            if (a > b)
            {
                Console.WriteLine("Первое");
            }
            else
            {
                Console.WriteLine("Второе");
            }
        }
}
}
