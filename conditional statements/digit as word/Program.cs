using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digit_as_word
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = "0";
            string c = "1";
            string d = "2";
            string e = "3";
            string f = "4";
            string g = "5";
            string h = "6";
            string i = "7";
            string j = "8";
            string k = "9";
            if (String.Equals(a, b))
            {
                Console.WriteLine("zero");
            }
            else if (String.Equals(a, c))
            {
                Console.WriteLine("one");
            }
            else if (String.Equals(a, d))
            {
                Console.WriteLine("two");
            }
            else if (String.Equals(a, e))
            {
                Console.WriteLine("three");
            }
            else if (String.Equals(a, f))
            {
                Console.WriteLine("four");
            }
            else if (String.Equals(a, g))
            {
                Console.WriteLine("five");
            }
            else if (String.Equals(a, h))
            {
                Console.WriteLine("six");
            }
            else if (String.Equals(a, i))
            {
                Console.WriteLine("seven");
            }
            else if (String.Equals(a, j))
            {
                Console.WriteLine("eight");
            }
            else if (String.Equals(a, k))
            {
                Console.WriteLine("nine");
            }
            else
            {
                Console.WriteLine("not a digit");
            }




        }
    }
}
