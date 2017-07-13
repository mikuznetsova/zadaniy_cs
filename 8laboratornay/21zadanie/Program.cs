using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            string s = Console.ReadLine();
            string[] arr =s.Split(' ');

            int[] num = new int[arr.Length];
            
            

            int j = 0;



            while (j < arr.Length)
            {
                num[j] = Convert.ToInt32(arr[j]);

                if (x == num[j])
                {
                    num[j] = y;
                    
                }
                Console.Write(num[j]+" ");
                j++;
            }


            
        }
    }
}
