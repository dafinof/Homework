using System;

namespace maximal_increasing_sequence
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int suma = 1;
            int[] sum = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n - 1; i++)
            {
                if (numbers[i] < numbers[i + 1] )
                {
                    suma += 1;
                }
                else
                {
                    sum[i] = suma;
                    suma = 1;
                }
            }
            for (int i = 0; i < n - 1; i++)
            {
                if (suma>sum[i])
                {
                    sum[i] = suma;
                }
                if (sum[i] < sum[i + 1])
                {
                    suma = sum[i + 1];
                }
            }
            Console.WriteLine(suma);
        }
    }
}
