using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            double w,h,c,d, r,r1;
            w = double.Parse(Console.ReadLine());
           h = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());
            
            if (w<=0)
            {
                Console.Write("Значение W должно быть положительным");
                return;
            }
            if (h <= 0)
            {
                Console.Write("Значение H должно быть положительным");
                return;
            }
            if (c <= 0)
            {
                Console.Write("Значение C должно быть положительным");
                return;
            }
            if (h <= 0)
            {
                Console.Write("Значение D должно быть положительным");
                return;
            }
            r =(h/c)*(w/d);
            r1=r-r%((h / c) * (w / d));
            if (w / c >= h / c)
            {
                Console.Write(r + "при C вдоль W");
                
            }
            else 
             {
                Console.Write(r + "при C вдоль H");
            }
        }
    }
}

