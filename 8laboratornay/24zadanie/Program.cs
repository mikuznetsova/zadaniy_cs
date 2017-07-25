using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24zadanie
{
    class Program
    {
        static void Main(string[] args)
        {

            int j = 0;
            int i = 0;
            int r= 0;
            
            string x = Console.ReadLine();
            string[] arr = x.Split(' ');

            int[] num = new int[arr.Length];
               
             while (j < arr.Length)
             {num[j] = Convert.ToInt32(arr[j]);
                while (i < arr.Length)
                {
                    
                    num[i] = Convert.ToInt32(arr[i]);
                    if (num[j] == num[i])
                    {
                        r++;

                    }
                    i++;
                    
                }
                Console.Write(r + " ");
                j++;
                i = 0;
                r = 0;

            }
                

        }
    }
}
