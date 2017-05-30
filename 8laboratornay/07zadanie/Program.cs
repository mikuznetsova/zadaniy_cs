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
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            string t = Console.ReadLine();
            string x;
            int i = 0;

            string[] arr = t.Split(' ');
            if (p < 0 ||p >= arr.Length)
            {
                Console.WriteLine("Число p должно быть в интервале [0, размер массива)");
                return;
            }
            if (q < 0 || q >= arr.Length)
            {
                Console.WriteLine("Число q должно быть в интервале [0, размер массива)");
                return;
            }
            x = arr[p];
            arr[p] = arr[q];
            arr[q] = x;

            while(i<arr.Length)
             {
                Console.Write(arr[i]);
                i++;
            }
        }
    }
}
