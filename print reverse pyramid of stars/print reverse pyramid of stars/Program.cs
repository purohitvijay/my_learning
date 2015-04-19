using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;
            n = 5;
            for (i = n; i >= 1; i--)
            {
                for (j = n; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
