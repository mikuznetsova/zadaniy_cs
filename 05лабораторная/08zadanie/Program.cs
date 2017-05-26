using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String x, y,z;
            x = Console.ReadLine();
            y = Console.ReadLine();
            z = Console.ReadLine();
            double a,b,c,r;
            a= double.Parse(x);
            b= double.Parse(y);
            c = double.Parse(z);
            if (a== 0)
            {
                Console.WriteLine("Данное уравнение не является квадратным");
                return;
            }
            r= b * b - 4 * a * c;
            if (r==0)
            {
                Console.WriteLine("Уравнение 3x^2 + 6x + 3 = 0 имеет один корень");
                            }
            if (r <0)
            {
                Console.WriteLine("Вещественных корней уравнения 1x^2 + 2x + 3 = 0 нет");
            }
            else
            {
                Console.WriteLine("У уравнения 3x^2 + 17x + 5 = 0 два вещественных корня");
            }
        }
    }
}
