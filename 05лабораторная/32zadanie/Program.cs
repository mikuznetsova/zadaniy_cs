using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1,y1, x2, y2, h1, h2,w1,w2;
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
           h1 = double.Parse(Console.ReadLine());
            w1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            h2 = double.Parse(Console.ReadLine());
            w2 = double.Parse(Console.ReadLine());
            if (h1 <= 0||h2<=0)
            {
                Console.Write("Высота должна быть положительна");
                return;
            }
           
            if (x2>=x1&&x2<=(x1+w1)&&y2>x1&&y2<=(y1+h1))
            {
                Console.Write("{\"x\":" + x2+","+ "{\"y\":"+y2);
            }

            if (x2 >= x1 && x2 <= (x1 + w1) && (y2 > (y1+h1) || y2 < y1))
            {
                Console.Write("{\"x\":" + x2+"," + "{\"y\":" + y1);
            }


            if (((x2 < x1 ||x2 > (x1 + w1) )&& y2 > x1 && y2 <= (y1 + h1))
            {
                Console.Write("{\"x\":" + x1+"," + "{\"y\":" + y2);
            }
            if ((y2+h2)<= (y1 + h1))
             {
                Console.Write(",\"h\":" + h2);
            }
            if ((y2 + h2) > (y1 + h1))
             {
                Console.Write(",\"h\":" + h1);
            }
            if ((x2 + w2) <= (x1 + w1))
            {
                Console.Write(",\"w\":" + w2);
            }
            if ((w2 + w2) > (w1 + w1))
            {
                Console.Write(",\"w\":" + w1);
            }
            if( ((x2 + w2) < x1|| (x1 + w1) < x2 )&& ((y2 + h2) <y1) ||y2> (y1 + h1))
             {
                Console.Write("не пересекаются");
            }
        }
    }
}
