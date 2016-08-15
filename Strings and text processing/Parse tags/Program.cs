using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parse_tags
{
    class Program
    {
        static void Main()
        {
            string text =Console.ReadLine();
            int start = text.IndexOf("<upcase>");
            int end = text.IndexOf("</upcase>");
            
        }
    }
}