using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            t = Console.ReadLine();
            double R;
            R = double.Parse(t);
            if (R <= 0)
            {
                Console.WriteLine("Значение R должно быть положительным");
                return;
            }
            double C;
            C =2*Math.PI*R;
            Console.WriteLine("{0:F4}",C);
        }
    }
}
