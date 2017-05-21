using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            t = Console.ReadLine();
            double y;
            y = double.Parse(t);
            double R;
            R =5* Math.Cos(y*Math.PI/180);
            Console.WriteLine("{0:F4}", R);
        }
    }
}
