using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 4];
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    array[row, col] = row+col;
                }
            }
            string[] a = new string [4];
            for (int col = 0; col < array.GetLength(0); col++)
            {
                for (int row = 1; row < array.GetLength(1); row+=2)
                {
                    a[col] += array[col, row];
                }
                a.Reverse();
                Console.WriteLine(string.Join(" ",a));
            }
        }
    }
}
