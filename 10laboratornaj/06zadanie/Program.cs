using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace _06zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random ();
            int n = rnd.Next(0, 100);//размер массива
            int[] arr = new int[n];
            for (int i=0; i<n; i++)
            {
                arr[i] = rnd.Next(100, 999);
                Console.Write(arr[i]+" ");
            }
        }
    }
}
