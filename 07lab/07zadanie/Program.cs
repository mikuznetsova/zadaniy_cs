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
            {if (i > 0)
                {
                    r1 = s.Remove(i);
                    
                }
            else
                {
                    r1 =" ";
                }
                r2 = s.Substring(i, (j-i));
                r3 = s.Substring(j);
            }
            else
            {
                if (j > 0)
                {
                    r1 = s.Remove(j);

                }
                else
                {
                    r1 = " ";
                }
                r2 = s.Substring(j, (i-j));
                r3 = s.Substring(i);
            }
            Console.WriteLine("Часть 1: " + r1);
            Console.WriteLine("Часть 2: " + r2);
            Console.WriteLine("Часть 3: " + r3);
        }
    }
}
 