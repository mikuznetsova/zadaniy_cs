using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int r = 1;
            int i = 0;
            if (b > a)
            {
                while (a < b)
                {
                    r = r * (a+i);

                    i++;
                }
            }
          else
            {
                while (b < a)
                {
                    r = r* (b+i);
                    i++;
                }
            }
            Console.WriteLine(r);
            
        }
    }
}
