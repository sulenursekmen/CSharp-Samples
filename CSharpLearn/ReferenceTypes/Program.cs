using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example 1 --> int, decimal, float, enum, boolean value types (in stack)
            int number1 = 10;
            int number2 = 20;

            // When an assignment is made, number1 takes the value of number2.
            number1 = number2;

            // Even though the value of number2 is changed, number1 will still be 20.
            number2 = 100;

            Console.WriteLine("Number 1: " + number1); // Output: 20

            //Example 2 --> arrays, class, interface... reference types  (in heap)

            int[] ints = new int[] { 1, 2, 3 };
            int[] ints2 = new int[] { 10, 20, 30 };

            // When an assignment is made, ints takes the reference of ints2.
            ints = ints2;

            // Even if the first element of ints2 is changed, the first element of ints will also change.
            ints2[0] = 1000;

            Console.WriteLine("ints[0]: " + ints[0]); // Output: 1000

            // The Person class has three properties: Id, Firstname, and Lastname.
            Person person1 = new Person();
            Person person2 = new Person();

            person1.Firstname = "Şule";

            // When an assignment is made, person2 takes the reference of person1.
            person2 = person1;

            // When the Firstname property of person1 is changed, the Firstname property of person2 will also change.
            person1.Firstname = "Sude";

            Console.WriteLine("person2.Firstname: " + person2.Firstname); // Output: Sude

            // The Customer class inherits from the Person class and has an additional property called CreditCardNumber.
            Customer customer = new Customer();
            customer.Firstname = "Sıla";

            // The Employee class also inherits from the Person class and has an additional property called EmployeeNumber.
            Employee employee = new Employee();

            // A reference of type Person is assigned to a Customer object.
            Person person3 = customer;

            // The Firstname property of person3 points to the Firstname property of customer.
            Console.WriteLine("person3.Firstname: " + person3.Firstname); // Output: Sıla

            Console.ReadLine();
        }
    }

    // The Person class has three properties: Id, Firstname, and Lastname.
    class Person
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }

    // The Customer class inherits from the Person class and has an additional property called CreditCardNumber.
    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }

    // The Employee class also inherits from the Person class and has an additional property called EmployeeNumber.
    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }
}
