using System;

namespace numbers_1_to_n
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for(int i=1; i<=n;i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
