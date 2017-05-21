using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String x;
            x = Console.ReadLine();
            double c;
            c = double.Parse(x);
            if (c<-299)
            {
                Console.WriteLine("Значение T должно быть выше абсолютного нуля");
                return;
            }
            double f;
            f = c*1.8+32;
            Console.WriteLine("{0:F4}", f);
            
        }
    }
}
