using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, y, i;
            a = 100;
            b = 1000;
            i = 0;
            y = 0;
            
                while ((a + i) <= b)

                {
                    if ((a + i) % 13 == 0)
                    {
                        y = y + 1;
                    }
                    i++;
                }
            
            Console.WriteLine(y);
        }
    }
}
