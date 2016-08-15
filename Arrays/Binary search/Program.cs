using System;
namespace Binary_search
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int x = int.Parse(Console.ReadLine());
            int m = 0;
            int l = 0;
            int r = n - 1;
                while (true)
                {
                    if (l > r)
                    {
                        Console.WriteLine("-1");
                        return;
                    }
                        m = (l + r) / 2;
                    if (numbers[m] < x)
                    {
                        l = m + 1;
                    }
                    else if (numbers[m] > x)
                    {
                        r = m - 1;
                    }
                    else
                    {
                        break;
                    }
                }
            Console.WriteLine(m);
        }
    }
}
