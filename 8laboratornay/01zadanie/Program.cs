using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
           int a = int.Parse(Console.ReadLine()); 
            string t = Console.ReadLine();            
            string[] arr = t.Split(' ');
            if (a < 0 || a >= arr.Length)
            {
                Console.WriteLine("Число A должно быть в интервале [0, размер массива)");
                return;
            }
            if (String.IsNullOrEmpty(t))
            {
                Console.WriteLine("Исходная строка пуста");
                return;
            }
            Console.WriteLine(arr[a]);
        }
    }
}
