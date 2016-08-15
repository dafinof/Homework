using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_3_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a >= b && a >= c)
            {
                Console.Write(a);
                if (b > c)
                {
                    Console.Write(" " + b);
                    Console.WriteLine(" " + c);
                }
                else
                {
                    Console.Write(" " + c);
                    Console.WriteLine(" " + b);
                }
            }
            else if (b >= a && b >= c)
            {
                Console.Write(b);
                if (a > c)
                {
                    Console.Write(" " + a);
                    Console.WriteLine(" " + c);
                }
                else
                {
                    Console.Write(" " + c);
                    Console.WriteLine(" " + a);
                }
            }
            else if (c >= a && c >= b)
            {
                Console.Write(c);
                if (b > a)
                {
                    Console.Write(" " + b);
                    Console.WriteLine(" " + a);
                }
                else
                {
                    Console.Write(" " + a);
                    Console.WriteLine(" " + b);

                }
            }
            else if (a == b || a == c)
            {
                if (a > b)
                {
                    Console.Write(a);
                    Console.Write(" " + c);
                    Console.WriteLine(" " + b);
                }
                else if (a < b)
                {
                    Console.Write(b);
                    Console.Write(" " + a);
                    Console.WriteLine(" " + c);
                }
            }
            else if (b == a || b == c)
            {
                if (b > c)
                {
                    Console.Write(b);
                    Console.Write(" " + a);
                    Console.WriteLine(" " + c);
                }
                else if (b < c)
                {
                    Console.Write(c);
                    Console.Write(" " + a);
                    Console.WriteLine(" " + b);
                }
            }
            else if (a == b && a == c)
            {
                Console.WriteLine("{0} {1} {2}", a, b, c);
            }

        }
    }
}
