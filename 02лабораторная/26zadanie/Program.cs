﻿using System;
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
            String t1, t2, t3, t4;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            t3 = Console.ReadLine();
            t4 = Console.ReadLine();
            double a, b, c, d;
            a = double.Parse(t1);
            b = double.Parse(t2);
            c = double.Parse(t3);
           d= double.Parse(t4);
            if (a == 0)
            {
                Console.WriteLine("Значение a должно быть не равно нулю");
                return;
            }
            if (d == 0)
            {
                Console.WriteLine("Значение d должно быть не равно нулю");
                return;
            }
            double R;
            R = ((a*b+b*c) / (a*d));
            Console.WriteLine("{0:F4}", R);
        }
    }
}
