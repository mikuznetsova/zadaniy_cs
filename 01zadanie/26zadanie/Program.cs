using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = int.Parse(Console.ReadLine());
            int r, i = 2;
            r = 0;
            
            if (y <= 0)
            {
                Console.Write("Значение y должно быть положительным");
            }
            while (i < y)

            {
                if (y % i == 0)
                {
                    r = r + 1;
                    
                                       
                }
                    i++;                         
            }
            if (r>1)
            {
                Console.Write("число не простое");
            }
           
            else
            {
                Console.Write("число простое");
            }
                    
        }
    }
}
