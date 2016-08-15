using System;
namespace Circle
{
    class Program
    {
        static void Main()
        {
            double r = Convert.ToDouble(Console.ReadLine());

            double a = Math.PI * r * r;
            double p = 2 * Math.PI * r;
            Console.WriteLine("{0:F2} {1:F2}" ,p,a);
        }
    }
}
