using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23zadanie
{
    class Program
    {
        static void Main(string[] args)
        {

            int k = int.Parse(Console.ReadLine());
            
            int j = 0;
            int r = 0;
            string x = Console.ReadLine();
            string[] arr = x.Split(' ');

            int[] num = new int[arr.Length];
           

           
                while (j < arr.Length)
                {
                    num[j] = Convert.ToInt32(arr[j]);
                    if (k == num[j])
                    {
                        r++;
                        
                    }

                    j++;
                }
                
               
            
                Console.WriteLine(r);

            
        }
    }
}
