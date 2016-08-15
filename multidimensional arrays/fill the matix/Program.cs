using System;

namespace fill_the_matix
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            switch (c)
            {
                case 'a':
                    for (int row = 1, i = 1; i <= matrix.GetLength(0); row++, i++)
                    {
                        Console.Write(row);
                        for (int col = 1; col < matrix.GetLength(1); col++)
                        {
                            Console.Write(" {0}", row + 4);
                            row = row + 4;
                        }
                        Console.WriteLine();
                        row = i;
                    }break;
                case 'b':

                    break;
                default:
                    break;
            }
            
        }
    }
}
