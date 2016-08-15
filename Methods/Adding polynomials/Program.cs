using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adding_polynomials
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] a = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] b = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] first = new int[n];
            int[] second = new int[n];
            for (int i = 0; i < n; i++)
            {
                first[i] = int.Parse(a[i]);
                second[i] = int.Parse(b[i]);
            }
            int[] sum = new int[n];
            sum = SumOfCoeficientsOfPolinoms(first, second);
            for (int i = 0; i < n; i++)
            {
                Console.Write(sum[i]+" ");
            }
        }
        static int[] SumOfCoeficientsOfPolinoms(int[] a, int[] b)
        {
            int[] sum = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                sum[i] = a[i] + b[i];
            }
            return sum;
        }
    }
}
