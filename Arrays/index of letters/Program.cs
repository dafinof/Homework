using System;
namespace index_of_letters
{
    class Program
    {
        static void Main()
        {
            string n = Console.ReadLine();
            char[] duma = n.ToCharArray();
            for (int i=0;i<duma.Length;i++)
            {
                switch (duma[i])
                {
                    case 'a': Console.WriteLine(0);continue;
                    case 'b': Console.WriteLine("1"); continue;
                    case 'c': Console.WriteLine(2); continue;
                    case 'd': Console.WriteLine(3); continue;
                    case 'e': Console.WriteLine(4); continue;
                    case 'f': Console.WriteLine(5); continue;
                    case 'g': Console.WriteLine(6); continue;
                    case 'h': Console.WriteLine(7); continue;
                    case 'i': Console.WriteLine(8); continue;
                    case 'j': Console.WriteLine(9); continue;
                    case 'k': Console.WriteLine(10); continue;
                    case 'l': Console.WriteLine(11); continue;
                    case 'm': Console.WriteLine(12); continue;
                    case 'n': Console.WriteLine(13); continue;
                    case 'o': Console.WriteLine(14); continue;
                    case 'p': Console.WriteLine(15); continue;
                    case 'q': Console.WriteLine(16); continue;
                    case 'r': Console.WriteLine(17); continue;
                    case 's': Console.WriteLine(18); continue;
                    case 't': Console.WriteLine(19); continue;
                    case 'u': Console.WriteLine(20); continue;
                    case 'v': Console.WriteLine(21); continue;
                    case 'w': Console.WriteLine(22); continue;
                    case 'x': Console.WriteLine(23); continue;
                    case 'y': Console.WriteLine(24); continue;
                    case 'z': Console.WriteLine(25); continue;
                    
                    default:
                        break;
                }
            }
        }
    }
}
