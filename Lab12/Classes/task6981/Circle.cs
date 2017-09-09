using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.task6981
{
    public class Circle : Shape
    {
        private int x;
        private int y;
        private int r;


        public Circle(string x, string y, string r, string id)
        {
            this.x = int.Parse(x);
            this.y = int.Parse(y);
            this.r = int.Parse(r);
            this.id = id;
        }
        public void shiftX(string s)
        {
            int a = int.Parse(s);
            x = x + a;
            n++;
            if (x <= 0)
            {
                throw new InvalidOperationException("Координата X должна быть неотрицательной");

            }
        }
        public void shiftY(string s)
        {
            int a = int.Parse(s);
            y = y + a;
            n++;
            if (y <= 0)
            {
                throw new InvalidOperationException("Координата Y должна быть неотрицательной");

            }
        }
        public void stretchX(string s)
        {
            this.stretchXY(s);
            if (x <= 0 || y <= 0 || r <= 0)
            {
                throw new InvalidOperationException("Ширина должна быть положительной");

            }
        }
        public void stretchY(string s)
        {
            this.stretchXY(s);
            if (x <= 0 || y <= 0 || r <= 0)
            {
                throw new InvalidOperationException("Высота должна быть положительной");

            }
        }
        private void stretchXY(string s)
        {
            int a = int.Parse(s);
            x = x + a / 2;
            y = y + a / 2;
            r = r + a / 2;
            n++;
        }


        public override string ToString()
        {
            return "{\"cx\":" + x + ",\"cy\":" + y + ", \"r\":" + r + "}";
        }

    }
}



    

