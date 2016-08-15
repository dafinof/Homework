using System;
using System.Collections.Generic;
using System.Linq;

namespace play_card
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = (Console.ReadLine());
           

            var c = new List<string> { "2","3","4","5","6","7","8","9","10","J","Q","K","A"};
            if (c.Contains(a, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine("yes " + a);
            }
            else
            {
                Console.WriteLine("no "+a);
            }
        }
    }
}
