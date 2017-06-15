using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15zadanie
{
    class Program
    {
        static void Main(string[] args)
        {//получаем 2 масива для сравнения
            string M1 = Console.ReadLine();
            string[] m1 = M1.Split(' ');
           
            string[] m2 =Console.ReadLine().Split(' ');

            //выводим горизонталь (пробел и значения массива 1 
            int i=0;
            Console.Write(" ");
            while (i<m1.Length)
            {
                Console.Write(m1[i]);
                i++;
            }
            //повторяем след-ие строки...
            //...выводим первое значение массива2...
            //... проверяем совподает ли значения в стр и столбце ...
            //... если совподает ставим "+" если нет то пусто...
            //...последний символ стр "|"
            Console.WriteLine();
            i = 0;
            int j =0;
            while (i < m2.Length)
            {
                Console.Write(m2[i]);
              
                while (j<m1.Length)
              {
                  if (m2[i]==m1[j])
                  {
                      Console.Write("+"); 
                      
                  }
                  else
                  {
                      Console.Write(" "); 
                     
                  }
                
                j++;

              }
               Console.Write("|");
               i++;
               j = 0; 
                Console.WriteLine();
            }
           
            // последняя строка пробел с последующим символом "-" = длине 1ого массива
            Console.Write(" ");
            i = 0;
            while (i < m1.Length)
            {
                Console.Write("-");
                i++;
            }

        }
    }
}
