using System;

namespace sequence_in_matrix
{
    class Program
    {
        static void Main()
        {
            string[] a = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(a[0]);
            int m = int.Parse(a[1]);
            int[,] numbers = new int[n, m];
            int[,] sum = new int[n, m];
            int suma = 1;
            for (int row = 0; row < n; row++)
            {
                string[] currentRow = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < m; col++)
                {
                    numbers[row, col] = int.Parse(currentRow[col]);
                }
            }
            //int n = 6, m = 6;
            //int[,] numbers =
            //    {
            //        { 92, 11, 23 ,42, 59, 48 },
            //        { 09 ,92 ,23 ,72, 56, 14 },
            //        { 17 ,63 ,92 ,46, 85, 95 },
            //        { 34, 12, 52, 69, 23, 95 },
            //        { 26 ,88 ,78 ,71, 29, 95 },
            //        { 26 ,34 ,16, 63, 39, 95 }
            //    };
            //int[,] sum = new int[n, m];
            //int suma = 1;
            for (int i = 0, row = 0; i < n ; row++, i++)
            {
                for (int j = 0, col = 0; j < m; j++, col++)
                {
                    if (row==n-1)
                    {
                        if (col==m-1)
                        {

                        }
                        else 
                        {
                            if (numbers[row, col] == numbers[row, col+1])
                            {
                                suma += 1;
                            }
                            else if (numbers[row, col] == numbers[row-1, col + 1])
                            {
                                suma += 1;
                                row -= 1;
                            }
                            else if (numbers[row, col] == numbers[row-1, col ])
                            {
                                suma += 1;
                                row -= 1;
                                col -= 1;
                            }
                            else
                            {
                                sum[i, j] = suma;
                                suma = 1;
                                row = i;
                                col = j;
                            }
                        }

                    }
                    else if (col==m-1)
                    {
                        if (row==n-1)
                        {

                        }
                        else if (row==0)
                        {
                            if (numbers[row, col] == numbers[row + 1, col])
                            {
                                suma += 1;
                                row += 1;
                            }
                            else
                            {
                                sum[i, j] = suma;
                                suma = 1;
                                row = i;
                                col = j;
                            }
                        }                       
                    }
                    else
                    {
                        if (numbers[row, col] == numbers[row + 1, col])
                        {
                            suma += 1;
                            row += 1;
                        }
                        else if (numbers[row, col] == numbers[row, col + 1])
                        {
                            suma += 1;
                        }
                        else if (numbers[row, col] == numbers[row + 1, col + 1])
                        {
                            suma += 1;
                            row += 1;
                        }
                        else
                        {
                            sum[i, j] = suma;
                            suma = 1;
                            row = i;
                            col = j;
                        }
                    }
                }
            }
            int max = int.MinValue;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    if (sum[row, col] > max)
                    {
                        max = sum[row, col];
                    }
                }
            }
            Console.WriteLine(max);
        }
    }
}
