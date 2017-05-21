using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            t = Console.ReadLine();
            double x;
            x = double.Parse(t);
            if(x<0)
            {
                Console.WriteLine("Значение X должно быть неотрицательным");
                return;
            }
            double Y;
            Y = Math.Sqrt(x);
            Console.WriteLine("{0:F4}",Y);

        }
    }
}
