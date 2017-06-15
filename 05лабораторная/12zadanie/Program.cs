using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String X;
            X = Console.ReadLine();
            string[] arr = "a b c d e f g h".sprlit (' ');
            int i = 0;
            while (i<8)
           {   
                if (X == arr[i] )
            {
                Console.WriteLine(arr[i]+"+");
            }
            else
            {
                Console.WriteLine(arr[i]);
               
            }
           i++;
           }
            
        }
    }
}
