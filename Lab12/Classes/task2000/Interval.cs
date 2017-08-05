using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.task2000
{
    public class Interval
       
    {
        public int a;
        public int b;

        public Interval (int a, int b)
        {
            if (a >= b)
            {
                throw new ArgumentException("Некорректный интервал");

            }
            this.a = a;
            this.b = b;

        }
        public String print()
        {
            if (a >= b)
            {
                throw new InvalidOperationException("Корректность интервала была нарушена");

            }
            return "[" + a + ";" + b + "]";
        }
        public void slide( int x)
        {
            
            a = a + x;
            b = b + x;
        }
        public void squeeze(int x)
        {
            if (x >= (b - a))
            {
                throw new ArgumentException ("Невозможно уменьшить интервал на указанную длину");

            }
         
            b = b - x;
        }
        public int length ()
        {

            return b - a;
        }
    }
}
