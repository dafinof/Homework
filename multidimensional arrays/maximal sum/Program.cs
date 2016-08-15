using System;

namespace maximal_sum
{
    class Program
    {
        static void Main()
        {
            string[] a = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(a[0]);
            int m = int.Parse(a[1]);
            int smax = int.MinValue;
            int[,] numbers = new int[n, m];
            for (int row = 0; row < n; row++)
            {
                string[] currentRow = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < m; col++)
                {
                    numbers[row, col] = int.Parse(currentRow[col]);
                }
            }
            for (int row = 0; row < n-2; row++)
            {
                for (int col = 0; col < m-2; col++)
                {
                    int sum = numbers[row, col] + numbers[row, col + 1] + numbers[row, col + 2] +
                        numbers[row + 1, col] + numbers[row + 1, col + 1] + numbers[row + 1, col + 2] +
                        numbers[row + 2, col] + numbers[row + 2, col + 1] + numbers[row + 2, col + 2];
                    if (sum>smax)
                    {
                        smax = sum;
                    }
                }
            }
            Console.WriteLine(smax);
        }
    }
}
