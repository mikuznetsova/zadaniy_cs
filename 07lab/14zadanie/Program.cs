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
            string s;
            s = Console.ReadLine();
            int i = 1;
            int j = 1;

            
            s = s.Replace("[" , " \\ \");


            Console.WriteLine(s.Substring(i, (s.Length - 2)));
        }
    }
}
