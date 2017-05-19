using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String user, pass, host, port, db;
            user = Console.ReadLine();
            pass = Console.ReadLine();
            host = Console.ReadLine();
            port = Console.ReadLine();
            db = Console.ReadLine();
            
            Console.WriteLine("\"User ID=" + user + "; Password=" + pass + "; host	=" + host + "; Port=" + port + "; Database=" + db+";");
        }
    }
}
