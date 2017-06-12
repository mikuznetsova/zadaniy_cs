using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
           
            int  n, k,j,i;
            n = 0;
            k = 0;
            i = 0;
            j = 0;
            if (w < 0)
            {
                Console.WriteLine("Значение W должно быть неотрицательно");
                return;
            }
            if (h < 0)
            {
                Console.WriteLine("Значение H должно быть неотрицательно");
                return;
            }
            Console.Write(" ");
            if (n <= w)
            {
                while (n < w)
                {
                    Console.Write(n);
                    n++;
                  
                } 
                
                
            }
            Console.WriteLine();
            while (k <= h )
            {
               Console.WriteLine(k);
               k++;
            }
            Console.Write(" ");

            
        }
    }
}
