using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 1;
            int r = 0;
            string x = Console.ReadLine();
            string[] arr = x.Split(' ');

            int[] num = new int[arr.Length];
            int[] num2 = new int[arr.Length];

            while (i < arr.Length)
            {
                num[i] = Convert.ToInt32(arr[i]);
                while (j < arr.Length)
                {
                    num2[j] = Convert.ToInt32(arr[j]);
                    if (num[i] > num2[j]|| num[i] < num2[j])
                    {
                        r++;
                        
                    }

                    int R = 0;
                    if (r>0)
                    {
                        R++;
                    }
                    j++;
                }
                
                i++;
                j = i + 1;
            }
           
                Console.WriteLine(R);

            
        }
    }
}
