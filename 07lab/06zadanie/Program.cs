using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            string ca, cb, r, s = "abcdefwxyz";
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
                r = s.Substring(i + 1, j - i-1);
            }
            else
            {
                r = s.Substring(j+1, i - j - 1);
            }
            Console.WriteLine(r);
           
        }
    }
}
