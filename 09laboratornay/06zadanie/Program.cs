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

            string textIndex = Console.ReadLine();//ввели № 
            string t = Console.ReadLine();
            string textName = "test" + textIndex + ".txt";//узнали название фаила
            if (!File.Exists(textName))
            {
                Console.WriteLine("Файл не существует");
                return;
            }
            StreamReader reader = new StreamReader(textName);
            string line;
          
            int s = 0;
            if (reader.EndOfStream)
            {
                Console.WriteLine("0");
                reader.Close();
                return;
            }

            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();//читает строку до первого /n


                if (line.Contains(t))
                {

                    line = line.Substring(line.IndexOf(t) + 1);
                    if (line.Contains(t))
                    {
                        Console.WriteLine("В данной строке несколько искомых букв");
                        return;
                    }
                    else
                    {
                        s = line.Length;

                        Console.Write(s);

                    }
                }
                else
                {
                    Console.WriteLine("Указанная буква не найдена");
                    return;

                }
            }
            reader.Close();

            
        }
    }
}

