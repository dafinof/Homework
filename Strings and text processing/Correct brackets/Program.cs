using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correct_brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            List<int> index1 = new List<int>();
            List<int> index2 = new List<int>();
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] == '(')
                {
                    index1.Add(1);
                }
                if (n[i] == ')')
                {
                    index2.Add(1);
                }
            }
            if (n.IndexOf(")") < n.IndexOf("("))
            {
                Console.WriteLine("Incorrect");
                return;
            }
            else if (index1.Count != index2.Count)
            {
                Console.WriteLine("Incorrect");
                return;
            }
            Console.WriteLine("Correct");
        }
    }
}
