using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _222zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            t = Console.ReadLine();
            int y, i;
            y = int.Parse(t);
            if (y < 0 || y > 15)
            {
                Console.WriteLine("Значение Y должно быть в интервале [0, 15]");
                return;
            }
            i = 1;
            while (i <= 15)
            {
                 if (i <= y)
                {
                    Console.Write("#");
                    i++;
                }
                 else
                {
                    Console.Write(".");
                    i++;
                }

            }

        }
    }
}
