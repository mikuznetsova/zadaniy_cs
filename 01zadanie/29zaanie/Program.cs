using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29zaanie
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            s = Console.ReadLine();
            int  i, j;
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            i = 0;
            j = 0;
            if (w < 0 )
            {
                Console.WriteLine("Значение W должно быть неотрицательно");
                return;
            }
            if (h< 0)
            {
                Console.WriteLine("Значение H должно быть неотрицательно");
                return;
            }
            while (j < h)
            {
                while (i < w)

                {
                    Console.Write(s);
                    i++;

                }
                Console.WriteLine();
                i = 0;
                j++;
            }
        }
    }
}
