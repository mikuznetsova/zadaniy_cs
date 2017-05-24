using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            t= Console.ReadLine();
            int n;
            n = int.Parse(t);

            int sum = 0;
            int i = 500;
            if(n < -100 || n>500)
            {
                Console.WriteLine("Значение A должно быть в интервале [-100, 500]");
                return;
            }
            while (n <= i)
            {
                sum = sum + n;
                n++;
            }
            Console.WriteLine(sum);

        }
    }
}
