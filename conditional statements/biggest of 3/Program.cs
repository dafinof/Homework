using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biggest_of_3
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine(a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine(b);
            }
            else if (c > a && c > b) 
            {
                Console.WriteLine(c);
            }
            else if (a==b && a == c)
            {
                Console.WriteLine(a);
            }
            else if ((a==b || a==c)&& (a>b || a > c))
            {
                Console.WriteLine(a);
            }
            else if ((b == a || b == c) && (b > c || b > a))
            {
                Console.WriteLine(b);
            }
            else if ((c == a || c == b) && (c > b || c > a))
            {
                Console.WriteLine(c);
            }
        }
    }
}
