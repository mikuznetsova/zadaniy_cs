using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int current = int.Parse(Console.ReadLine());
            int sum = current;
            while(current !=0)
            {
                current = int.Parse(Console.ReadLine());
                sum += current;

            }
            Console.WriteLine(sum);
        }
    }
}
