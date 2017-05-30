using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            string t = Console.ReadLine();
           
            string[] arr = t.Split(' ');
            if ( b< 0 || b >= arr.Length)
            {
                Console.WriteLine("Число B должно быть в интервале [0, размер массива)");
                return;
            }
            if(e < 0 || e >= arr.Length)
            {
                Console.WriteLine("Число E должно быть в интервале [0, размер массива)");
                return;
            }

            if (b >= e)
                
            {
                int i = e;
                while (i <= b)
                {
                    Console.Write(arr[i] + " ");
                    i++;
                }
            }

            else
            {
                int i = b;
                while (i <= e )
                {
                    Console.Write(arr[i] + " ");
                    i++;
                }
            }
        }     
    }
}
