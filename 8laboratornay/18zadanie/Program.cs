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
            int i = 0;
            int j = 0;
            int r = 0;
            int R = 0;
            string x = Console.ReadLine();

            string[] arr = x.Split(' ');
            int[] num = new int[arr.Length];
            while (i < arr.Length)
            {
                num[i] = Convert.ToInt32(arr[i]);

                while (j < arr.Length)
                {
                    num[j] = Convert.ToInt32(arr[j]);

                    r = Math.Min(num[i], num[j]);
                    if (r < R)
                    {
                        R = r;
                    }

                    j++;
                }
                i++;
                j = 0;
            }
            Console.WriteLine(R);
        }
    }
}
