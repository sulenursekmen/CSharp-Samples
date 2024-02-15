using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //Interface can not new
            //IPerson person= new Customer();

            InterfaceUsage();

            InterfaceUsage2();

            Console.ReadLine();
        }

        private static void InterfaceUsage()
        {
            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new OracleCustomerDal(),
                new SqlServerCustomerDal(),
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
        }

        private static void InterfaceUsage2()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            personManager.Add(new Customer { Id = 1, FirstName = "Şule Nur", LastName = "Sekmen", Address = "World" });
            personManager.Add(new Student { Id = 1, FirstName = "Şule Nur", LastName = "Sekmen", Department = "Software Development" });
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
