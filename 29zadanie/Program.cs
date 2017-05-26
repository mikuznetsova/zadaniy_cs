using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            t = Console.ReadLine();
            double x;
            x = double.Parse(t);
            if (x < 1)
            {
                Console.WriteLine("Значение X должно быть не меньше 1");
                return;
            }
            double R;
            R = (Math.Sqrt(x+1)+ Math.Sqrt(x - 1))/(2* Math.Sqrt(x));
            Console.WriteLine("{0:F4}", R);
        }
    }
}
