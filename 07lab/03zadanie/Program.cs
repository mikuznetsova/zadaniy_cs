using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            string ca, cb, s = "abcdefwxyz";
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
            int i,j, r;
            i = s.IndexOf(ca);
            j = s.IndexOf(cb);
            if (j > i)
            {
                r = j - i - 1;
            }
            else                
            {
                r = i - j - 1;
            }
            Console.WriteLine(r);

        }
    }
}
