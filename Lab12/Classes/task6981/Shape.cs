using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.task6981
{
    public abstract class Shape
    {
        protected string id;
        protected int n =0;


        public abstract void shiftX (string s);
        public abstract void shiftY(string s);
        public abstract void stretchX(string s);
        public abstract void stretchY(string s);

        public override string ToString()
        {
            return id +" Действий:" +n+ " ";
        }
    }

}
