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

            string t = Console.ReadLine();
            string[] arr = t.Split(' ');

            int[] num = new int[arr.Length];
            int i = 1;
            while (i < arr.Length)
            {
                num[i - 1] = Convert.ToInt32(arr[i]);

                Console.Write(num[i - 1] + " ");
                i++;
            }
            Console.Write(arr[0]);
        }
    }
}
