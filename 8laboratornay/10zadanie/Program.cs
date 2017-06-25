using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int s =int.Parse( Console.ReadLine());
            string t = Console.ReadLine();
            string[] arr = t.Split(' ');

            int[] num = new int[arr.Length];

            int i = 0;
            if (s < arr.Length)
            {
                while (i < arr.Length)
                {
                    num[i + s] = Convert.ToInt32(arr[i]);

                    Console.Write(num[i + s] + " ");
                    i++;

                    
                }
                i = 1;
                while (i < s)
                {
                    num[s-i] = Convert.ToInt32(arr[i+s]);

                    Console.Write(num[s - i] + " ");
                    i++;
                }
            }
            
        }
    }
}
