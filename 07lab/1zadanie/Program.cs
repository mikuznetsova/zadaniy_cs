using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            string t,s = "abcdefwxyz";
            t = Console.ReadLine();
            bool tf;
            tf=s.Contains(t);
            if (tf)
            {
                Console.WriteLine("Содержится");
            }
            else
            {
                Console.WriteLine("Не содержится");
            }

        }
    }
}
