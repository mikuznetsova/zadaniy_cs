using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int  i =0;
            double r = 0;
            string t = Console.ReadLine();

            string[] arr = t.Split(' ');
            int[] num = new int[arr.Length];

            while (i <arr.Length)
            {
                num[i] = Convert.ToInt32(arr[i]);

                r = r+ num[i];
                i++;
            }
            Console.WriteLine("{0:F1}",r/i);
        }
    }
}
