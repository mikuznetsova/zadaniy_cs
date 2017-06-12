using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            t = Console.ReadLine();
            int x, i;
            x = int.Parse(t);
            i = 30;

            while (i <= 40)
            {
                if (x == i)
                {
                    Console.WriteLine(i + "+");
                    i++;
                }
                else
                {
                    Console.WriteLine(i+"-");
                    i++;
                }

            }
        }
    }
}
