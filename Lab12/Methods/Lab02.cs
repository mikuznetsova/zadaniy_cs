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
            r = 5 * Math.Cos(gradToRad(aInGrad));
            return r;
        }


        public static double task2790(double aInGrad)
        {
            double r;
            r = Math.Sqrt(1 - Math.Pow((Math.Sin(gradToRad(aInGrad))), 2));
            return r;
        }

        public static double task9020(double x)
        {

            if ((61 - x) < 0)
            {
                Exception ex = new Exception("Подкоренное выражение должно быть неотрицательным");
                throw ex;

            }
            double result = 3 * Math.Sqrt(61 - x);
            return result;

        }

        public static double task7237(double temperatureInC)
        {

            if (temperatureInC < -273.15)
            {
                Exception ex = new Exception("Температура должна быть выше абсолютного нуля");
                throw ex;

            }
            double temperatureInF = 1.8 * temperatureInC + 32;
            return temperatureInF;

        }


        public static double task3943(double x, double y)
        {


            if (y < 0)
            {
                Exception ex = new Exception("Значение y должно быть неотрицательным");
                throw ex;

            }
            if (x + Math.Sqrt(y) < 0)
            {
                Exception ex = new Exception("Подкоренное выражение должно быть неотрицательным");
                throw ex;

            }
            double R = -5 * Math.Sqrt(x + Math.Sqrt(y));
            return R;

        }


        public double task8873(double r1, double r2)
        {
            if (r1 == 0)
            {
                Exception ex = new Exception("Значение r1 должно быть не равно нулю");
                throw ex;

            }
            if (r2 == 0)
            {
                Exception ex = new Exception("Значение r2 должно быть не равно нулю");
                throw ex;

            }
            double R = 1 / r1 + 1 / r2;
            return R;
        }


        public static double task2624(double a, double b, double c, double x)
        {
           
            if ((a * x * x + b * x + c)<0)
            {
                Exception ex = new Exception("Подкоренное выражение должно быть неотрицательным");
                throw ex;
            }
            if (Math.Sqrt(a * x * x + b * x + c) == 0)
            {
                throw new Exception("Знаменатель не может быть равен нулю");
                 
            }
            double R = 1 /Math.Sqrt(a*x*x + b*x + c);
            return R;
        }

        
    }
}
