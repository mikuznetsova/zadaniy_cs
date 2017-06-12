using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int w = int.Parse(Console.ReadLine());
            int i, j;
           
            i = 0;
            j = 0;
            if (w < 0)
            {
                Console.WriteLine("Значение W должно быть неотрицательно");
                return;
            }
            if (w == 1)
            {
                Console.WriteLine("+");
                Console.WriteLine("|");
                Console.WriteLine("+");
                return;
            }
            if (w == 2)
            {
                Console.WriteLine("++");
                Console.WriteLine("||");
                Console.WriteLine("++");
                return;
            }
            if (j == 0)
            { Console.Write("+");
                while (i < (w - 2))
                {
                    Console.Write("-");
                    i++;
                }
              Console.Write("+");
                j++;
                i = 0;
                Console.WriteLine();
            }
            
            if(j == 1)
            {
                Console.Write("|");
                while (i < (w - 2))
                {
                    Console.Write(".");
                    i++;
                    
                }
                Console.Write("|");
                j++;
                i = 0;
                Console.WriteLine();
            }
            if ( j == 2)
            {
                Console.Write("+");
                while (i < (w - 2))
                {
                    Console.Write("-");
                    i++;
                }
                Console.Write("+");
                j++;
                i = 0;
                Console.WriteLine();
            }
           
        }
    }
}
