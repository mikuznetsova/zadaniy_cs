using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            string t1, t2;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            int a, b, y, i, z;
            a = int.Parse(t1);
            b = int.Parse(t2);
            i = 0;
            y = 0;
            if (a <= b)
            {
                while ((a+i)<=b)

                {
                    if ((a + i) % 7 == 0)
                    {
                        y = y + (a + i);  
                    }
                    i++;
                }
            }
            else
            {
                while ((b + i)<= a)
                {
                    if ((b + i) % 7 == 0)
                    {
                        y = y + (b + i);
                    }
                    i++;
                }
                
            }
            Console.WriteLine(y);
        }
    }
}

