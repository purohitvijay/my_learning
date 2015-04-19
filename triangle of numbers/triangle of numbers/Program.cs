using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = i; j >= 1; j--)
                    Console.Write(j);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
