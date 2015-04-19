using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_loops_in_class
{
    class Program
    {
        static void Main(string[] args)
        {
            pyramid p = new pyramid();
            p.n = 5;
            p.print();
            Console.WriteLine();
            p.print1();
            Console.WriteLine();
            p.print2();
            Console.WriteLine();
            p.print3();
            Console.ReadLine();
        }
    }
}
