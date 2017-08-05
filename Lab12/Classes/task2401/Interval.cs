using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.task2401
{
    public class Interval
    {
        public int a;
        public int b;
        public void squeeze (int x)
        {
           
            if (a >= b)
            {
                throw new InvalidOperationException("Корректность интервала была нарушена");

            }
          if (x>= (b-a))
            {
                throw new ArgumentException ("Невозможно уменьшить интервал на указанную длину");

            }
            b = b - x;
            
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
