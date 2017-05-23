using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1, t2;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            double m, a;
            m= double.Parse(t1);
            a = double.Parse(t2);
            double R;
            R = m * 9.8067 * Math.Cos(a*Math.PI/180);
            Console.WriteLine("{0:F4}", R);
        }
    }
}
