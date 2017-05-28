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
            double x, y, r;
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

            if ((y >= 0.5&&y<=1.5 &&x<2)||x >=2 )
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
