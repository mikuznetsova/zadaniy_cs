using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = 10;//размер массива
             
            int[] arr = new int[n];

            int i = 0;
            int r = 0;
            while (i < n )
            {
                int t = rnd.Next(0, 30);
                int j = 0;
                r = 0;
                while (i>j)
                {
                   if (t== arr[j])
                    {
                        r++;
                        
                    }                    
                    
                    j++;
                }
                if(r==0)
                {
                    arr[i] = t;
                   Console.Write(arr[i] + " ");
                    i++;
                }
            }
        }
    }
}
