using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.task2662
{
    public class Interval
    {
        public int a;
        public int b;
        public Interval(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
    
        
        public override bool Equals(Object o)
        {
            if (this == o) return true;
            if (o == null  || GetType() != o.GetType()) return false;
            Interval i = (Interval)o;
            if (a != i.a)     return false;
             else             return b == i.b;
        }
    }
}
