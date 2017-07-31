using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.task9914
{
    public class Interval
    {
        public int a;
        public int b;
        public bool Intersects(Interval r)
        {
            if (r == null)
            {
                throw new ArgumentException("Данный интервал не инициализирован");
            }

            if ( a > b)
            {
                throw new InvalidOperationException ("Корректность интервала была нарушена");
            }
            if (r.a > r.b)
            {
                throw new ArgumentException ("Некорректный интервал r");
            }
            


            if (a > r.b || r.a > b)
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
