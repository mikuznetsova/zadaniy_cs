using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Lab02
    {
        public static double task4411(double x)
        {
            double r;
            r = x + 7;
            return r;
        }

        public static double gradToRad(double a)
        {
            return a * Math.PI / 180;
        }

        public static double task8428(double aInGrad)
        {
            double aInRrad;
            aInRrad = gradToRad(aInGrad);
            return aInRrad;
        }

        public static double task1262(double aInGrad)
        {
            double r;
            r = 5* Math.Cos(gradToRad(aInGrad));
            return r;
        }


        public static double task2790(double aInGrad)
        {
            double r;
            r = Math.Sqrt(1- Math.Pow((Math.Sin(gradToRad(aInGrad))),2));
            return r;
        }

        
    }
}
