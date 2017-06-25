using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a = int.Parse(Console.ReadLine());
            string t = Console.ReadLine();
            string[] arr = t.Split(' ');
            
            int[] num = new int[arr.Length];
            int i = 1;
            while (i <= arr.Length)
            {
                num[num.Length-i] = Convert.ToInt32(arr[arr.Length - i]);

                Console.Write(a * num[num.Length - i] + " ");
                i++;
            }
            
        }
    }
}
