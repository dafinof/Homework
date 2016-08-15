using System;

namespace Larger_than_neighbors
{
    class Program
    {
        static int HowManyAreBiggerThanTheirNeighbours(int[] array)
        {
            int sum = 0;
            for (int i = 1; i < array.Length-1; i++)
            {
                    if (array[i] > array[i - 1] &&array[i]>array[i + 1])
                    {
                        sum ++;
                    }
            }
            return sum;
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] array = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(array[i]);
            }
            Console.WriteLine(HowManyAreBiggerThanTheirNeighbours(numbers)); 
            
        }
    }
}
