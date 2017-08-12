using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.task3956
{
    public class Point
    {
        public int X { private set; get; }
        public int Y { private set; get; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public String print()
        {
            return "(" + X + ";" + Y + ")";
        }
        public override bool Equals(Object o)
        {
            if (this == o) return true;
            if (o == null || GetType() != o.GetType()) return false;
            Point i = (Point)o;
            if (X != i.X) return false;
            else return Y == i.Y;
        }
    }
}

