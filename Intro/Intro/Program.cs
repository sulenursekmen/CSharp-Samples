// Program.cs: Ana program dosyası

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
        CourseManager courseManager = new CourseManager();

        // Kursların yeniden alınması ve listelenmesi
        Course[] coursesFromManager = courseManager.GetAll();
        Console.WriteLine("\n----- Tüm Kurslar (Yöneticiden) -----");
        foreach (Course course in coursesFromManager)
        {
            Console.WriteLine(course.Name + " / " + course.Description);
        }
    }
}
