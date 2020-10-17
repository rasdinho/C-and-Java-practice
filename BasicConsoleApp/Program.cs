using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Yones", 27);
            Person p2 = new Person("Azadi", 36);
            var a = "A string";
            var b = 10.5;
            var c = 5;
            var d = false;

            Console.WriteLine("Your name is: " + p.Name + " and your age is: " + p.Age);
           
        }
    }

    class Person
    {
        public int Age { get; set; }
        public String Name { get; set; }

        public Person(String name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
