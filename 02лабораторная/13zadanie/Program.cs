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
            String t;
            t = Console.ReadLine();
            double x;
           x = double.Parse(t);
            if (x>61)
            {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return;
            }
            double R;
            R = 3 * Math.Sqrt(61-x);
            if (R == 0 || R == 3)
            {
                Console.WriteLine(R);
            }
            else
            {
                Console.WriteLine("{0:F4}", R);
            }
        }
    }
}
