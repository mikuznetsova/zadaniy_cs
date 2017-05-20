using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String t,l;
            t = Console.ReadLine();
            l = Console.ReadLine();
            int T, L;
            T = int.Parse(t);
            L = int.Parse(l);
           if (L<=0)
           {
               Console.WriteLine("Значение L должно быть положительным");
               return;
            }
           if (T <=0)
           {
               Console.WriteLine("Значение T должно быть положительным");
               return;
           }
            int R, O;
            R = (T*100) / L;
            O = (T * 100) % L;
            Console.WriteLine("{0} шт. {1} см.", R, O);




        }
    }
}
