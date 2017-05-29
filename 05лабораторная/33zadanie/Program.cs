using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int t;
            t = int.Parse(Console.ReadLine());

            if (t<0||t>60)
            {
                Console.Write("Значение T должно быть в интервале [0, 59]");
                return;
            }
            if (t%4==0||t%5==0||t%9==0||t%10==0)
            {
                Console.Write("Красный");
            }
            else
            {
                Console.Write("Зеленый");
            }
        }
    }
}
