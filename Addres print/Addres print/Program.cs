using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addres_print
{
    class Program
    {
        static void Main(string[] args)
        {
            addreses add = new addreses();
            add.addres1 = "c/120";
            add.addres2 = "modiline";
            add.addres3 = "jaipur";
            add.addres4 = "rajasthan";
            add.addres5 = "302001";

           
            add.print();
            Console.WriteLine(add.addres6);
            Console.ReadLine();
        }
    }
   public class addreses
    {
       public string addres1;
       public string addres2;
       public string addres3;
       public string addres4;
       public string addres5;
       public string addres6;
       public void print()
       {
           Console.WriteLine(addres1);
           Console.WriteLine(addres2);
           Console.WriteLine(addres3);
           Console.WriteLine(addres4);
           Console.WriteLine(addres5);
           Console.WriteLine(addres6);
       }
    }
}
