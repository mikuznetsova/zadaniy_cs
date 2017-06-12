using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int i, j;
            j = 0;
            i = 1;
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
            while (j < h)
            {
                while (i <= w)
                {
                    if (i<=(w-j))
                    { Console.Write("+"); }
                    else
                    { Console.Write("#"); }
                    i++;
                }
                i = 1;
                Console.WriteLine();
                j++;
            }
        }
    }
}
