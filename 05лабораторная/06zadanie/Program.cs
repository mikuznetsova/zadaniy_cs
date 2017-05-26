using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String x, y;
            x = Console.ReadLine();
            y = Console.ReadLine();
            double V1, V2;
            V1 = double.Parse(x);
            V2 = double.Parse(y);
            if (V1 < 0)
            {
                Console.WriteLine("Значение V1 должно быть неотрицательным");
                return;
            }
            if (V2 < 0)
            {
                Console.WriteLine("Значение V2 должно быть неотрицательным");
                return;
            }
            
            if (V1>(V2 * 3.6))
            {
                Console.WriteLine("V2 (м/с) меньше V1(км/ч)");
            }
            else
            {
                Console.WriteLine("V1 (км/ч) меньше V2 (м/с)");
            }
        }
    }
}

