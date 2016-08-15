using System;

namespace selection_sort
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int k = 0; k < n; k++)
            {
                numbers[k] = int.Parse(Console.ReadLine());//pulnim masiva
            }
            int vtoroto, purvoto;
            for (purvoto = 0; purvoto < n - 1; purvoto++)
            {
                int min = purvoto;//
                for (vtoroto = purvoto + 1; vtoroto < n; vtoroto++)
                {
                    if (numbers[vtoroto]<numbers[min])
                    {
                        min = vtoroto;
                    }
                }
                if (min!=purvoto)
                {
                    //swap(numbers[j], numbers[iMin]);
                    int buf = numbers[purvoto];
                    numbers[purvoto] = numbers[min];
                    numbers[min] = buf;
                }
            }
            for (int d = 0; d < n; d++)
            {
                Console.WriteLine(numbers[d]);
            }
        }

        
    }
}
