using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _09zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
           
            int n = 100;//размер массива
          
            double circumference = 0;

            int[] arr = new int[n];
           // StreamWriter csv = new StreamWriter("test.csv", true, System.Text.Encoding.GetEncoding(1251)); // Win-кодировка
           // csv.WriteLine("field1; field2"); // это заголовок. разделитель ; может быть другим

            for (int i = 0; i < n; i++ )
            {
                arr[i] = rnd.Next(1, 999);

                circumference = 2*Math.PI* arr[i];

               // csv.WriteLine(arr[i].ToString() + ";");
                //csv.WriteLine(circumference.ToString() + ";");
               
            }
            
           // csv.Close();
        }
        
    }
}
