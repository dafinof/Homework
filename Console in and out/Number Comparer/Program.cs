using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Comparer
{
    class Program
    {
        static void Main()
        {
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());

            double c = Math.Max(A,B);

            Console.WriteLine(c);
        }
    }
}
