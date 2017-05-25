using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n= 100;
            int i= 500;
            while (n <= i)
            {
                sum = sum + n;
                n++;
            }
            Console.WriteLine(sum);
        
        }
    }
}
