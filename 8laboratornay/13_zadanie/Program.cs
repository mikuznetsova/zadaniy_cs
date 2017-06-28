using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            string x = Console.ReadLine();
            string s= "a,b,c,d,e,f,g,h";
            string[] arr = s.Split(',');
            while (i < arr.Length)
            {
                if (arr[i] == x)
                {
                    Console.WriteLine(arr[i] + "+ ");
                }
                else
                {
                    Console.WriteLine(arr[i]);
                }
                i++;
            }
        }
    }
}
