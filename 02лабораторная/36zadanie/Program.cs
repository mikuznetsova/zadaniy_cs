using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1, t2, t3, t4;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            t3 = Console.ReadLine();
            t4 = Console.ReadLine();
            double x1, x2, y1, y2;
            x1 = double.Parse(t1);
            y1 = double.Parse(t2);
            x2 = double.Parse(t3);
            y2 = double.Parse(t4);
            double R;
            R = Math.Sqrt((x2-x1)* (x2 - x1) + (y2 - y1)* (y2 - y1));
            Console.WriteLine("{0:F4}", R);
        }
    }
}
