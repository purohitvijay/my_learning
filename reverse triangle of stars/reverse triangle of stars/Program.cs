﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;
            n = 5;
            for (i = n; i >= 1; i--)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
