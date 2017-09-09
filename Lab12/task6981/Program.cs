using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Classes.task6981;


namespace task6981
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
            int errorCount = 0;
            IDictionary<string, Circle> mapc = new Dictionary<string, Circle>();
            IDictionary<string, Rectangle> mapr = new Dictionary<string, Rectangle>();


            IDictionary<string, Shape> maps = new Dictionary<string, Shape>();// вариант с 1 словарем смотрим на maps

            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();//читает строку до первого /n

                string[] arr = line.Split(';');

                try
                {
                    

                    selectAction(arr, maps, mapr, mapc);
                }
                catch (InvalidOperationException e)
                {
                    errorCount++;
                }
                catch (FormatException e)
                {
                    errorCount++;
                }
                catch (KeyNotFoundException e)
                {
                    errorCount++;
                }
            }

            foreach (var item in maps)
            {
                Console.WriteLine(item.Value);
               
            }
            Console.WriteLine("Некорректных записей:"+ errorCount);
            reader.Close();

        }

       public static void selectAction(string []arr, IDictionary<string, Shape> maps, IDictionary<string, Rectangle> mapr, IDictionary<string, Circle> mapc)
        {
            if (arr[1].Contains("rectangle"))
            {
                if (arr.Length != 7)
                {
                    throw new FormatException("Неокрректный формат r");
                }
                if(mapr.ContainsKey(arr[2]))
                {
                    throw new InvalidOperationException("есть такое id");
                }
                Rectangle r = new Rectangle(arr[3], arr[4], arr[5], arr[6], arr[2]);
                mapr.Add(arr[2], r);
                maps.Add(arr[2], r);
            }
            else if (arr[1].Contains("circle"))
            {
                if (arr.Length != 6)
                {
                    throw new FormatException("Неокрректный формат c");
                }
                if (mapc.ContainsKey(arr[2]))
                {
                    throw new InvalidOperationException("есть такое id");
                }
                Circle r = new Circle(arr[3], arr[4], arr[5], arr[2]);
                mapc.Add(arr[2], r);
                maps.Add(arr[2], r);
            }
            else if (arr[0].Equals("shiftX"))
            {
                if (arr.Length != 4)
                {
                    throw new FormatException("Неокрректный формат shiftX");
                }
                
                String id = arr[1];
                String value = arr[2];
                //if (mapr.ContainsKey(id))// когда 2 словаря
                //{
                //    mapr[id].shiftX(value);
                //}
                //if (mapc.ContainsKey(id))
                //{
                //    mapc[id].shiftX(value);
                //}
                
                    maps[id].shiftX(value);
                                                   
                
            }


            else if (arr[0].Equals("shiftY"))
            {
                if (arr.Length != 4)
                {
                    throw new FormatException("Неокрректный формат shiftY");
                }
                String id = arr[1];
                String value = arr[2];
                //if (mapr.ContainsKey(id))// когда 2 словаря
                //{
                //    mapr[id].shiftY(value);
                //}
                //if (mapc.ContainsKey(id))
                //{
                //    mapc[id].shiftY(value);
                //}
               
                    maps[id].shiftY(value);
                

            }
            else if (arr[0].Equals("stretchX"))
            {
                if (arr.Length != 4)
                {
                    throw new FormatException("Неокрректный формат stretchX");
                }
                String id = arr[1];
                String value = arr[2];
                //if (mapr.ContainsKey(id))// когда 2 словаря
                //{
                //    mapr[id].stretchX(value);
                //}
                //if (mapc.ContainsKey(id))
                //{
                //    mapc[id].stretchX(value);
                //}
                
                    maps[id].stretchX(value);
                

            }
            else if (arr[0].Equals("stretchY"))
            {
                if (arr.Length != 4)
                {
                    throw new FormatException("Неокрректный формат stretchY");
                }
                String id = arr[1];
                String value = arr[2];
                //if (mapr.ContainsKey(id))// когда 2 словаря
                //{
                //    mapr[id].stretchY(value);
                //}
                //if (mapc.ContainsKey(id))
                //{
                //    mapc[id].stretchY(value);
                //}
               
                    maps[id].stretchY(value);
                
            }
            else
            {
                throw new InvalidOperationException ("Некорректное действие: " + arr[0]);
               
            }

        }
    }
    
}