using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_lenght
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            text = text.Replace("\\", String.Empty);
            if (text.Length==20)
            {
                Console.WriteLine(text);
            }
            else
            {
                Console.Write(text);
                for (int i = text.Length; i <20; i++)
                {
                    Console.Write("*");
                }
            }
        }
    }
}
