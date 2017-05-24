using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19zadanie
{
    class Program
    {
        static void Main(string[] args)

        {
            string t;
            t = Console.ReadLine();
            int n,i;
            n = int.Parse(t);
            if(n<0)
            {
                Console.WriteLine("Значение N должно быть неотрицательным");
                return;
            }
            i = 1;
            while (i<=n)
            {
                Console.Write("!");
                if (i%5==0)
                {
                    Console.Write(" ");
                }
                i++;
            }
        }
    }
}
