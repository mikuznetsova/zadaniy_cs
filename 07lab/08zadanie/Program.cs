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
            string t1, t2, r, s = "abcdefwxyz";
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();

            int ca, cb;
            ca = int.Parse(t1);
            cb = int.Parse(t2);
            if (ca >= s.Length)
            {
                Console.WriteLine("Значение CA должно быть в интервале [0,длина строки)");
                return;
            }
            if ( cb >= s.Length)
            {
                Console.WriteLine("Значение CB должно быть в интервале [0,длина строки)");
                return;
            }
            if (ca < 0)
            {
                Console.WriteLine("Значение CA должно быть неотрицательно");
                return;
            }
            if (cb < 0 )
            {
                Console.WriteLine("Значение CB должно быть неотрицательно");
                return;
            }
            if ((cb+ca)>s.Length)
            {
                Console.WriteLine("Сумма значений CA и CB должна быть меньше длины строки");
                return;
            }
            r=s.Remove(ca, cb);
            Console.WriteLine(r);
        }
    }
}
