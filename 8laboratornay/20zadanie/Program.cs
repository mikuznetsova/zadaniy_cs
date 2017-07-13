using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
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

                j++;
            }
            if (num[0]>q||num[num.Length-1]<q)
            {
                Console.WriteLine("ошибкa");
            }
            int R = 0;
            j = 0;
            while (j <=q&&j>=p)
            {



                R = num[j] - r;
                Console.Write(R + " ");
                j++;
            }
        }
    }
}
