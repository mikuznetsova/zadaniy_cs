using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
            
            if (h <= 0 || w <= 0 || x > 800 || y > 600 || x + w > 800 || y + h > 600)
            {
                Console.WriteLine("Ошибка при формировании квадрата");
                return;
            }
            if (y - r < 0 || x - r < 0||x+w-r<0||y+h-r<0)
            {
                Console.WriteLine("Ошибка -круг не формируется ");
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
            writer.WriteLine("<rect x=\"" + x + "\" y=\"" + y + "\" width =\"" + w + "\" height  =\"" + h + "\" fill=\"red\" />");
            writer.WriteLine("<circle cx=\"" + x + "\" cy=\"" + y + "\" r=\"" + r + "\" fill=\"yellow\" \" opacity=\"0.5\" />");
            writer.WriteLine("<circle cx=\"" + (x+w) + "\" cy=\"" + y + "\" r=\"" + r + "\" fill=\"yellow\" \" opacity=\"0.5\" />");
            writer.WriteLine("<circle cx=\"" + x + "\" cy=\"" + (y+h) + "\" r=\"" + r + "\" fill=\"yellow\" \" opacity=\"0.5\" />");
            writer.WriteLine("<circle cx=\"" + (x + w) + "\" cy=\"" + (y+h) + "\" r=\"" + r + "\" fill=\"yellow\" \" opacity=\"0.5\" />");
            
            writer.WriteLine("</svg>");
            writer.WriteLine("</body>");
            writer.WriteLine("</html>");
            writer.Close();
            System.Diagnostics.Process.Start(filename);//открывает самостоятельно в дальнейшем
        }
    }
}
