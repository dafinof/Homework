using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_as_array
{
    class Program
    {
        static int[] SumOfArrays(int[] a, int[] b)
        {
            int[] c = new int[a.Length + b.Length];
            if (a.Length > b.Length)
            {
                c = new int[a.Length+1];
                for (int j = 0; j < a.Length; j++)
                {
                    c[j] = a[j];
                }
                for (int i = 0; i < b.Length; i++)
                {
                    c[i] = a[i] + b[i];
                    if (c[i] > 9)
                    {
                        a[i + 1] += 1;
                        c[i] -= 10;
                    }
                }
            }
            else
            {
                c = new int[b.Length+1];
                for (int j = 0; j < b.Length; j++)
                {
                    c[j] = b[j];
                }
                for (int i = 0; i < a.Length; i++)
                {
                    c[i] = a[i] + b[i];
                    if (c[i] > 9)
                    {
                        b[i + 1] += 1;
                        c[i] -= 10;
                    }
                }
            }
            return c;
        }
        static void Main(string[] args)
        {
            string[] arrayoflenghts = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] stringFirst = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] stringSecond = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] first = new int[stringFirst.Length];
            int[] second = new int[stringSecond.Length];
            for (int i = 0; i < stringFirst.Length; i++)
            {
                first[i] = int.Parse(stringFirst[i]);
            }
            for (int i = 0; i < stringSecond.Length; i++)
            {
                second[i] = int.Parse(stringSecond[i]);
            }
            int lenght = 0;
            if (stringFirst.Length > stringSecond.Length)
            {
                lenght = stringFirst.Length;
            }
            else
            {
                lenght = stringSecond.Length;
            }
            int[] c = new int[lenght+1];
            int[] answer = new int[c.Length - 1];
            c = SumOfArrays(first, second);
            if (c[c.Length-1]==0)
            {
                for (int i = 0; i <answer.Length; i++)
                {
                    answer[i] = c[i];
                    Console.WriteLine(answer[i]+" ");
                    return;
                }
            }
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i] + " ");
            }
        }
    }
}