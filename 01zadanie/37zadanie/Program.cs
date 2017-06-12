using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int i = 0;
            int j = 1;
            
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
            while (j<=h)
            {
             int r = j % 2;
                if (r > 0)
                {
                    while (i < w)
                    {
                        Console.Write(s1);
                        i++;
                    }
                }
                else
                {
                    while (i < w)
                    {
                        Console.Write(s2);
                        i++;
                    }
                }
             j++;
             i = 0;
             Console.WriteLine();
                
            }
            


        }
    }
}
