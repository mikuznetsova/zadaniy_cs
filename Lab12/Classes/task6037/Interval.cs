using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.task6037
{
    public class Interval
    {
        public int a;
        public int b;
        public static bool HasIntersection (Interval l, Interval r)
        {

            if (l.a > l.b || r.a > r.b)
            {
                throw new ArgumentException("Некорректный интервал");
            }

            if (l.a>r.b || r.a>l.b)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
