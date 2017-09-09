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
   


        public Rectangle(string x, string y, string w, string h, string id)
        {
            this.x = int.Parse(x);
            this.y = int.Parse(y);
            this.w = int.Parse(w);
            this.h = int.Parse(h);
            this.id = id;


        }
        public override void shiftX(string s)
        {
            int a = int.Parse(s);
            if (x +a <= 0)
            {
                throw new InvalidOperationException("Координата X должна быть неотрицательной");
               
            }
            x = x + a;
            n++;
           
           
        }
        public override void shiftY(string s)
        {
            int a = int.Parse(s);
            if (y + a <= 0 )
            {
                throw new InvalidOperationException("Координата Y должна быть неотрицательной");

            }
            y = y + a;
            n++;
            
        }
        public override void stretchX(string s)
        {
            int a = int.Parse(s);
           if (w+a <= 0)
            {
                throw new InvalidOperationException("Ширина должна быть положительной");

            }
            w = w + a;
             n++;
            
        }
        public override void stretchY(string s)
        {
            int a = int.Parse(s);
            if (h+a <= 0)
            {
                throw new InvalidOperationException("Высота должна быть положительной");

            }
            h = h + a;
            n++;
           
        }
        public override string ToString()
        {
            return base.ToString() + "{\"x\":" + x + ",\"y\":" + y + ", \"w\":" + w + ",\"h\":" + h + "}";
            // base-вызов метода из родительского класса (shape)
        }

    }
}