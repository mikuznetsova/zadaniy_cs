using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            double xp1, yp1, xt, yt, xp2, yp2;
            xt = double.Parse(Console.ReadLine());
            yt = double.Parse(Console.ReadLine());
            xp1 = double.Parse(Console.ReadLine());
            yp1 = double.Parse(Console.ReadLine());
            xp2 = double.Parse(Console.ReadLine());
            yp2 = double.Parse(Console.ReadLine());
            if (yp1 < 0 || yt < 0 || yp2 < 0)
            {
                Console.Write("Координата Y должна быть неотрицательной");
                return;
            }
            if (xp1 < 0 || xt < 0 || xp2 < 0)
            {
                Console.Write("Координата X должна быть неотрицательной");
                return;
            }
            if (xt>=xp1&&xt<=xp2&&yt>=yp1&&yt<=yp2)
            {
                Console.Write("Точка принадлежит прямой");
            }
            else
            {
                Console.Write("Точка не принадлежит прямой");
            }
        } }
}


