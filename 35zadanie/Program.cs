﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1, t2;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            double x1, x2;
            x1 = double.Parse(t1);
            x2 = double.Parse(t2);
            
            double r;
            r =  Math.Sqrt(x2*x2+x1*x1);
            Console.WriteLine("{0:F4}", r);
        }
    }
}
