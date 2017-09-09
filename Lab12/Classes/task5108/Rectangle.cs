
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Classes.task5108
{
    public class Rectangle
    {

        private int x;
        private int y;
        private int w;
        private int h;
        private int i = 0;

        public Rectangle(string x, string y, string w, string h)
        {
            this.x = int.Parse(x);
            this.y = int.Parse(y);
            this.w = int.Parse(w);
            this.h = int.Parse(h);

        }

        public void shiftX(string s)
        {
            int a = int.Parse(s);
            x = x + a;
            if (x < 0)
            {
                throw new InvalidOperationException("Координата X должна быть неотрицательной");

            }
            i++;
        }
        public void shiftY(string s)
        {
            int a = int.Parse(s);
            y = y + a;
            if (y < 0)
            {
                throw new InvalidOperationException("Координата Y должна быть неотрицательной");
            }
            i++;
        }
        public void stretchX(string s)
        {
            int a = int.Parse(s);
            w = w + a;
            if (w <= 0)
            {
                throw new InvalidOperationException("Ширина должна быть положительной");
            }
            i++;
        }

        public void stretchY(string s)
        {
            int a = int.Parse(s);
            h = h + a;
            if (h <= 0)
            {
                throw new InvalidOperationException("Высота должна быть положительной");
            }
            i++;
        }
        public override string ToString()
        {
            return " действий:"+i+" {\"x\":" + x + ",\"y\":" + y + ", \"w\":" + w + ",\"h\":" + h + "}";
        }

    }
}
