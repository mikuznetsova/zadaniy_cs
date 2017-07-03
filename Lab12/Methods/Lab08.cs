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
    }
}
