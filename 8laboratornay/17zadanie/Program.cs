using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j =1;
            int r = 0;
            string x = Console.ReadLine();
            string[] arr = x.Split(' ');
            string[] arr2 = x.Split(' ');
            int[] num = new int[arr.Length];
            int[] num2 = new int[arr2.Length];

            while (i < arr.Length )
            {
                num[i] = Convert.ToInt32(arr[i]);
                while (j < arr2.Length )
                {
                    num2[j] = Convert.ToInt32(arr2[j]);
                    if (num[i] == num2[j])
                    {
                        r++;

                    }

                    j++;

                    
                }
                i++;
                    j = i+1;
            }
            if (r > 1)
            {
                Console.WriteLine("Повторения есть");

            }
            else
            {

                Console.WriteLine("Повторений нет");
            }
        }
    }
}
