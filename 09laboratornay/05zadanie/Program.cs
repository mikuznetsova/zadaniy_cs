using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace _05zadanie
{
    class Program
    {
        static void Main(string[] args)
        {

            string textIndex = Console.ReadLine();//ввели № 
            string textName = "test" + textIndex + ".txt";//узнали название фаила
            if (!File.Exists(textName))
            {
                Console.WriteLine("Файл не существует");
                return;
            }
            StreamReader reader = new StreamReader(textName);
            string line = "";

            if (reader.EndOfStream)
            {
                Console.WriteLine("Файл пуст");
                reader.Close();
                return;
            }

            int s = 0;
            int i = 1;
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();//читает строку до первого /n

                if (4 < line.Length)
                {
                    Console.WriteLine("Запись длиннее четырех символов");
                    return;
                }
                while (i < 6)
                {
                    line = line.Insert(i, " ");
                   
                    i = i + 2;

                }
                i = 1;
                string[] arr = line.Split(new char[] { ' ' });

                if (arr[0] == arr[1] || arr[2] == arr[1] || arr[2] == arr[3] )
                {
                    s = s + 1;
                }
            }
            reader.Close();
               Console.Write(s);

        }
        
    }
}



