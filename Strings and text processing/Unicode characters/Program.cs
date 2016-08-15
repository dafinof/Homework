using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicode_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                char uni = Convert.ToChar(text[i]);
                int num = Convert.ToInt32(uni);
                Console.Write(@"\u{0:x4}", num);
            }
        }
    }
}
