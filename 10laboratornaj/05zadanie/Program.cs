using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace _05zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int A = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            double h = Math.Sqrt(L * L - (A * A / 4));
            int X = x + A;
            int X2 = X/2;
            double Y = y + h;
            if (L < 0 || A < 0 || x > 800 || y > 600 || X > 800 || Y > 600)
            {
                Console.WriteLine("Ошибка");
                return;
            }
            string filename = "out.html";
            StreamWriter writer = new StreamWriter(filename);
            writer.WriteLine("<!DOCTYPE html>");
            writer.WriteLine("<html>");
            writer.WriteLine("<head>");
            writer.WriteLine("<meta charset=\"utf - 8\"/>");
            writer.WriteLine("<head/>");
            writer.WriteLine("<body>");

            writer.WriteLine("<svg width=\"800\" height=\"600\">");
            writer.WriteLine("<polygon points =\""+x+", "+y+X,y+ X2,Y +"\" stroke=\"blue\" stroke-width=\"10\" /> ");
            

                 writer.WriteLine("</svg>");
            writer.WriteLine("</body>");
            writer.WriteLine("</html>");
            writer.Close();
            System.Diagnostics.Process.Start(filename);
        }
    }
}
