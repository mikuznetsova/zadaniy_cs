using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.task6981
{
    public class Rectangle:Shape
    {
        private int x;
        private int y;
        private int w;
        private int h;
        private int n;

        public Rectangle(string x, string y, string w, string h, string id)
        {
            this.x = int.Parse(x);
            this.y = int.Parse(y);
            this.w = int.Parse(w);
            this.h = int.Parse(h);
            this.id = id;


        }
        public void shiftX(string s)
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
            w = w + a;
            if (w <= 0)
            {
                throw new InvalidOperationException("Ширина должна быть положительной");

            }
        }
        public void stretchY(string s)
        {
            int a = int.Parse(s);
            h = h + a;
            if (h <= 0)
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