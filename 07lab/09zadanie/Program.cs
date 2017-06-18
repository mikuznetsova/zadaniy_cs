using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            string  ss, r;
            ss = Console.ReadLine();

            if (ss.StartsWith("s"))
            {
                r = ss.ToLower();
            }
            else
            {
                if (ss.StartsWith("U"))
                {
                    r = ss.ToUpper();
                }
                else
                {
                    r = ss;
                }
            }
            
            Console.WriteLine(r); 
        }
    }
}
