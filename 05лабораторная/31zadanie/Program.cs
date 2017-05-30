using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1, b1, a2, b2;
            a1 = double.Parse(Console.ReadLine());
            b1= double.Parse(Console.ReadLine());
            a2 = double.Parse(Console.ReadLine());
            b2 = double.Parse(Console.ReadLine());
            bool intersectX = false;
            if (a1>b1||a2>b2)
            {
                Console.Write("Значение A должно быть меньше значения B");
                return;
            }
            if (a1 <= a2)
            {
                if (a2 <= b1 && b2 > b1)
                {
                    Console.Write("пересекаются (" + a2 + ";" + b1 + ")");
                    intersectX = true;
                }
                if (a2 <= b1 && b2 <= b1)
                {
                    Console.Write("пересекаются (" + a2 + ";" + b2 + ")");
                    intersectX = true;
                }
            }
            else
            {
                if (a1 <= b2 && b2 <= b1)
                {
                    Console.Write("пересекаются (" + a1 + ";" + b2 + ")");
                }
                else
                {
                    Console.Write("не пересекаются");
                }
            }
        }
    }
}
        
    

