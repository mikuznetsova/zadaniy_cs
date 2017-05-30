using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            string t1,t2,r, s = "abcdefwxyz";
            t1 = Console.ReadLine();
            t2= Console.ReadLine();

            int ca, cb;
            ca = int.Parse(t1);
            cb = int.Parse(t2);
            if (ca<0||ca>=s.Length)
            {
                Console.WriteLine("Значение A должно быть в интервале [0,длина строки)");

                return;

            }
            if (cb < 0||cb >= s.Length)
            {
                Console.WriteLine("Значение B должно быть в интервале [0,длина строки)");

                return;

            }
            
            r = s.Substring(ca, cb-ca+1);
            Console.WriteLine(r);
        }
    }
}
