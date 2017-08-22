using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Lab01
    {
        public static void task1860(String a)
        {
             Console.WriteLine("Мы стремимся к " + a);

        }

        public static void task4764(String a)
        {
            Console.WriteLine(a+" нас не остановят!" );
        }
        public static void task2429(String a)
        {
            Console.WriteLine("Программирование это "+a + "!");
        }

        public static void task7472(String a, String b)
        {
            Console.WriteLine(b + " " + a );
        }
        public static void task2862()
        {
            Console.WriteLine("{0:F4}",Math.PI);
            Console.WriteLine("{0:F4}",Math.E);
        }
        public static void task9231(double a)
        {
            Console.WriteLine("{0:F4}",a);
            
        }
        public static void task8624(int a)
        {
            Console.WriteLine("\""+ a+ "\"");

        }
        public static void task2959 (String id)
        {
            Console.WriteLine("SELECT first_name, last_name, group \n FROM students WHERE student_id = '" + id + "' ; ");

        }
        public static void task7271 (double x, double y)
        {
            Console.WriteLine("	INSERT INTO points (x, y) VALUES ('"+x+"', '" + y + "') ; ");

        }
        public static void task2632 (int x, int y, int r , String f)
        {
            Console.WriteLine("	<circle cx=\"" + x + "\" cy = \"" + y + "\n \"r = \""+r+ "\" fill = \"" +f+ "\" /> ");

        }
        public static void task4343 (String u, String p, String h, String port, String db)
        {
            Console.WriteLine("User ID=" + u + ";Password=" + p + "; Host = " +h + ";Port=" + port + ";Database="+db+";");

        }
    }
}
