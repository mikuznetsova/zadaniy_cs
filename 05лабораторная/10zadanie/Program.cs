using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1, t2, t3;
           t1= Console.ReadLine();
            t2= Console.ReadLine();
           t3 = Console.ReadLine();
            double x,y,z,a,b,c;
            x = double.Parse(t1);
            y = double.Parse(t2);
            z = double.Parse(t3);
            a = x * x;
            b = y * y;
            c = z * z;
            if (x<0)
            {
                Console.Write(x+";");
            }
            if (x>= 0)
            {
                Console.Write(a + ";");
            }
            if (y < 0)
            {
                Console.Write(y + ";");
            }
            if (y>= 0)
            {
                Console.Write( b + ";");
            }
            if (z < 0)
            {
                Console.Write(z + ";");
            }
            else
            {
                Console.Write(c + ";");
            }
        }
    }
}
