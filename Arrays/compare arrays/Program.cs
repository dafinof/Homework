using System;

namespace compare_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] first = new int[n];
            int[] second = new int[n];
            for (int i = 0; i <n; i++)
            {
                first[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < n; j++)
            {
                second[j] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if(first[i] != second[i])
                {
                    Console.WriteLine("Not equal");
                    return;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("Equal");
        }
    }
}
