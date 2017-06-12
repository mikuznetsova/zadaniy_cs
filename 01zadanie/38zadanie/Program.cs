using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int i = 1;
            int j = 0;

            if (h < 0)
            {
                Console.WriteLine("Значение H должно быть неотрицательно");
                return;
            }
            if (w < 0)
            {
                Console.WriteLine("Значение W должно быть неотрицательно");
                return;
            }
            while(j<h)
            {
                while (i<=w)
                {
                    if (i%2>0)
                    {
                        Console.Write(s1);
                        i++;
                    }
                    else
                    {
                        Console.Write(s2);
                        i++;
                    }
                }

                i = 1;
                j++;
                Console.WriteLine();
            }

        }
    }
}
