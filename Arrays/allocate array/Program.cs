using System;
namespace allocate_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i <n ; i++)
            {
                array[i] = i;
                Console.WriteLine(array[i]*5);
            }
        }
    }
}
