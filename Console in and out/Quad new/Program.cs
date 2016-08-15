using System;

namespace Quad_new
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double d = Math.Sqrt((b * b) - (4 * a * c));

            double k1 = ((-b) + Math.Sqrt(b * b - (4 * a * c))) / (2 * a);
            double k2 = ((-b) - Math.Sqrt(b * b - (4 * a * c))) / (2 * a);

            if (d > 0)
            {
                if (k1 < k2)
                {
                    Console.WriteLine("{0:F2}", k1);
                    Console.WriteLine("{0:F2}", k2);
                }
                else
                {
                    Console.WriteLine("{0:F2}", k2);
                    Console.WriteLine("{0:F2}", k1);
                }
            }
            else if (d == 0)
            {
                if (k1 > k2)
                {
                    Console.WriteLine("{0:F2}", k1);
                }
                else
                {
                    Console.WriteLine("{0:F2}", k2);
                }

            }
            else
            {
                Console.WriteLine("no real roots");
            }
        }
    }
}
