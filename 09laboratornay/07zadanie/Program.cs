using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _07zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            string textIndex = Console.ReadLine();//ввели № 
            string a = Console.ReadLine();
            string b = Console.ReadLine();
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

                if (line.Contains(a)&& line.Contains(b) )
                
                {

                    line = line.Substring(line.IndexOf(a) + 1);
                    if (line.Contains(a))
                    {
                        Console.WriteLine("В данной строке несколько искомых букв 'A'");
                        return;
                    }
                    else
                    {
                       
                        if (line.Contains(b))
                        {
                            line2 = line.Substring(line.IndexOf(b) + 1);
                            if (line2.Contains(b))
                            {
                                Console.WriteLine("В данной строке несколько искомых букв 'B'");
                                return;
                            }
                            else
                            {
                                line = line.Remove(line.IndexOf(b));
                                Console.Write(line.Length);

                            }
                        }
                       
                    }
                }
                else
                {
                    Console.WriteLine("Одна из указанных букв не найдена");
                    return;
                }
            }
            reader.Close();

        }
    }
}
