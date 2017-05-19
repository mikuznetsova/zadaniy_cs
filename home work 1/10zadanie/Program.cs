using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String x, y;
            x = Console.ReadLine();
            y = Console.ReadLine();
            Console.WriteLine("INSERT INTO points(x, y) VALUES('"+x+"', '"+y+"');");
        }
    }
}
