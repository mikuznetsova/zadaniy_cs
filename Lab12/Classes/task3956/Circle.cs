using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.task3956
{
    public class Circle :Shape

    {
        private int x;
        private int y;
        private int r;

        public Circle(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        
           
        }

        public Circle(int x, int y, int r, string stroke, string fill, int strokeWidth)
        {
            this.x = x;
            this.y = y;
            this.r = r;
            this.stroke = stroke;
            this.fill = fill;
            this.strokeWidth = strokeWidth;
        }
        public override Point getCenter()
        {
            return new Point(x,y);
        }
        public override double area()
        {
            return Math.PI*r*r;
        }
        public override void slide(int a, int b)
        {
            x = x + a;
            y = y + b;
        }
        public override string ToString()
        {
            return "<circle cx='"+x+ "' cy='" + y + "' r='" + r+ "'  stroke = '" + stroke + "' stroke - width = '" + strokeWidth + "' fill = '" + fill + "' />";

        }
    }
}

