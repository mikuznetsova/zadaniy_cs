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

            IDictionary<string, Circle> mapc = new Dictionary<string, Circle>();
            IDictionary<string, Rectangle> mapr = new Dictionary<string, Rectangle>();
            try
            {
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();//читает строку до первого /n
                    
                    string[] arr = line.Split(';');
                    

                    if ((arr.Length ==4||arr.Length !=7&&arr[1].Contains("rectangle ")|| arr.Length !=6 && arr[1].Contains("circle "))
                    {
                        Console.WriteLine("Некорректный формат данных");
                        reader.Close();
                        return;
                    }
                    if(arr[1].Contains("rectangle "))
                    {
                        Rectangle r = new Rectangle(arr[3], arr[4], arr[5], arr[6], arr[2]);
                        mapr.Add(arr[2],r);
                    }
                    else if (arr[1].Contains("circle "))
                    {
                        Circle r = new Circle(arr[3], arr[4], arr[5], arr[2]);
                        mapc.Add(arr[2], r);
                    }
                    else if (arr[0].Equals("shiftX"))
                    {
                        r.shiftX(arr[1]);
                    }


                    else if(arr[0].Equals("shiftX"))
                    {
                        r.shiftX(arr[1]);
                    }
                    else if (arr[0].Equals("shiftY"))
                    {
                        r.shiftY(arr[1]);
                    }
                    else if (arr[0].Equals("stretchX"))
                    {
                        r.stretchX(arr[1]);
                    }
                    else if (arr[0].Equals("stretchY"))
                    {
                        r.stretchY(arr[1]);
                    }
                    else
                    {
                        Console.WriteLine("Некорректное действие: " + arr[0]);
                        reader.Close();
                        return;
                    }

                }

                Console.Write("действий:" + i + " " + r);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }

            reader.Close();
        }
    }
}