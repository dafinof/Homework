using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercizing
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "abba text kakvo lamal da be da";
            string[] array = text.Split(new char[] { ' ',',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length/2; j++)
                {
                    if (array[i][j]==array[i][array[i].Length-1-i])
                    {
                        Console.Write(array[i]);
                    }
                    else
                    {
                        break;
                    }
                    
                }
                
            }
        }
    }
}
