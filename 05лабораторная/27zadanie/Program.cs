using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = int.Parse(Console.ReadLine());
            if (a <-10||a>100)
            {
                Console.Write("Значение A должно быть в интервале[-10, 100]");
                return;

            }
            if (a==3||a==23|| a == 33 || a == 43|| a == 53 || a==63|| a==73|| a== 83|| a==93)
            {
                Console.Write(a+"'ий");
            }
            if (a== 2||(a>5 &&a<9) ||a==22|| (a > 25 && a < 29) || a == 32 || (a > 35 && a < 39) || a==40
                ||a == 42 || (a > 45 && a < 49) || a == 52 || (a > 55 && a < 59) ||
                a == 62 || (a >65 && a <69) || a == 72 || (a > 75 && a < 79) || a == 82 || (a > 85 && a < 89) 
                || a == 92 || (a > 95 && a < 99))
                {
                Console.Write(a + "'ой");
            }
            else
            {
                Console.Write(a+"'ый");
            }
        }
    }
}
