using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            t = Console.ReadLine();
            double h;
            h = double.Parse(t);
            if (h < 0)
            {
                Console.WriteLine("Высота над уровнем Земли должна быть неотрицательна");
                return;
            }
            double R, r = 6350;
            R = Math.Sqrt(h * (2 * r + h));
            Console.WriteLine("{0:F4}", R);
        }
    }
}
