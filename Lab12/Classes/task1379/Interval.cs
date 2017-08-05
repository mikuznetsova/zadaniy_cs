using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.task1379
{

    public class Interval
    {
        public int a;
        public int b;
        public  void slide (int x)
        {
            if (a >= b)
            {
                throw new InvalidOperationException("Корректность интервала была нарушена");

            }
            a = a + x;
            b = b + x;

        }

        public String print()
        {
            if (a >= b)
            {
                throw new InvalidOperationException("Корректность интервала была нарушена");

            }
            return "[" + a + ";" + b + "]";
        }

    }
}
