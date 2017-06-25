using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            string t = Console.ReadLine();

            string[] arr = t.Split(' ');
            while (i <= arr.Length)
            {
                Console.Write(arr[arr.Length-i] + " " );
                i++;
            }
        }
    }
}
