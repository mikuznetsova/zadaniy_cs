using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
   public class Lab05
    {
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

    }
}
