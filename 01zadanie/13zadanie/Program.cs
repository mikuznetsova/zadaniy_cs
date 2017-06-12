using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int a= int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int s = 0;
            if (b > a)
            {
                while (a <= b)
                {
                    s = s + a;

                    a++;
                }
            }
            else
            {
                while (b <= a)
                {
                    s = s + b;

                    b++;
                }
            }
                Console.WriteLine(s);
        }
    }
}
