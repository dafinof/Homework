using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            cop
        }
        static void TopDownMergeSort(int[] A, int[] B,int n)
        {
            TopDownSplitMerge(A, 0, n, B);
        }
        static void TopDownSplitMerge(int[]A,int iBegin,int iEnd, int[] B)
        {
            if (iEnd - iBegin < 2)
                return;
            int iMiddle = (iEnd + iBegin) / 2;
            TopDownSplitMerge(A, iBegin, iMiddle, B);  
            TopDownSplitMerge(A, iMiddle, iEnd, B);  
            TopDownMerge(A, iBegin, iMiddle, iEnd, B);  
            CopyArray(B, iBegin, iEnd, A);
        }
        static void TopDownMerge(int[]A, int iBegin, int iMiddle, int iEnd, int[]B)
        {
            int i = iBegin, j = iMiddle;

            // While there are elements in the left or right runs...
            for (int k = iBegin; k < iEnd; k++)
            {
                // If left run head exists and is <= existing right run head.
                if (i < iMiddle && (j >= iEnd || A[i] <= A[j]))
                {
                    B[k] = A[i];
                    i = i + 1;
                }
                else
                {
                    B[k] = A[j];
                    j = j + 1;
                }
            }
        }
        static int[] CopyArrayint(int[]B, int iBegin,int  iEnd, int[]A)
        {
            for (int k = iBegin; k < iEnd; k++)
                A[k] = B[k];
            return A;
        }
    }
}
