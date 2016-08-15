using System;

namespace Say_hello
{
    class Program
    {
        static void Name()
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hello, "+name+"!");
        }
        static void Main()
        {
            Name();
        }
    }
}
