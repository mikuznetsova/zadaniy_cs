using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b, c;
            a = Console.ReadLine();
            b = Console.ReadLine();
            c = Console.ReadLine();
            double x, y, z;
            x= double.Parse(a);
            y= double.Parse(b);
            z = double.Parse(c);
            if (x == y || y == z || x == z)
            {
                Console.WriteLine("Среди чисел есть равные");
            }
            else
            {
                Console.WriteLine("Числа не равны друг другу.");
            }
        }
    }
}
