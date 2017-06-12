using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            string t, s = "abcdacadbacdaabaadc";
            t = Console.ReadLine();
            if (t.Length<2|| t.Length > 2)
            {
                Console.WriteLine("Вводимая строка должна содержать ровно 2 символа");
                return;

            }
            int i=0;

            while((i=s.IndexOf(t,i))!=-1)
                {
                     
                Console.Write(i+" ");
                i += t.Length;    
                }
                

        }
    }
}
