using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int[] sum = new int[n];
        int suma = 1;
        int maxsum = 0;
        
        int koee = 0;
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
            
        }
        for (int i = 0; i < n-1; i++)
        {
            for (int j =i+ 1; j < n; j++)
            {
                if (numbers[i]==numbers[j])
                {
                    suma += 1;
                }
            }
            sum[i] = suma;
            suma = 1;   
        }
        for (int i = 0; i < n-1; i++)
        {
            if (sum[i] > sum[i+1])
            {
                sum[i+1] = sum[i ];
                numbers[i + 1] = numbers[i];
                maxsum = sum[i] ;
                koee = numbers[i] ;
            }
        }
        Console.Write(koee);
        Console.WriteLine(" ({0} times)", maxsum);
    }
}

