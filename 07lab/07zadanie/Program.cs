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
            string ca, cb, r1,r2,r3, s = "abcdefwxyz";
            ca = Console.ReadLine();
            cb = Console.ReadLine();

            if (!s.Contains(ca))
            {
                Console.WriteLine("Значение ca отсутствует в строке");
                return;

            }
            if (!s.Contains(cb))
            {
                Console.WriteLine("Значение cb отсутствует в строке");
                return;

            }
            int i, j;
            i = s.IndexOf(ca);
            j = s.IndexOf(cb);
            if (j > i)
            {
                r1 = s.Substring(0, i - 1);
                r2 = s.Substring(i , j - i - 1);
                r3 = s.Substring(j-i,9);
            }
            else
            {
                r1 = s.Substring(0, j - 1);
                r2 = s.Substring(j, i - j - 1);
                r3 = s.Substring(i - j, 9);
            }
            Console.WriteLine("Часть 1: "+r1);
            Console.WriteLine("Часть 2: "+r2);
            Console.WriteLine("Часть 3: "+r3);
        }
    }
}
