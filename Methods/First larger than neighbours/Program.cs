using System;

namespace First_larger_than_neighbours
{
    class Program
    {
        static int IndexOfTheFirstElementBiggerThanNeighbours(int[] array)
        {
            int index = 0;
            for (int i = 1; i < array.Length-1; i++)
            {
                if (array[i]>array[i-1]&&array[i]>array[i+1])
                {
                    index = i;
                    return index;
                }
            }
            Console.WriteLine("-1");
            return index;
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(array[i]);
            }
            Console.WriteLine(IndexOfTheFirstElementBiggerThanNeighbours(numbers));
        }
    }
}
