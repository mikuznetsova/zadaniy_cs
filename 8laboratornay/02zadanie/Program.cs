using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            string t = Console.ReadLine();

            string[] arr = t.Split(' ');          
            while (i<arr.Length)
            {
                Console.WriteLine(arr[i] + " " + i);
                i++;
            }
           

           
        }
    }
}
