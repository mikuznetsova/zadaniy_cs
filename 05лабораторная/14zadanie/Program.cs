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
            String t1, t2, t3;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            t3 = Console.ReadLine();
            double x, y, z;
            x = double.Parse(t1);
            y = double.Parse(t2);
            z = double.Parse(t3);

            if (x < 5 && x > -3)
            {
                Console.Write(x + " ");
            }
            if (y < 5 && y > -3)
            {
                Console.Write(y + " ");
            }
            if (z < 5 && z > -3)
            {
                Console.Write(z + " ");
            }
        }
    }
}
