using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String i;
            i = Console.ReadLine();
                        Console.WriteLine("SELECT first_name, last_name, group\n"+
                            "FROM students WHERE id ='"+i+"'");
        }
    }
}
