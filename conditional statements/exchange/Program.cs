using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exchange
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = 0;

            

            if (a > b)
            {
                c = b;
                b = a;
                a = c;
            }
            Console.WriteLine("{0} {1}", a, b);

        }
    }
}
