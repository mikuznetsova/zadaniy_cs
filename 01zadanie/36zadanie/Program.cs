using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int r = (q + p) / 2;
            if (p<q)
            {
                Console.Write(p + "<");
                p++;
                while(p<r)
                {
                    Console.Write(p+"<");
                    p++;
                }
                while (p >= r&&p<=q)
                {
                    Console.Write(p + ">");
                    p++;
                }
                
            }
            else
            {
                Console.Write(q+"<");
                q++;
                while (q < r)
                {
                    Console.Write(q + "<");
                   q++;
                }
                while (q >=r && q<=p)
                {
                    Console.Write(q + ">");
                    q++;
                }
              
            }
            Console.Write(Math.Max(p,q));
        }
        
    }
}
