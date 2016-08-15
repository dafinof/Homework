using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interval
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int a = 0;
            int i = 0;
            int b = 0;
            int c = 0;

            for (i = n+1; i < m; i++)
            {
                a = 0;
                a = a + i;
                if (a % 5 == 0)
                {
                    b = b + 1;

                }


            }
            Console.WriteLine(b);
        }
    }
}
