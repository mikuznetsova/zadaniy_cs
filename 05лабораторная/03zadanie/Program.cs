using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String x;
            x = Console.ReadLine();
            double k;
            k = double.Parse(x);
            if(k>0)
            {
                k = Math.Sqrt(k);
            }
                else
            {
                k = k * k;
            }
            Console.WriteLine(k);
        }
    }
}
