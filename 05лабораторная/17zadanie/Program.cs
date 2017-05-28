using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
                       
            double m, p, r;
            m = double.Parse(Console.ReadLine());
            p = double.Parse(Console.ReadLine());
            r = m/p;
            if (p == 0)
            {
                Console.Write("Значение P должно быть не равно нулю");
            }
            if (m%p>0)
            {
                Console.Write("M не делится нацело на P");
            }
            else
            {
                Console.Write(r);
            }
            
        }
    }
}
