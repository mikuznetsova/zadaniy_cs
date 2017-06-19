using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02zadanie
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
            int i = 0;
            if (reader.EndOfStream)
            {
                Console.WriteLine("Файл пуст");
                reader.Close();
                return;
            }
            else
            {
                line = reader.ReadLine();
                Console.Write(line);
            }
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();//читает строку до первого /n
                i++;
            }
            reader.Close();
            Console.Write(" "+i);
        }
    }
}
