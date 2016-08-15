using System;

namespace Reverse_number
{
    class Program
    {
        static string ReverseDigits(decimal digit)
        {
            string rev = "";
             rev = Convert.ToString(digit);
            char[] array = rev.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
        static void Main()
        {
            decimal n= decimal.Parse(Console.ReadLine());
            Console.WriteLine(ReverseDigits(n));
        }
    }
}
