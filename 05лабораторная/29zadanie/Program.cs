using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            double xp, yp, xt,yt,h,w;
             xt = double.Parse(Console.ReadLine());
            yt = double.Parse(Console.ReadLine());
            xp = double.Parse(Console.ReadLine());
            yp = double.Parse(Console.ReadLine());
            h = double.Parse(Console.ReadLine());
            w = double.Parse(Console.ReadLine());
            if (yp < 0||yt<0)
            {
                Console.Write("Координата Y должна быть неотрицательной");
                return;
            }
            if (xp < 0 || xt < 0)
            {
                Console.Write("Координата X должна быть неотрицательной");
                return;
            }
            if (h <= 0 )
            {
                Console.Write("Высота должна быть положительна");
                return;
            }
            if (w <= 0)
            {
                Console.Write("Ширина должна быть положительна");
                return;
            }
            if (xp>=xt &&(xp+w)<=xt && yp>=yt&&(yp+h)<=yt)
            {
                Console.Write("точка внутри");
            }
            else
            {
                Console.Write("точка не внутри");
            }
        }
    }
}
