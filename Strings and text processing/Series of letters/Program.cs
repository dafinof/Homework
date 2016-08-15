using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series_of_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<char> newString = new List<char>();
            newString.Add(text[0]);
            for (int i = 0; i < text.Length-1; i++)
            {
                if (text[i]!=text[i+1])
                {
                    newString.Add(text[i+1]);
                }
            }
            for (int i = 0; i < newString.Count; i++)
            {
                Console.Write(newString[i]);
            }
        }
    }
}
