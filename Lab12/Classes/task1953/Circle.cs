using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.task1953
{
    public class Circle

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
        public override String ToString()
        {
            return "<circle cx = \"" + x +
                "\" cy = \"" + y +
                "\" r = \"" + r +
                "\" /> ";
        }
        public double area()
        {
            return Math.PI * r * r;
        }
        public Interval getProjectionX()
        {
            return new Interval(x-r, x + r);
        }
        public Interval getProjectionY()
        {
            return new Interval(y-r, y +  r);
        }
       
    }
}

