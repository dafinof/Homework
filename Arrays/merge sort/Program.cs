﻿using System;
namespace merge_sort
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int [] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

        }
    }
}
