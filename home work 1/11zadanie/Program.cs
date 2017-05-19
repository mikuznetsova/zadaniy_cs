using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String cx, cy, r, fill;
            cx = Console.ReadLine();
            cy = Console.ReadLine();
            r = Console.ReadLine();
            fill = Console.ReadLine();
            Console.WriteLine("<circle cx=\""+cx+"\""+" cy=\""+cy+"\""+
                " r = \""+r+"\""+" fill = \""+fill+"\"/> ");
        }
    }
}
