using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _13zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string textIndex = Console.ReadLine();//ввели № 
            string textName = "test" + textIndex + ".html";//узнали название фаила
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
            String pattern = "<[a-zA-Z]*\\s[a-zA-Z]*=\"[a-zA-Z]*\"\\svalue=\"([a-zA-Zа-яА-Я0-9 ]*)\"\\sname=\"([a-zA-Z]*)\"\\/>[а-яА-Я ]*";
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();//читает строку до первого /n
               if (Regex.IsMatch(line,pattern))
                {
                    i = 0;
                    MatchCollection vskobkahPattern = Regex.Matches(line, pattern);
                    while (i < vskobkahPattern.Count)
                    {
                        Console.Write(vskobkahPattern[i].Groups[2]+"="+ vskobkahPattern[i].Groups[1] + "&");
                        i++;
                    }

                }
            }
            
            reader.Close();
          
        }
    }
}
