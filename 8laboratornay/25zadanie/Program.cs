using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            int i = 0;
            int r = 0;

            string x = Console.ReadLine();
            string[] arr = x.Split(' ');

            int[] num = new int[arr.Length];
          
            while (j < arr.Length)
            {
                num[j] = Convert.ToInt32(arr[j]);
                while (i < arr.Length)
                {

                    num[i] = Convert.ToInt32(arr[i]);
                    if (num[j] == num[i])
                    {
                        r++;
                        if (r==1)
                        {
                            Console.Write(num[j]);
                            
                        }
                        else
                        {
                            num[i] = num[i + 1];
                            
                        }
                       i++;

                    }
                    

                }
                
                 j++;
                    i = 0;
                    r = 0;  
                    


            }
        }
    }
}
