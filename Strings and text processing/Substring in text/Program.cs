using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring_in_text
{
    class Program
    {
        static void Main(string[] args)
        {
            string patterns = Console.ReadLine();
            string texts = Console.ReadLine();
            string pattern = patterns.ToLower();
            string text = texts.ToLower();
            int sum = 0;
            int index = 0;
            while (true)
            {
                int found = text.IndexOf(pattern,index);
                if (found>0)
                {
                    sum++;
                }
                else
                {
                    break;
                }
                index = found + 1;
            }
            Console.WriteLine(sum);
        }
    }
}