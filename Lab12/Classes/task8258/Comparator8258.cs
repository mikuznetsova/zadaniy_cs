using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.task8258
{
    public class Comparator8258: Comparer <int>
    {
        public override int Compare(int l, int r)

        {
            int a, b;
          a =Math.Abs( 6-l);
            b = Math.Abs(r -6) ;
            if ( a>b)
            {
                return 1;//т.к. положительно число в данном методе означает левое> правого
            }
            else if (a == b)
            {
                return 0;//равны
            }
            else
            {
                return -1;//правое больше
            }
            



        }
    }
}
