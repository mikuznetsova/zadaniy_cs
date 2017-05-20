using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10zadani
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            t = Console.ReadLine();
            double a;
            a= double.Parse(t);
           double x;
           x = a * Math.PI / 180;

            double R;
            R = Math.Sin(x);
            Console.WriteLine("{0:F4}",R);
        }
    }
}
