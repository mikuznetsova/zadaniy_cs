using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33zadanie
{
    class Program
    {
        static void Main(string[] args)
        {


            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int r, i,j;
           j = 0;
            i = 1;

            if (a > b)
            {

                while (b <= a)
                {

                    r = b % 2;
                    if (r > 0)
                    {
                        j++;
                        while (i < j)
                        {
                            Console.Write(".");
                            i++;
                        }
                        Console.Write(b);
                    }
                    Console.WriteLine();
                    b++;
                    i = 1;

                }
            }
            else
            {

                while (a <= b)
                {

                    r = a % 2;
                    if (r > 0)
                    {
                         j++;
                        while (i <j)
                        {
                            Console.Write(".");
                            i++;
                        }
                        Console.Write(a);
                      
                    }
                    Console.WriteLine();
                    a++;
                    
                    i = 1;

                }
            }







        }
    }
}

