using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            string t1 = Console.ReadLine();
            string t2 = Console.ReadLine();

            string[] arr1 = t1.Split(' ');
            string[] arr2 = t2.Split(' ');
            int[] num1 = new int[arr1.Length];
            int[] num2 = new int[arr2.Length];
             int i = 0;
            
            if (arr1.Length > arr2.Length|| arr1.Length < arr2.Length)
            {
                Console.WriteLine("	Размеры массивов должны быть одинаковы");
            }

            while (i < arr1.Length)
            {
                num1[i] = Convert.ToInt32(arr1[i]);
                num2[i] = Convert.ToInt32(arr2[i]);
              
                Console.Write(num1[i] * num2[i] + " ");
                i++;

            }
           
            
        }
    }
}
