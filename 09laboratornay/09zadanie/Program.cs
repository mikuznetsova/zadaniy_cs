using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace _09zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            string textIndex = Console.ReadLine();//ввели № 
            string t = "@";
            string textName = "test" + textIndex + ".txt";//узнали название фаила
            if (!File.Exists(textName))
            {
                Console.WriteLine("Файл не существует");
                return;
            }
            StreamReader reader = new StreamReader(textName);
            string line;
            string line2;
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
                    
                    line2 = line.Substring(line.IndexOf(t)+1 );

                    if (line2.Contains(t))
                    {
                        Console.WriteLine("Некорректный почтовый адрес");

                    }
                    else
                    {
                        if (line.IndexOf(t) == (line.Length - 1))
                        {
                            Console.WriteLine("Некорректный почтовый адрес");

                        }
                        else
                        {
                            line = line.Remove(line.IndexOf(t));
                            Console.WriteLine(line);
                        }
                    }
               }
                else
                {
                    Console.WriteLine("Некорректный почтовый адрес");
                  
                }
            }
            reader.Close();
        }
    }
}
