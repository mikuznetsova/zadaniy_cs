using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String x, y;
            x = Console.ReadLine();
            y = Console.ReadLine();
            double p, q;
            p = double.Parse(x);
            q = double.Parse(y);
            if(p>q)
            { Console.WriteLine ("Максимальное "+p+ ", минимальное "+q);
            }
            else {
                Console.WriteLine("Максимальное " + q + ", минимальное " + p);
            }
        }
    }
}
