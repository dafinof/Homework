using System;
namespace test
{
    class Program
    {
        static void Main()
        {
            int s = 11;
            int[] numbers = {  11, 1,-3, 4,11, 2, 4, 8,2,1 ,8,9,2,0,11};
            int sum = 0;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                sum = numbers[i];
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (sum+numbers[j]==s)
                    {
                        for (int k = i; k <= j; k++)
                        {
                            Console.Write(numbers[k]+" ");
                        }
                        return;
                    }
                    sum += numbers[j];
                }
            }
        }
    }
}
