﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_a_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            for (int i = n.Length-1; i >=0 ; i--)
            {
                Console.Write(n[i]);
            }
        }
    }
}
