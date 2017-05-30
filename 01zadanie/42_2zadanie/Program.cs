using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_2zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int current;
            int sum = 0;
            do
            {
                current = int.Parse(Console.ReadLine());
                sum += current;
            }
            while (current != 0);
            Console.WriteLine(sum);
        }
    }
}
