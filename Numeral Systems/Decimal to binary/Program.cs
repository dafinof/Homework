using System;
using System.Collections.Generic;

namespace Decimal_to_binary
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> bin = new List<int>();
            int ostatuk = 1;
            int bit = 1;
            while (ostatuk >= 1)
            {
                ostatuk = n / 2;
                bit = n % 2;
                bin.Add(bit);
                n = n / 2;
            }
            int[] newbin=bin.ToArray();
            Array.Reverse(newbin);
            for (int i = 0; i < newbin.Length; i++)
            {
                Console.Write(newbin[i]);
            }
        }
    }
}
