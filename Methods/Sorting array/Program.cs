﻿using System;
using System.Linq;

namespace Sorting_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static int MaximalElement(int startIndex, params int[] arr)
        {
            int maximalElement = int.MinValue;
            for (int i = startIndex; i < arr.Length; i++)
            {
                if (maximalElement < arr[i])
                {
                    maximalElement = arr[i];
                }
            }

            return maximalElement;
        }

        static void Sort(params int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int temp = arr[i];
                int indexOfMaximalElement = Array.LastIndexOf(arr, MaximalElement(i, arr));
                arr[i] = MaximalElement(i, arr);
                arr[indexOfMaximalElement] = temp;
            }

            Array.Reverse(arr);
        }
    }
}