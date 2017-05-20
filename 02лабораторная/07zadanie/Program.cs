using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            t = Console.ReadLine();
            double A;
            A = double.Parse(t);
            double B;
            B = A * Math.PI / 180;
            Console.WriteLine("{0:F4}",B);
        }
    }
}
