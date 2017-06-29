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
           
            int j = 1;
           
      
            string x = Console.ReadLine();

            string[] arr = x.Split(' ');
            int[] num = new int[arr.Length];
            num[0] = Convert.ToInt32(arr[0]);
            int r = num[0];
            while (j < arr.Length)
                {
                    num[j] = Convert.ToInt32(arr[j]);

                    r = Math.Min(r, num[j]);
                    j++;
                }
                
            Console.WriteLine(r);
        }
    }
}
