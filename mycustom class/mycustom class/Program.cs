using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mycustom_class
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

    }

    class Program
    {
        static void Main()
        {
            Person person1 = new Person("vijay", 6);
            Console.WriteLine("person1 Name = {0} Age = {1}", person1.Name, person1.Age); 
            Person person2 = person1; 
            person2.Name = "dixit";
            person2.Age = 16;
            Console.WriteLine("person2 Name = {0} Age = {1}", person2.Name, person2.Age);
            Console.WriteLine("person1 Name = {0} Age = {1}", person1.Name, person1.Age);
            Console.ReadKey();

        }
    }
}