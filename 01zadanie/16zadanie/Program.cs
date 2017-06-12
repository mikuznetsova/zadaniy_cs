using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double n = double.Parse(Console.ReadLine());
            double r = 0;
            double i = 1;
            if (n<=0)
            {
                Console.Write("Значение n должно быть положительным");
            }
            while (i <= n)
            {
                r = r+1/i;
                i++;
            }
            Console.WriteLine(r);
        }
    }
}
