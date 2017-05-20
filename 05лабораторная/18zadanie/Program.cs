using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String X;
            X = Console.ReadLine();
            int a;
            a = int.Parse(X);
            int E, C;
            E = a % 10;
            C = (a / 100) % 10;
            if(E<1000 || E>9999)
            {
                Console.WriteLine("Значение должно быть в интервале [1000, 9999]");
                return;
            }

            if (E == C)
            {
                Console.WriteLine("равно");
            }
            else
            {
                Console.WriteLine("не равно");
            }
            
        }
    }
}
