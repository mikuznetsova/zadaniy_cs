using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.task3956
{
    public class Rectangle : Shape
    {

        private int x;
        private int y;
        private int w;
        private int h;

        public Rectangle(int x, int y, int w, int h,  string stroke, string fill, int strokeWidth)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
            this.stroke = stroke;
            this.fill = fill;
            this.strokeWidth = strokeWidth;


        }

        public Rectangle(int x, int y, int w, int h)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
        }
        public override Point getCenter()
        {
            return new Point(x+w/2,y+ h/2);
        }
        public override  double area()
        {
            return  w*h;
        }
        public override void slide (int a, int b)
        {
            x = x + a;
            y = y + b;
        }
        public override string ToString()
        {
            return "< rect x = '" + x + "' y = '" + y + "' width = '" + w + "' height = '" + h + "'  stroke = '" + stroke + "' stroke - width = '" + strokeWidth + "' fill = '" + fill + "' />";

        }
    }

}
