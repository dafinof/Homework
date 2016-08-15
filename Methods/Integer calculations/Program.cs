using System;

namespace Integer_calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                numbers[i]= int.Parse(a[i]);
            }
            FindingMinimum(numbers);
            FindingMaximum(numbers);
            FindingAverage(numbers);
            FindingSum(numbers);
            FindingProduct(numbers);
        }
        static void FindingMinimum(int[] a)
        {
            Array.Sort(a);
            Console.WriteLine(a[0]);
        }
        static int FindingMaximum(int[] a)
        {
            Array.Sort(a);
            Array.Reverse(a);
            Console.WriteLine(a[0]);
            return a[0];
        }
        static double FindingAverage(int[] a)
        {
            double average = 0;
            for (int i = 0; i < a.Length; i++)
            {
                average += a[i];
            }
            average = average / a.Length;
            Console.WriteLine("{0:F2}",average);
            return average;
        }
        static void FindingSum(int[] a)
        {
            long sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            Console.WriteLine(sum);
        }
        static void FindingProduct(int[] a)
        {
            long product = 1;
            for (int i = 0; i < a.Length; i++)
            {
                product *= a[i];
            }
            Console.WriteLine(product);
        }
    }
}
