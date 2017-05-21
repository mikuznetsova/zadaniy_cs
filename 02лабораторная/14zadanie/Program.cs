using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1, t2;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            double a,b;
            a = double.Parse(t1);
            b = double.Parse(t2);
            if (b>0)
            {
                Console.WriteLine("Значение B должно быть не положительным");
                return;
            }
            double R;
            R = a* Math.Sqrt(-7*b);
              Console.WriteLine("{0:F4}", R);
        }
    }
}
