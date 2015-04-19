using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            Console.WriteLine("enter the value of n=");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {

                    Console.Write(x);
                    x++;

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
