using System;

namespace quadratic_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            string g = "no real roots";

            double k1 = Convert.ToDouble (-b + Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
            double k2 = Convert.ToDouble (-b - Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);





            if (k1 == double.NaN && k2 == double.NaN)
            {

                Console.WriteLine(g); 


            }
            else
            {
                if (k1 < k2)
                {
                    Console.WriteLine("{0:0.00}", k1);
                    Console.WriteLine("{0:0.00}", k2);
                }
                if (k2 <= k1)
                {
                    Console.WriteLine("{0:0.00}", k2);
                    Console.WriteLine("{0:0.00}", k1);
                }
                if (k1 !=k2)
                {

                    if (k1 < k2)
                    {

                        Console.WriteLine("{0:0.00}", k2);
                    }
                    
                    }
                    if (k1 == k2)
                    {
                        Console.WriteLine(g);
                    }


                }


            }

        }


    }


