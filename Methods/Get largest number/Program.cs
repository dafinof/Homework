using System;

namespace Get_largest_number
{
    class Program
    {
        static int GetMax(int a,int b)
        {
            if (a>b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            int first = int.Parse(numbers[0]);
            int second = int.Parse(numbers[1]);
            int third = int.Parse(numbers[2]);
            int one = GetMax(first, second);
            int two = GetMax(second, third);
            int result = GetMax(one, two);
            Console.WriteLine(result);
        }
    }
}
