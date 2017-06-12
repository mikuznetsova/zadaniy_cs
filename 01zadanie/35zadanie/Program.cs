using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int r;
           
            if (a <=b)
            { r = a % 2;
                if (r > 0)

                {
                    Console.Write(a);
              

                    while (a < b)
                    {    a++;
                        r = a % 2;

                        if (r > 0)

                        {
                            Console.Write(", "+a);
                           
                        }
                    
                    }
                }
                
                else
                {
                    a++;
                    Console.Write(a);
                    a++;
                    while (a <= b)
                    {
                        r = a % 2;

                        if (r > 0)

                        {
                            Console.Write(", ");
                            Console.Write(a);

                        }

                        a++;
                    }
                }
            }
           else
            {
                r = a % 2;
                if (r > 0)

                {
                    
                    Console.Write(a);
                    a--;
                    while (a >= b)
                    {
                        r = a % 2;

                        if (r > 0)

                        {
                            Console.Write(", ");
                            Console.Write(a);
                        }
                        a--;
                    }
                }
                else
                {
                    a--;
                    Console.Write(a);
                    a--;
                    while (a >= b)
                    {
                        r = a % 2;

                        if (r > 0)

                        {
                            Console.Write(", ");
                            Console.Write(a);
                        }
                        a--;

                    }
                }
            }
        }
    }
}
