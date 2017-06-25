using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            string t, t1, t2, s,s1;
            s = Console.ReadLine();

            t = "\"";
            t1 = "[";
            t2 = "]";
            int i = s.IndexOf(t);
            int j = s.IndexOf(t1);
            int j2 = s.IndexOf(t2);
            i = 1;
            j = 0;
            j2 = 0;

            {
                while ((j = s.IndexOf(t1, j)) != -1)
                {
                    s = s.Insert(j, "\\");
                    j++;
                    j += t1.Length;

                }
                while ((j2 = s.IndexOf(t2, j2)) != -1)
                {
                    {
                        s = s.Insert(j2, "\\");
                        j2++;
                        j2 += t2.Length;

                    }
                }

              
                while ((i = s.IndexOf(t, i)) != -1)
                {

                    
                if (i % 2 ==0)
                    {
                        s = s.Replace(t, t1);

                    }
                else

                    {
                       
                        s = s.Replace(t, t2);
                      
                    }
                    
                    i++;
                    i += t.Length;
                    
                }

                
                

            }
        }
    }
}


