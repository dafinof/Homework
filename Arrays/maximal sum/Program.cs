using System;

namespace maximal_sum
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int start = 0;
            int end = 0;
            int poziciq = 0;
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int maxsum = numbers[0];
            int segasum = numbers[0];
            for (int i = 1; i < n; i++)
            {
                if (segasum>0)
                {
                    segasum += numbers[i];
                }
                else
                {
                    segasum = numbers[i];
                    poziciq = i;
                }
                if (segasum>maxsum)
                {
                    maxsum = segasum;
                    start = poziciq;
                    end = i;
                }
            }
            int obshto = 0;
            for (int i = poziciq; i <=end;  i++)
            {
                 obshto += numbers[i];
            }
            Console.WriteLine(obshto);
        }
    }
}
