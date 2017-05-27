using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            string t1;
            t1 = Console.ReadLine();
            int w, i, j;
            w = int.Parse(t1);

            i = 0;
            j = 0;
            if (w < 0 || w > 20)
            {
                Console.WriteLine("Значение W должно быть в интервале [0, 20]");
                return;
            }
            while (j <= 9)
            {
                while (i < w)

                {
                    Console.Write(j);
                    i++;

                }
                Console.WriteLine();
                i = 0;
                j++;
            }
        }          
    }
}
