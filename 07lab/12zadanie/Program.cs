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
            string  s,t ;
            s = Console.ReadLine();
            t = ",";
             int i =0 ;
            int j = 1;
            while ((i = s.IndexOf(t, i)) != -1)
            {
                j++;              
                i += t.Length;
            }
            Console.WriteLine(j);
        }
    }
}
