using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            string t, s = "abcdefwxyz";
            t = Console.ReadLine();
            if (!s.Contains(t))
            {
                Console.WriteLine("Значение отсутствует в строке");
                return;

            }
            int i, r;
            i = s.IndexOf(t);
            
            r = s.Length - i-1;
            Console.WriteLine(r);

        }
    }
}
