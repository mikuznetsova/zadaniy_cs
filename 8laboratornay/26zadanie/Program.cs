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
            int a = 1;
            int r = 0;
            int R = 0;
            string x = Console.ReadLine();
            string[] arr = x.Split(' ');

            int[] num = new int[arr.Length];
        

            while (a<10)
            {
                

                while (i < arr.Length)
                {
                   num[i] = Convert.ToInt32(arr[i]);
                    
                    if (num[i] == a)
                    {
                        r++;
                        
                    }

                     i++;                   
                   
                }
                if (r>0)
                    {
                        R++;
                   
                    }
                   
                a++;
                i = 0;
                r = 0;
                
            }
           
             Console.WriteLine(R);   

            
        }
    }
}
