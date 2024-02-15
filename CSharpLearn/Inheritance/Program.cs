using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer();
            //customer.Id= 1;

            Person[] people = new Person[3]
            {
                new Customer{Name="A" },
                new Student{Name="B" },
                new Person{Name="C" }
            };

            foreach (var item in people)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadLine();

        }
        //Inheritance is taken only once
        class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }
        }

        class Customer:Person
        {
            public int CustomerID { get; set; }
        }

        class Student : Person
        {
            public int StudentID { get; set; }
        }
    }
}
