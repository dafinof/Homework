using System;

namespace test2
{
    class Program
    {
        static void Main()
        {
            var a = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(a[0]);
            int m = int.Parse(a[1]);
            string[,] matrix = new string[n,m];
            for (int row = 0; row < n; row++)
            {
                string[] b = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = b[col];
                }
            }
            int sum = 1;
            int maxSum = int.MinValue;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    if (row<n-1&&col<m-1)
                    {
                        if (matrix[row,col]==matrix[row,col+1])
                        {
                            sum++;
                        }
                        else if (matrix[row, col] == matrix[row + 1, col + 1])
                        {
                            sum++;
                            if (row < n - 2)
                            {
                                row++;
                            }
                        }
                        else if (matrix[row, col] == matrix[row + 1, col])
                        {
                            sum++;
                            if (row < n - 2)
                            {
                                row++;
                                col--;
                            }
                        }
                        else
                        {
                            if (sum > maxSum)
                            {
                                maxSum = sum;
                            }
                            sum = 1;
                        }
                    }
                    else if (row==n-1)
                    {
                        if (col<m-1)
                        {
                            if (matrix[row, col] == matrix[row, col + 1])
                            {
                                sum++;
                            }
                            else
                            {
                                if (sum > maxSum)
                                {
                                    maxSum = sum;
                                }
                                sum = 1;
                            }
                        }
                    }
                    else if (col==m-1)
                    {
                        if (row<n-1)
                        {
                            if (matrix[row, col] == matrix[row+1, col])
                            {
                                sum++;
                                row++;
                                col--;
                            }
                            else
                            {
                                if (sum > maxSum)
                                {
                                    maxSum = sum;
                                }
                                sum = 1;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}
