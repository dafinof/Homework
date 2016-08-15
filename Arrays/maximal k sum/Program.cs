using System;

namespace maximal_k_sum
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numbers);
            Array.Reverse(numbers);
            for (int i = 0; i < k; i++)
            {
                suma += numbers[i];
            }
            Console.WriteLine(suma);
        }
    }
}
