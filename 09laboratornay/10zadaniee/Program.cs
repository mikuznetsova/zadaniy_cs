using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _10zadaniee
{
    class Program
    {
        static void Main(string[] args)
        {
            string textIndex = Console.ReadLine();//ввели № 
            string a = "{";
            string b = "}";
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
            int i = 0;
            int j = 0;
            int n = 0;
            while (!reader.EndOfStream)
            {
               
                line = reader.ReadLine();//читает строку до первого /n
                
                
                    n = 0;
                    if (line.Contains(a))
                    {
                        while ((n= line.IndexOf(a, n)) != -1)
                        {

                            i++;
                            n += line.Length;
                        }
                    }
                    n = 0;
                    if (line.Contains(b))
                    {
                        
                        while ((n = line.IndexOf(b, n)) != -1)
                        {
 
                            j++;
                            n += line.Length;
                        }

                    }

                
                
               
            }
            if (i == j)
            {

                    Console.WriteLine(i);
              
            }
            else
            {
                if (i < j)
                {
                    Console.WriteLine("Неожиданная закрывающаяся скобочка");
                }
             else
                {
                    Console.WriteLine("Неожиданный конец файла");

                }

            }
            reader.Close();
        }
    }

}



