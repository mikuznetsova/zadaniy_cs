using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int  i = 0;
            int j = 0;
            int r = 0;
            string x = Console.ReadLine();
            string s = Console.ReadLine();
            string[] arrX = x.Split(' ');
            string[] arrS = s.Split(' ');

            if (String.IsNullOrEmpty(x))
            {
               
                Console.WriteLine("Данные сверху отсутствуют");
                return;
            }
            if (String.IsNullOrEmpty(s))
            { 
                Console.WriteLine("Данные снизу отсутствуют");
                return;
            }
            while (i < arrS.Length)
            {
                while (j < arrX.Length)
                {
                    if (arrS[i] == arrX[j])
                    {
                        r++; ;
                    }
                    
                    j++;
                }
                i++;
                j = 0;
            }
            Console.WriteLine("Повторений: "+r); 
        }
        
    }
}
