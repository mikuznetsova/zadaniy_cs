using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Classes.task5108;

namespace task5108
{
    class Program
    {

        static void Main(string[] args)
        {
           
            string textIndex = Console.ReadLine();//ввели № 
            string textName = "test" + textIndex + ".csv";//узнали название фаила
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

           

            try
            {
                IDictionary <string, Rectangle> map = new Dictionary<string, Rectangle>();
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();//читает строку до первого /n
               
                    string[] arr = line.Split(';');
                    
                    
                    if (arr[0] == "create" && arr.Length == 6)
                    {
                        Rectangle r = new Rectangle(arr[2], arr[3], arr[4], arr[5] );


                        if (map.ContainsKey(arr[1]))
                        {
                            Console.WriteLine("Идентификатор не должен повторяться");
                            reader.Close();
                            return;
                        }
                        else
                        {
                            map.Add(arr[1], r);//добавить прямоугольник в лист
                        }
                    }
                    else if (arr.Length==3&& !map.ContainsKey(arr[1]))
                    {
                        Console.WriteLine("Операция над неопозанным объектом");
                        reader.Close();
                        return;
                    }

                    else if (arr.Length != 3 )
                    {
                        Console.WriteLine("Некорректный формат операции");
                        reader.Close();
                        return;
                    }

                    else if (arr[0].Equals("shiftX"))
                    {
                        map[arr[1]].shiftX(arr[2]);
                   
                    }
                    else if (arr[0].Equals("shiftY"))
                    {
                        map[arr[1]].shiftY(arr[2]);
                     
                    }
                    else if (arr[0].Equals("stretchX"))
                    {
                        map[arr[1]].stretchX(arr[2]);
                      
                    }
                    else if (arr[0].Equals("stretchY"))
                    {
                        map[arr[1]].stretchY(arr[2]);
                    }
                    else
                    {
                        Console.WriteLine("Некорректное действие: " + arr[0]);
                        reader.Close();
                        return;
                    }

                }

                List<string> keys = map.Keys.ToList();// создаем лист из ключей словаря
                keys.Sort();//сортируем
                foreach (string key in keys)//выводим ответ
                {
                    Console.WriteLine(key + " " + map[key]);
                }

                Console.WriteLine();
                
                foreach (var item in map)// item- это просто пременная
                {
                    Console.WriteLine(item.Key +  " " + item.Value);
                }

            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }

            reader.Close();
        }
    }
}
