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
            int n, temp;
            n = 4;
            temp = n;
            int printable = 1;
            for (int i = 1; i <= n; i++)
            {
                printable = i;

                for (int j = 1; j < temp; j++)
                {
                    Console.Write(" ");
                }

                temp--;
                int innerLoppLimit = 2 * i - 1;
                for (int j = 1; j <= innerLoppLimit; j++)
                {
                    Console.Write(printable);

                    if (j < innerLoppLimit / 2 + 1)
                    {
                        printable--;
                    }
                    else
                    {
                        printable++;
                    }
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
