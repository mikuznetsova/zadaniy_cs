using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string t = Console.ReadLine();
            
            string[] arr = t.Split(' ');
             Array.Reverse(arr);

            foreach (string i in arr)
            {
                Console.Write(i);
            }

            
            
        }

        
    }
}
