using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            string s= Console.ReadLine();
            int i, j;
            int h = int.Parse(Console.ReadLine());
            i = 0;
            j = 0;
            if (h < 0)
            {
                Console.WriteLine("Значение H должно быть неотрицательно");
                return;
            }
            if (h == 0)
            {
                Console.WriteLine("");
                return;
            }
            while (j <= h)
            {
                while (i <= j)
                {
                    Console.Write(s);
                    i++;
                }
                Console.WriteLine(  );
                j++;
                i = 1;
            }
        }
    }
}
