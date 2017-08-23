using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task7738
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
            string text;
            int i = 1;
          
            IDictionary<string, int> map = new Dictionary<string, int>();
            while (!reader.EndOfStream)
            {
                text = reader.ReadLine();//читает строку до первого /n
                i++;
                //map.Add(text, n);
                if (map.ContainsKey(text)) 
                {
                  int m=  map [text];//извлекли из кол-и ( определим № в нашей коллекции)
                    m++; //+1
                   map [text] = m ;//перезадать значениеmap.Add(text, m)
                }
                else
                {
                    map.Add(text, 1);
                }

               
            }
            foreach (var item in map)// item- это просто пременная
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }

            

        }
    }
}
