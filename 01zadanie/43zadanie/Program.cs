using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int current;
            int i = 0;
            int sum = 0;
            do
            {
                current = int.Parse(Console.ReadLine());
                i ++;
                sum += current;
            }
            while (sum<=1000);
            Console.WriteLine(i);

        }
    }
}
