using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5087
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            String[] arr = text.Split(' ');
            IList<string> list = new List<string> (arr);

            ISet<string> set = new HashSet <string>(arr);

            Console.WriteLine("Set: "+string.Join(" ", set));
            Console.WriteLine("list:"+ string.Join(" ", list ));

        }
    }
}
