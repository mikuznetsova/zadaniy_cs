using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
   public class Lab05
    {
        public static double task3770 (double x, double y, double z)
        {
          
            double r = Math.Max(Math.Max(x, y), z); 
            return r;
        }


        public static bool task4847(int x, int y, int z)
        {
            //if (x == y || x == z || y == z)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            return x == y || x == z || y == z;
        }

        public static bool task4042(double x, double y)
        {
            
            return y >= -2 && y <= 1.5;
        }

        public static bool task6351(double x, double y)
        {

            return x >= 1 && x <= 2 && y <= 4;
        }

        public static bool task5382(double x, double y)
        {

            return x >= 1 && y >= 2 && y <= 4;
        }

        public static bool task7250(double x, double y)
        {

            return x >= 2 && (y >= 1 || y <= -1.5) ;
        }
        public static bool task9038(double x, double y)
        {

            return (y >= 0.5 && y <= 1.5 && x < 2) || x >= 2;
        }
       

        public static StringBuilder task8518(StringBuilder sb, String x)
        {
           
            string[] arr = "a b c d e f g h".Split(' ');
            int i = 0;
            while (i < 8)
            {
                if (x == arr[i])
                {
                    sb.Append(arr[i]);
                    sb.Append("+\n");
                }
                else
                {
                    sb.Append(arr[i]);
                    sb.Append("\n");

                }
                i++;
            }
            return sb;
        }


        public static bool task4257(double distanceInKm, double distanceInFeet)
        {
            double distanceInM = distanceInKm *1000;
            double distanceInFeetM = distanceInFeet * 0.305;
           
            if(distanceInKm<0)
            {
                Exception ex = new Exception("Значение distanceInKm должно быть неотрицательным");
                throw ex;
            }
            if (distanceInFeet < 0)
            {
                Exception ex = new Exception("Значение distanceInFeet должно быть неотрицательным");
                throw ex;
            }
            return distanceInM<= distanceInFeetM;
        }

        public static String task2291(double velocityInKmH, double velocityInMS)
        {
            double velocityInKmHSEK = velocityInKmH*1000 /3600;


            if (velocityInKmH < 0)
            {
                Exception ex = new Exception("Значение velocityInKmH  должно быть неотрицательным");
                throw ex;
            }
            if (velocityInMS < 0)
            {
                Exception ex = new Exception("Значение velocityInMS  должно быть неотрицательным");
                throw ex;
            }
            if (velocityInKmHSEK <= velocityInMS)
            {
               
                return String.Format("{0:F2} км/ч меньше {1:F2} м/с", velocityInKmH, velocityInMS);
            }
            else
            {

                return String.Format("{1:F2} м/с  меньше {0:F2} км/ч", velocityInKmH, velocityInMS);
            }

        }


        public static String task1763(double radius, double edge)
        {
            double Sr = radius* radius*Math.PI;
            double Se = edge * edge;

            if (radius < 0)
            {
                Exception ex = new Exception("Радиус должен быть положительным");
                throw ex;
            }
            if (edge < 0)
            {
                Exception ex = new Exception("Сторона квадрата должна быть положительна");
                throw ex;
            }
            if (Sr <= Se)
            {

                return String.Format("Площадь квадрата {1:F4} больше площади круга {0:F4}", Sr, Se);
            }
            else
            {

                return String.Format("Площадь круга  {0:F4} больше площади квадрата {1:F4}", Sr, Se);
            }

        }


        public static bool task1945(double Sr, double Se)
        {
            double d  =2* Math.Sqrt(Sr /Math.PI);
            double edge = Math.Sqrt(Se);

            if (Sr < 0)
            {
                Exception ex = new Exception("Площадь круга должна быть положительной");
                throw ex;
            }
            if (Se < 0)
            {
                Exception ex = new Exception("Площадь  квадрата должна быть положительна");
                throw ex;
            }
            return d <= edge;
        }
        public static IList<double> Task4497(double x, double y, double z)
        {
            IList<double> list = new List<double>();

            if (x < 5 && x > -3)
            {
               list.Add(x);
            }
            if (y < 5 && y > -3)
            {
                list.Add(y);
            }
            if (z < 5 && z > -3)
            {
                list.Add(y);
            }
            return list;
        }
    }
}
