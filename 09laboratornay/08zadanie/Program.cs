using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace _08zadanie
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
            string line;

          
            if (reader.EndOfStream)
            {
                Console.WriteLine("0");
                reader.Close();
                return;
            }

            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();//читает строку до первого /n


                line = line.Substring(line.IndexOf("\\") + 1);//обрежем до последнего/
                while (line.Contains("\\"))
                {
                    line = line.Substring(line.IndexOf("\\"));
                }
                line = line.Remove(line.IndexOf("."));//обрежем все после .
                if (line.Contains("\\") || line.Contains("*")//проверка
                    || line.Contains("|") || line.Contains(":")
                   || line.Contains("\"") || line.Contains("?")
                   || line.Contains("<") || line.Contains(">")
                   || line.Contains("/"))
                {
                    Console.WriteLine("Некорректное имя файла");
                  
                }
                else
                {
                    Console.WriteLine(line);
                }
                        
            }
            
            
            reader.Close();
        }
    }
}
