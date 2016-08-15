using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_n_numbers
{
    class Program
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double sum=0;
            int i;

            for (i = 1; i <= n; i++)
            {
                double a = double.Parse(Console.ReadLine());
                sum = sum + a; 


            }
            Console.WriteLine(sum);

        }
    }
}
