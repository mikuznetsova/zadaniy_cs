using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Methods
{
    public class Lab08
    {
        public static double task3946(String t)
        {
            if (t=="")
            {
                return 0;
            }
         
            int i = 0;
            double r = 0;
           
            string[] arr = t.Split(' ');
           
            
             int[] num = new int[arr.Length];
            while (i < arr.Length)
            {
                num[i] = Convert.ToInt32(arr[i]);

                r = r + num[i];
                i++;
            }
           r= r / i;
            return r;
        }

        public static bool task4515(String x)
        {
            string[] arr = x.Split(' ');
            int i = 0;
            int j = 1;
            int r = 0;
            int[] num = new int[arr.Length];
            int[] num2 = new int[arr.Length];

            while (i < arr.Length)
            {
                num[i] = Convert.ToInt32(arr[i]);
                while (j < arr.Length)
                {
                    num2[j] = Convert.ToInt32(arr[j]);
                    if (num[i] == num2[j])
                    {
                        r++;
                        break;
                    }

                    j++;
                }
            
            }
            return r > 0;
        }
    }
}
