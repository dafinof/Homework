using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_to_int_array
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "1 2 33 4 5 6 ";
            int[] numbers = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
