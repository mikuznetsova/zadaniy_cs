using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1, t2;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            int a, b;
            a = int.Parse(t1);
            b = int.Parse(t2);
            int n, i;
            if (a <= b)
            {
                i = a;
                n = b;
                while (i <= n)
                {
                    Console.Write(i + " ");
                    i++;
                }
            }

            else
            {
                i = a;
                n = b;
                while (i >= n)
                {
                    Console.Write(i + " ");
                    i--;
                }
            }
        }
    }
}

