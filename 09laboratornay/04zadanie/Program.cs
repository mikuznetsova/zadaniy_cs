﻿using System;
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
            string line="";
            
            if (reader.EndOfStream)
            {
                Console.WriteLine("Файл пуст");
                reader.Close();
                return;
            }
            
               
               
                while (!reader.EndOfStream )
                {
                line = reader.ReadLine();//читает строку до первого /n
               while( line.Contains("  ",))
                {
               line = line.Replace("  ", " ");
                    
                    Console.WriteLine(line);
                }
                
                }
             string[] arrSumm  = line.Split(new char[] { ' '});
           
            reader.Close();
            Console.Write(arrSumm.Length);
        }
    }
}
