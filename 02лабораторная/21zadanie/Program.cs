using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1, t2;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();

            double r1, r2;
            r1 = double.Parse(t1);
            r2 = double.Parse(t2);

            if (r1 == 0)
            {

                Console.WriteLine("Значение r1 должно быть не равно нулю");
                return;
            }
            if (r2 == 0)
            {
                Console.WriteLine("Значение r2 должно быть не равно нулю");
                return;
            }

            double R;
            R = 1 / r1 + 1 / r2;
            Console.WriteLine("{0:F4}", R);
        }
    }
}
