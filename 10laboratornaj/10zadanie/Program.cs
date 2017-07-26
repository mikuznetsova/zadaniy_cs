using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _10zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "out.txt";
            StreamWriter writer = new StreamWriter(filename);

            Random rnd = new Random();

            int n = 100;//размер массива

            double R = 0;

            int X, Y;
           
            writer.WriteLine("x;y;r");
            for (int i = 0; i < n; i++)
            {
                
             X = rnd.Next(0, 999);
              Y = rnd.Next(0, 999);
                R = -5 * Math.Sqrt(X + Math.Sqrt(Y));

                writer.WriteLine(X + ";" + Y+ ";"+ R);


            }
            writer.Close();
        }

    }
}

