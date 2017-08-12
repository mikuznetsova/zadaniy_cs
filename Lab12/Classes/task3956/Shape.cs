using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.task3956
{
    public abstract class Shape
    {
        protected string stroke;
        protected int strokeWidth;
        protected string fill;

       
        public abstract Point getCenter();
        public abstract void slide(int a, int b);
       public abstract double area();
    }

}
