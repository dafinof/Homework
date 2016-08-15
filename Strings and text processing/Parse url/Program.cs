using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parse_url
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int protIndex = text.IndexOf("://");
            int resIndex = text.IndexOf("/", protIndex + 3);
            int com = text.IndexOf(".");

            Console.WriteLine("[protocol] = {0}", text.Remove(protIndex));
            Console.WriteLine("[server] = {0}", text.Substring(protIndex + 3, com - protIndex + 1));
            Console.WriteLine("[resource] = {0}", text.Substring(com + 1+3));
        }
    }
}
