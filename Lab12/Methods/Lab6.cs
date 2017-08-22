using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Lab06
    {
        public static int task3669(int a, int b)
        {
            int r = 1;
            int i = 0;
            if (b > a)
            {
                while (a < b)
                {
                    r = r * (a + i);

                    i++;
                }
            }
            else
            {
                while (b < a)
                {
                    r = r * (b + i);
                    i++;
                }
            }
            
            return r;
        }


        public static int task5969(int a, int b)
        {
           int  i = 0;
            int y = 0;
            if (a <= b)
            {
                while ((a + i) <= b)

                {
                    if ((a + i) % 7 == 0)
                    {
                        y = y + (a + i);
                    }
                    i++;
                }
            }
            else
            {
                while ((b + i) <= a)
                {
                    if ((b + i) % 7 == 0)
                    {
                        y = y + (b + i);
                    }
                    i++;
                }

            }

            return r;

        }


            public static StringBuilder task8495(StringBuilder sb8495)
        {


            int i = 0;
            while (i < 13)
            {

                sb8495.Append("!");
                i++;
            }
            return sb8495;
        }

        public static StringBuilder task2565(StringBuilder sb, int a, int b)
        {

            if (a <=b)
            {
                int i= 0;
                while (b>=a)
                {
                    b = b - i;
                        sb.Append(b);
                        sb.Append(" ");
                    
                   
                    i++;
                }
              
            }
            else
            {
                Exception ex = new Exception("Значение A должно быть не больше значения B");
                throw ex;
            }
            return sb;

        }
    }
}

