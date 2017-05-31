using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, h1, h2, w1, w2;
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            h1 = double.Parse(Console.ReadLine());
            w1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            h2 = double.Parse(Console.ReadLine());
            w2 = double.Parse(Console.ReadLine());
            bool rx1, rx2, ry1, ry2, rh1, rh2, rw1, rw2;
            if (h1 <= 0 || h2 <= 0)
            {
                Console.Write("Высота должна быть положительна");
                return;
            }
            if (x2 >= x1 && x2 <= (x1 + w1))

            { rx2 = true;
                if ((x2 + w2) <= (x1 + w1))//ОКОНЧАНИЕ НА ОТРЕЗКЕ
                {
                    rw2 = true;
                    if (y2 >= y1 && y2 <= (y1 + h1))// на отрезке
                    {
                        ry2 = true;
                        if ((y2 + h2) <= (y1 + h1)) ;//на отрезке
                        {
                            rh2 = true;
                        }
                        if ((y2 + h2) > (y1 + h1)) ;//после
                        {
                            rh1 = true;
                        }

                    }
                    if (y2 < y1)// до
                    {
                        ry1 = true;
                        if ((y2 + h2) <= (y1 + h1) && (y2 + h2) >= y1) ;// на отрезке
                        {
                            rh2 = true;
                        }
                        if ((y2 + h2) > (y1 + h1)) ;// после
                        {
                            rh1 = true;
                        }
                        if ((y2 + h2) < y1)//до
                        {
                            Console.WriteLine("Не пересекаются");
                        }
                    }
                    if (y2 > (y1 + h1))//после
                    {
                        Console.WriteLine("Не пересекаются");
                    }
                }
                if ((x2 + w2) > (x1 + w1)) //ОКОНЧАНИЕ ПОСЛЕ
                {
                    rw1 = true;
                    if (y2 >= y1 && y2 <= (y1 + h1))// на отрезке
                    {
                        ry2 = true;
                        if ((y2 + h2) <= (y1 + h1)) ;//на отрезке
                        {
                            rh2 = true;
                        }
                        if ((y2 + h2) > (y1 + h1)) ;//после
                        {
                            rh1 = true;
                        }

                    }
                    if (y2 < y1)// до
                    {
                        ry1 = true;
                        if ((y2 + h2) <= (y1 + h1) && (y2 + h2) >= y1) ;// на отрезке
                        {
                            rh2 = true;
                        }
                        if ((y2 + h2) > (y1 + h1)) ;// после
                        {
                            rh1 = true;
                        }
                        if ((y2 + h2) < y1)//до
                        {
                            Console.WriteLine("Не пересекаются");
                        }
                    }
                    if (y2 > (y1 + h1))//после
                    {
                        Console.WriteLine("Не пересекаются");
                    }
                }
            }
            if (x2 < x1)

            {
                if ((x2 + w2) < x1)
                {
                    Console.WriteLine("Не пересекаются");

                }
                if ((x2 + w2) >= (x1 + w1)) //после
                {
                    rx1 = true;
                    rw1 = true;
                    if (y2 >= y1 && y2 <= (y1 + h1))// на отрезке
                    {
                        ry2 = true;
                        if ((y2 + h2) <= (y1 + h1)) ;//на отрезке
                        {
                            rh2 = true;
                        }
                        if ((y2 + h2) > (y1 + h1)) ;//после
                        {
                            rh1 = true;
                        }

                    }
                    if (y2 < y1)// до
                    {
                        ry1 = true;
                        if ((y2 + h2) <= (y1 + h1) && (y2 + h2) >= y1) ;// на отрезке
                        {
                            rh2 = true;
                        }
                        if ((y2 + h2) > (y1 + h1)) ;// после
                        {
                            rh1 = true;
                        }
                        if ((y2 + h2) < y1)//до
                        {
                            Console.WriteLine("Не пересекаются");
                        }
                    }
                    if (y2 > (y1 + h1))//после
                    {
                        Console.WriteLine("Не пересекаются");
                    }
                }
            }

            if (x2 > (x1 + w1))
            {
                Console.WriteLine("Не пересекаются");
            }
            Console.WriteLine();
        }
    }
}



