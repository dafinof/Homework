﻿using System;


namespace multiplication_sign
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("+");
            }
            else if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("0");
            }
            else if (a == 0 & b == 0 & c == 0)
            {
                Console.WriteLine("0");
            }
            else if (a == 0 && (b == 0 || c == 0))
            {
                Console.WriteLine("0");
            }
            else if (b == 0 && (a == 0 || c == 0))
            {
                Console.WriteLine("0");
            }
            else if(a<0 &&(b<0 ^ c < 0))
            {
                Console.WriteLine("+");
            }
            else if (b < 0 && (a < 0 ^ c < 0))
            {
                Console.WriteLine("+");
            }
            
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}
