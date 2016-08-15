using System;

namespace maximal_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int suma = 1;
            int[] sum = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    suma += 1;//ako sa ravni sumata raste s edno
                }
                else
                {
                    sum[i] = suma;//ako ne sumata ot masiv stava ravna na sumata 
                    suma = 1;     //a sumata stava ravna na 1
                }
            }
            for (int i = 0; i < n - 1; i++)
            {
                if (suma > sum[i])
                {
                    sum[i] = suma;
                }
                
                if (sum[i] < sum[i + 1])
                {
                    suma = sum[i+1];
                }
                
                
            }
            Console.WriteLine(suma);
        }
    }
}
