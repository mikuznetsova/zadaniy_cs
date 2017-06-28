using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int x = int.Parse(Console.ReadLine());
            string s = " 11, 13, 17, 19, 10, 12, 14, 15, 16, 18, 20";
            string[] arr = s.Split(',');
            int[] num = new int[arr.Length];
            while (i < num.Length)
            {
                num[i] = Convert.ToInt32(arr[i]);

                if (num[i] == x)
                {
                    Console.WriteLine(num[i] + "+ ");
                }
                else
                {
                    Console.WriteLine(num[i]);
                }
                i++;
            }
        }
    }
}
