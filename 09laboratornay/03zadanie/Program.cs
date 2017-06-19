using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            string textIndex = Console.ReadLine();//ввели № 
            string textName = "test" + textIndex + ".txt";//узнали название фаила
            if (!File.Exists(textName))
            {
                Console.WriteLine("Файл не существует");
                return;
            }
            StreamReader reader = new StreamReader(textName);
            string line;
            int i = 0;
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
                    i++;
                }
                
            }
            reader.Close();
            Console.Write(i);
        }
    }
}
