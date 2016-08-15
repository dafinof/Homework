using System;


namespace bonus
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());

            if (a >= 10 || a<=0)
            {
                Console.WriteLine("invalid score");
            }
            

            else if (a >= 1 && a < 4)
            {
                a *= 10;
                Console.WriteLine(a);
            }
            else if (a > 3 && a < 7)
            {
                a *= 100;
                Console.WriteLine(a);
            }
            else if (a > 6 && a <= 9)
            {
                a *= 1000;
                Console.WriteLine(a);
            }
        }
    }
}
