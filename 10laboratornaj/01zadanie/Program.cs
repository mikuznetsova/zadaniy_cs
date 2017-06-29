using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int cx = int.Parse(Console.ReadLine());
            int cy = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
            string sw = Console.ReadLine();
            if (cy - r < 0 || cx - r<0)
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
            writer.WriteLine("<circle cx=\""+cx+ "\" cy=\"" + cy+ "\" r=\"" + r + "\" stroke=\"green\" stroke-width=\"" + sw + "\" fill=\"yellow\" />");
            writer.WriteLine("</svg>");
            writer.WriteLine("</body>");
            writer.WriteLine("</html>");
            writer.Close();
            System.Diagnostics.Process.Start(filename);//открывает самостоятельно в дальнейшем

        }
    }
}
