using System;
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
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int w2 = int.Parse(Console.ReadLine());
            int h2 = int.Parse(Console.ReadLine());


            if (h < 0 || w < 0 || x > 800 || y > 600 || x + w > 800 || y + h > 600)
            {
                Console.WriteLine("Ошибка");
                return;
            }
            if (h2 <= 0 || w2 < 0 || x2 > 800 || y2 > 600 || x2 + w2 > 800 || y2 + h2 > 600)
            {
                Console.WriteLine("Ошибка2");
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
            writer.WriteLine("<rect x=\"" + x + "\" y=\"" + y + "\" width =\"" + w + "\" height  =\"" + h + "\"  fill=\"blue\" opacity=\"0.5\"/>");
            writer.WriteLine("<rect x=\"" + x2 + "\" y=\"" + y2 + "\" width =\"" + w2 + "\" height  =\"" + h2 + "\" fill=\"red\" opacity=\"0.5\" />");
       
            writer.WriteLine("</svg>");
            writer.WriteLine("</body>");
            writer.WriteLine("</html>");
            writer.Close();
            System.Diagnostics.Process.Start(filename);
        }
    }
}
