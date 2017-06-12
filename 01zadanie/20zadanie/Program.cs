using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= n)
            {
                Console.Write("#");
                 i++;
                if (i % 21 == 0)
                {
                    Console.Write("\n");
                }
              
            }
        }
    }
}
