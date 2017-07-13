using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            string[] arr = x.Split(' ');

            int[] num = new int[arr.Length];

            num[0] = Convert.ToInt32(arr[0]);
            int r = num[0];

            int j = 1;



            while (j < arr.Length)
            {
                num[j] = Convert.ToInt32(arr[j]);


                r = Math.Min(r, num[j]);
                Console.Write(r + " ");

                j++;
            }
            int R = 0;
            j = 0;
            while (j < arr.Length)
            {



                R = num[j] - r;
                Console.Write(R + " ");
                j++;
            }
        }
    }
}
