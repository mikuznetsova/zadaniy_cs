using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int w= int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
           
            if (h < 0 ||w < 0||x>800||y>600||x+w>800||y+h>600)
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
            writer.WriteLine("<rect x=\"" + x + "\" y=\"" + y + "\" width =\"" + w + "\" height  =\"" + h + "\" stroke=\"blue\" stroke-width=\"2\" fill=\"red\" />");
            writer.WriteLine("</svg>");
            writer.WriteLine("</body>");
            writer.WriteLine("</html>");
            writer.Close();
            System.Diagnostics.Process.Start(filename);//открывает самостоятельно в дальнейшем
        }
    }
}
