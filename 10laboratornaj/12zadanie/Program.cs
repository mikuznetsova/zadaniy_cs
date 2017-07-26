using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _12zadanie
  
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "out.txt";
            StreamWriter writer = new StreamWriter(filename);

            Random rnd = new Random();

            int nt = 30;//размер массива
            int nf = 20;//размер массива
            double R = 0;

            int a1,a2,b1,b2;

            writer.WriteLine("A1;B1;A2;B2;Результат");
            for (int i = 0; i < nt; i++)
            {

                a1 = rnd.Next(1, 999);
               b1 = rnd.Next(a1+1, a1+999);
                a2 = rnd.Next(a1 + 1, b1 - 1);
                b2 = rnd.Next(b1+ 1, b1 + 999);
                writer.WriteLine(a1+ ";" + b1 + ";" + a2 + ";" + b2 + ";" +"пересекаются ("+a2+"\\;"+b1+")");


            }
            for (int i = 0; i < nt; i++)
            {
                a2 = rnd.Next(1, 999);
                a1 = rnd.Next(a2+1, a2+999);
                b2 = rnd.Next(a1 + 1, a1 + 999);              
                b1 = rnd.Next(b2 + 1, b2 + 999);
                
                writer.WriteLine(a1 + ";" + b1 + ";" + a2 + ";" + b2 + ";" + "пересекаются (" + a1+ "\\;" + b2 + ")");


            }
            for (int i = 0; i < nt; i++)
            {
                a1 = rnd.Next(1, 999);
                a2 = rnd.Next(a1 + 1, a1+999);
                b2 = rnd.Next(a2 + 1, a2+999);
                b1 = rnd.Next(b2 + 1, b2 + 999);

                writer.WriteLine(a1 + ";" + b1 + ";" + a2 + ";" + b2 + ";" + "пересекаются (" + a2 + "\\;" + b2 + ")");


            }

            for (int i = 0; i < nt; i++)
            {
                a1 = rnd.Next(1, 999);
                b1 = rnd.Next(a1 + 1, a1 + 999);
                a2 = rnd.Next(b1 + 1, b1 +999);
                b2 = rnd.Next(a2 + 1, a2 + 999);

                writer.WriteLine(a1 + ";" + b1 + ";" + a2 + ";" + b2 + ";" + "не пересекаются " );


            }
            for (int i = 0; i < nt; i++)
            {
                a2 = rnd.Next(1, 999);
                b2 = rnd.Next(a2 + 1, a2 + 999);
                a1 = rnd.Next(b2 + 1, b2 + 999);
                b1 = rnd.Next(a1 + 1, a1 + 999);

                writer.WriteLine(a1 + ";" + b1 + ";" + a2 + ";" + b2 + ";" + "не пересекаются ");


            }
            for (int i = 0; i < nf; i++)
            {
                a1 = rnd.Next(1, 999);
                b1 = rnd.Next(a1-999, a1 -1);
                a2 = rnd.Next(a1 + 1, a1 + 999);
                b2 = rnd.Next(a2 + 1, a2 + 999);
                writer.WriteLine(a1 + ";" + b1 + ";" + a2 + ";" + b2 + ";" + "Значение A должно быть меньше значения B в 1ом отрезке ");


            }
            for (int i = 0; i < nf; i++)
            {
                a1 = rnd.Next(1, 999);
                b1 = rnd.Next(a1 + 1, a1 + 999);
                a2 = rnd.Next(b1 + 1, b1 + 999);
                b2 = rnd.Next(a2 -999, a2 -1);
                writer.WriteLine(a1 + ";" + b1 + ";" + a2 + ";" + b2 + ";" + "Значение A должно быть меньше значения B во 2ом отрезке ");


            }
            writer.Close();
        }
    }
}
