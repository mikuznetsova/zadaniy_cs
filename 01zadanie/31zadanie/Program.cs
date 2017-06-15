using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31zadanie
{
    class Program
    {
        static void Main(string[] args)
        {//Получить от пользователя значение
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            int n, k, j, i;
            n = 0;
            k = 0;
            i = 0;
            j = 0;
            //Если значения отрицательны, вывести сообщение об ошибке и завершить работу программы

            if (w < 0)
            {
                Console.WriteLine("Значение W должно быть неотрицательно");
                return;
            }
            if (h < 0)
            {
                Console.WriteLine("Значение H должно быть неотрицательно");
                return;
            }
            //Если значения 0, то завершить работу программы
            if (w = 0)
            {
                return;
            }
            if (h = 0)
            {
                return;
            }
            //нечнем с паробела в 1 строке
            Console.Write(" ");
            //Напечатать символ "0-w" 

            while (n < w)
            {
                Console.Write(n);
                n++;
            }
                        //след-e строки
            Console.WriteLine();
            //повторить К раз ... 
            //...1ый символ=к...
            //...пробелы в колличестве w раз...
            //...последний символ "|"
            while (k <= h)
            {
                i = 0;
                Console.Write(k);
                while (i <= w)
                {
                    Console.Write(" ");
                    i++;
                }
                k++;
                Console.Write("|");
            }
            //последняя строка начиная с пробела...
            //...символами "-" в кол-ве w раз
            Console.WriteLine();
            Console.Write(" ");
            i = 0;
            while (i <= w)
            {
                Console.Write("-");
                i++;

            }
        }
    }
}

