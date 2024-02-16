using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Program
    {
        static void Main(string[] args)
        {
            // First constructor is called
            Person person1 = new Person("Alice");
            person1.PrintInfo(); // Output: Name: Alice, Age: 0

            // Second constructor is called
            Person person2 = new Person("Bob", 25);
            person2.PrintInfo(); // Output: Name: Bob, Age: 25

            Console.ReadLine();
        }
    }

    class Person
    {
        private string name;
        private int age;

        // Constructor with one parameter
        public Person(string name)
        {
            this.name = name;
            this.age = 0; // There is no age information initially, so it is assigned as 0.
        }

        // Constructor with two parameters
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }
}
