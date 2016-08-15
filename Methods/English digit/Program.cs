using System;

namespace English_digit
{
    class Program
    {
        static string LastDigitAsAWord(int number)
        {
            switch (number%10)
            {

                case 0: Console.WriteLine("zero"); return "zero"; break;
                case 1: Console.WriteLine("one"); return "one"; break;
                case 2: Console.WriteLine("two"); return "two"; break;
                case 3: Console.WriteLine("three"); return "three"; break;
                case 4: Console.WriteLine("four"); return "four"; break;
                case 5: Console.WriteLine("five"); return "five"; break;
                case 6: Console.WriteLine("six"); return "six"; break;
                case 7: Console.WriteLine("seven"); return "seven"; break;
                case 8: Console.WriteLine("eight"); return "eight"; break;
                case 9: Console.WriteLine("nine"); return "nine"; break;
                default:
                    return "0";
                    break; 
            }
        }
        static void Main()
        {
            string word = LastDigitAsAWord(int.Parse(Console.ReadLine()));
            
        }
    }
}
