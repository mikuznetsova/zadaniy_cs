using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = 20;
            int b = 40;
            int r = 0;
            
            while (f <= b)
            {
                r = r+(f*f*f);

                f++;
            }
            Console.WriteLine(r);
        }
    }
}
