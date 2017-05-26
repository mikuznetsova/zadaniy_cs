using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            t = Console.ReadLine();
            double a;
            a = double.Parse(t);
            
            double b ;
           b= 12*a*a+7*a-16;
            Console.WriteLine("{0:F4}", b);
        }
    }
}
