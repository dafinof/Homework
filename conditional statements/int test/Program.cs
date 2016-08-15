using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace int_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            

            switch (a)
            {
                case "integer":
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine(b+1);
                    break;
                case "real":
                    double c = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F2}", c + 1);
                    break;
                case "text":
                    string d = Console.ReadLine();
                    Console.WriteLine(d + "*");
                    break;
            }
        }
    }
}
