﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1, t2, t3;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            t3 = Console.ReadLine();
            double a, b, c;
            a = double.Parse(t1);
            b = double.Parse(t2);
            c = double.Parse(t3);
            double r;
            r=Math.Sqrt(a*a+b*b-2*a*b*Math.Cos(c*Math.PI/180));
            Console.WriteLine("{0:F4}", r);
        }
    }
}
