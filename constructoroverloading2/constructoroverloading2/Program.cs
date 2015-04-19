using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructoroverloading2
{
    class Program
    {
        static void Main(string[] args)
        {
            costructoroverloading obj1 = new costructoroverloading(10);
            Console.WriteLine("member value of obj1 :-");
            obj1.displaydata();
            costructoroverloading obj2 = new costructoroverloading(10,20);
            Console.WriteLine("member value of obj2 :-");
            obj2.displaydata();
            costructoroverloading obj3 = new costructoroverloading(10,20,"valid string entered");
            Console.WriteLine("member value of obj3 :-");
            obj3.displaydata();
            Console.Read();
        }
    }
    class costructoroverloading
    {
        int a, b;
        string c;
        public costructoroverloading(int x)
        {
            a = x;
            b = 0;
            c = "no valid string";
        }
        public costructoroverloading(int x,int y)
        {
            a = x;
            b = y;
            c = "no valid string";
        }
        public costructoroverloading(int x, int y,string z)
        {
            a = x;
            b = y;
            c = z;
        }
        public void displaydata()
        {
            Console.WriteLine("a =" + a);
            Console.WriteLine("b =" + b);
            Console.WriteLine("c =" + c);
        }
    }
}
