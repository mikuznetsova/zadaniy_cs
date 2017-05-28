using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b,c,d;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());
            if (a < 0 )
            {
                Console.Write("Значение A должно быть неотрицательным");
                return;
            }
            if ( b < 0 )
            {
                Console.Write("Значение B должно быть неотрицательным");
                return;
            }
            if (c < 0 )
            {
                Console.Write("Значение C должно быть неотрицательным");
                return;
            }
            if ( d < 0)
            {
                Console.Write("Значение D должно быть неотрицательным");
                return;
            }

            if ((a<=c&&b<=d)|| (b <= c && a <= d))
            {
                Console.Write("Размещение возможно");
            }
            else
            {
                Console.Write("Размещение невозможно");
            }
        }
    }
}
