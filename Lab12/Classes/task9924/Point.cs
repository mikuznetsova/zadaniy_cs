using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.task9924
{
    public class Point
    {
        public int X { private set; get; }
        public int Y { private set; get; }
        public String C { private set; get; }

        public Point(int x, int y, String c)
        {
            this.X = x;
            this.Y = y;
            this.C = c;
        }
        public override int GetHashCode()
        {
            return X*Y+X;
        }
        public override bool Equals(Object o)
        {
            //Сравнение с собой
            if (this == o) return true;
            //Есть ли с чем сравнивать?
            if (o == null
                //Совпадает ли тип?
                || GetType() != o.GetType()) return false;

            //для удобства, приводим тип
            Point point = (Point)o;

            if (X != point.X)
            {
                return false;
            }
            else
            {
                if (Y ==point.Y)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public override string ToString ()
        {
           
            return " { \"x\":" + X + ", \"y\":" + Y + ", \"color\":\"" + C + "\" }";
        }
        
    }
}
