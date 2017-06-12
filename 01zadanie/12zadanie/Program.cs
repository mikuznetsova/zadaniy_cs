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
            int f = -10;
            int b= int.Parse(Console.ReadLine());
            int s = 0;
            if (b > 10000||b<-10)
            {
                Console.Write("Значение b должно быть в интервале [-10,10000]");
            }

            while (f <= b)
            {
                s = s+f;
                
                f++;
            }
            Console.WriteLine(s);
        }
    }
}
