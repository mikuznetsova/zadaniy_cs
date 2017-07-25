using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08zdanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int x = int.Parse(Console.ReadLine());
            int n = rnd.Next(0, x);//размер массива
            double j = 0;
            double S = 0;

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(100, 999);
                Console.WriteLine(arr[i]+" ");
                 S = S + arr[i];
                j++;
            }
            Console.WriteLine("Прибыль = " +S);
            Console.WriteLine("Ср.чек = " + (S/j));
        }
    }
}
