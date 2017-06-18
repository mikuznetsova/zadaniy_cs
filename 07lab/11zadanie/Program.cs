using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            string  s ;
            s = Console.ReadLine();
             int i = 1;
            int j = 1;

            if (!s.StartsWith("\"") ||!s.EndsWith("\""))
            {
                Console.WriteLine("Строка должна начинаться и заканчиваться кавычкой");
                return;

            }

            s = s.Replace(" ", "");

            Console.WriteLine(s.Substring(i,(s.Length-2)));
        }
    }
}
