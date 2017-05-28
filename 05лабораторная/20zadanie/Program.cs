using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, r;
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

            if (y >= -2&&y<=1.5)
            {
                Console.Write("точка принадлежит множеству");
            }
            else
            {
                Console.Write("точка не принадлежит множеству");
            }
        }
    }
}
