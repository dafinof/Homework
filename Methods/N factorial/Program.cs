using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace N_factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(FindingFactorial(n));
        }

        static BigInteger FindingFactorial(int a)
        {
            BigInteger b = 1;
            int[] array = new int[a];
            for (int i = 0; i < a; i++)
            {
                array[i] = i+1;
                b *= array[i];
            }
            return b;
        }
    }
}
