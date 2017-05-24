using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String a, b;
            b = Console.ReadLine();
            a = Console.ReadLine();
            int A;
            int i = 0;
            A = int.Parse(a);
            Console.Write("\"");
            while (i<A)
            {
                Console.Write(b);
                i++;
            }
            Console.Write("\"");
        }
    }
}
