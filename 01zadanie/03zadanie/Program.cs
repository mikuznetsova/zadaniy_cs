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
            String t1, t2;
            int a,b;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            a = int.Parse(t1);
            b = int.Parse(t2);
            while (b>=a)
            {
                Console.WriteLine(a);
                a++;
            }
        }
    }
}
