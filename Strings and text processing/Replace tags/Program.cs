using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace_tags
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int first = text.IndexOf("<a");
            int last = text.IndexOf("</a>") + 4;
            int mid = text.IndexOf(">", first + 2);
            string beginning = text.Substring(0, first);
            string toBeReplaced = text.Substring(first, last - beginning.Length);
            string replacer = "[" + text.Substring(mid + 1, last - mid - 5) + "]" + "(" + text.Substring(first + 9, mid - beginning.Length - 10) + ")";
            text = text.Replace(toBeReplaced, replacer);

            int newStart = text.IndexOf('.', last);
            string text2 = text.Substring(newStart);
            first = text.IndexOf("<a");
            last = text.IndexOf("</a>") + 4;
            mid = text.IndexOf(">", first + 2);
            beginning = text.Substring(0, first);
            toBeReplaced = text.Substring(first, last - beginning.Length);
            replacer = "[" + text.Substring(mid + 1, last - mid - 5) + "]" + "(" + text.Substring(first + 9, mid - beginning.Length - 10) + ")";
            text = text.Replace(toBeReplaced, replacer);
            Console.WriteLine(text);
        }
    }
}
