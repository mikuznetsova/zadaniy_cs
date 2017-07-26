using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04zadanie
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

            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();//читает строку до первого /n
                if (!string.IsNullOrWhiteSpace(line))
                {

                    while (line.Contains("  "))
                    {
                        line = line.Replace("  ", " ");

                    }
                    string[] arrSumm = line.Split(new char[] { ' ' });
                    s = s + arrSumm.Length;
                }

            }
            reader.Close();

            Console.Write(s);
        }
    }
}



