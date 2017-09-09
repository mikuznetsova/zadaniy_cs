using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Classes.task9924;


namespace task9924
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
       
            ISet <Point> set = new HashSet <Point> ();
           
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();//читает строку до первого /n
                string[] arr = line.Split(';');
                int X =int.Parse( arr[0]);
                int Y = int.Parse(arr[1]);
                String C = arr[2];
                Point p = new Point(X, Y, C);
                if (set.Contains(p))
                { }
                else
                {
                    set.Add(p);
                }
             }
            reader.Close();

            foreach (var item in set)
            {
                Console.WriteLine( item);

            }
            
        }
    }
}
