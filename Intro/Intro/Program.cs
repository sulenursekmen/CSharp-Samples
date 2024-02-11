// Program.cs: Ana program dosyası

using Intro.DataAccess.Concretes;
using Intro.Entities;
using System;

// Main method
class Program
{
    static void Main(string[] args)
    {
        // Hoşgeldin mesajı
        string welcomeMessage = "C# 'a yeniden merhaba";
        Console.WriteLine(welcomeMessage);

        // Kurs nesnelerinin oluşturulması ve değerlerinin atanması
        Course cSharpCourse = new Course() { Id = 1, Name = "C# Kursu", Description = ".NET 6 ile Modern C# Programlama", Price = 0 };
        Course flutterCourse = new Course() { Id = 2, Name = "Flutter Kursu", Description = "Mobil Uygulama Geliştirme", Price = 0 };
        Course htmlCourse = new Course() { Id = 3, Name = "HTML Kursu", Description = "Web Geliştirme Temelleri", Price = 0 };

        // Kursların bir dizi içine alınması
        Course[] courses = { cSharpCourse, flutterCourse, htmlCourse };

        // Kursların listelenmesi
        Console.WriteLine("----- Tüm Kurslar -----");
        foreach (Course course in courses)
        {
            Console.WriteLine(course.Name + " / " + course.Description);
        }

        // Kurs yöneticisinin oluşturulması
        CourseManager courseManager = new(new CourseDal());

        // Kursların yeniden alınması ve listelenmesi
        List<Course> coursesFromManager = courseManager.GetAll();
        Console.WriteLine("\n----- Tüm Kurslar (Yöneticiden) -----");
        foreach (Course course in coursesFromManager)
        {
            Console.WriteLine(course.Name + " / " + course.Description);
        }

        IndividualCustomer customer1 = new IndividualCustomer();
        customer1.Id = 1;
        customer1.NationalIdentity = "12345678910";
        customer1.Firstname = "Aslı";
        customer1.Lastname = "Karayiğit";
        customer1.CustomerNumber = "123456";

        IndividualCustomer customer2 = new IndividualCustomer();
        customer2.Id = 2;
        customer2.NationalIdentity = "123434534530";
        customer2.Firstname = "Özgür";
        customer2.Lastname = "Atılgan";
        customer2.CustomerNumber = "123457";


        CorporateCustomer customer3 = new CorporateCustomer();
        customer3.Id = 3;
        customer3.Name = "Kodlamaio";
        customer3.CustomerNumber = "345345";
        customer3.TaxNumber = "435346354654";

        CorporateCustomer customer4 = new CorporateCustomer();
        customer4.Id = 4;
        customer4.Name = "Sullens Code";
        customer4.CustomerNumber = "34345345";
        customer4.TaxNumber = "43530987456";

        int number1 = 10;
        int number2 = 20;
        number1 = number2;
        number2 = 50;
        Console.WriteLine(number1);

        //value types --> int,bool,double vb.

        string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
        string[] cities2 = { "Bursa", "Bolu", "Diyarbakır" };

        cities2 = cities1;
        cities1[0] = "Adana";
        Console.WriteLine(cities2[0]);

        //reference types --> array,class,interface... 

        BaseCustomer[] baseCustomer = {customer1,customer2,customer3,customer4 } ;

        // Polymorphism 
        foreach (BaseCustomer customer in baseCustomer)
        {
            //if (customer is IndividualCustomer)
            //{
            //   // ((IndividualCustomer)customer).Id;
            //}
            Console.WriteLine(customer.CustomerNumber);
        }
    }
}
