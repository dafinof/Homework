using System;
using System.Linq;

namespace compare_char_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            char[] afirst = first.ToCharArray();
            char[] asecond = second.ToCharArray();
            if (afirst.Length > asecond.Length)
            {
                Console.WriteLine(">");
            }
            else if (afirst.Length < asecond.Length)
            {
                Console.WriteLine("<");
            }
            else
            {
                if (afirst[afirst.Length-1] > asecond[asecond.Length-1])
                { Console.WriteLine(">");  }
                else if (afirst[afirst.Length-1] < asecond[asecond.Length-1])
                { Console.WriteLine("<");  }
                else
                { Console.WriteLine("=");  }
            }

        }
    }
}
