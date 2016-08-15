using System;

namespace exercize
{
    class Program
    {
        static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }
        static void Main()
        {
            int sum=Sum(1, 2, 3, 4, 5, 6, 7);
            Console.WriteLine(sum);
        }
    }
}
