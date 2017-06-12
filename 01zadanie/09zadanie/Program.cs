using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = 1;
            

            while (f <= 9)
            {
                int k = f*7;
                Console.WriteLine(f + " x 7 = "+ k);
                f++;
            }
        }
    }
}
