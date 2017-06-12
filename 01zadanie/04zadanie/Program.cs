using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            if (a>n)
            {
                Console.Write("Значение A должно быть не больше значения B");
            }
            while (a <= n)
            {
                Console.Write(n + " ");
                n--;
            }
        }
    }
}
