using System;

namespace Appearance_count
{
    class Program
    {
        static int HowManyTimesAppearInTheArray(int[] numbers,int x)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                if (number==x)
                {
                    sum += 1;
                }
            }
            return sum;
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] fromUser=Console.ReadLine().Split(' ');
            int[] numbers = new int[n];
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(fromUser[i]);
            }
            Console.WriteLine(HowManyTimesAppearInTheArray(numbers,x));
        }
    }
}
