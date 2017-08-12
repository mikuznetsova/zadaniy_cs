using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.task5032
{
    public class Rectangle
    {

        private int x;
        private int y;
        private int w;
        private int h;

        public Rectangle(int x, int y, int w, int h)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
        }
        public  void shiftX (string s)
        {
            int a = int.Parse(s);
            x = x + a;
            if (x <= 0)
            {
                throw new InvalidOperationException("Координата X должна быть неотрицательной");

            }
        }
        public void shiftY(string s)
        {
            int a = int.Parse(s);
            y = y + a;
            if (y <= 0)
            {
                throw new InvalidOperationException("Координата Y должна быть неотрицательной");
                
            }
        }
        public void stretchX(string s)
        {
            int a = int.Parse(s);
            w =w+ a;
            if (w <= 0)
            {
                throw new InvalidOperationException("Ширина должна быть положительной");

            }
        }
        public void stretchY(string s)
        {
            int a = int.Parse(s);
            h = h + a;
            if (h <=0)
            {
                throw new InvalidOperationException("Высота должна быть положительной");

            }
        }
        public override string ToString()
        {
            return "{\"x\":" + x + ",\"y\":" + y + ", \"w\":" + w + ",\"h\":" + h + "}";
         }

    }
}
