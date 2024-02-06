using Intro.Entities;
using System;

public class CourseManager
{
    Course[] courses = new Course[3];

    public CourseManager()
    {
        // Python Course
        Course pythonCourse = new Course() { Id = 1, Name = "Python Course", Description = "Python Programming for Beginners", Price = 0 };

        // Java Course
        Course javaCourse = new Course() { Id = 2, Name = "Java Course", Description = "Java Programming Essentials", Price = 0 };

        // JavaScript Course
        Course jsCourse = new Course() { Id = 3, Name = "JavaScript Course", Description = "Modern Web Development with JavaScript", Price = 0 };

        // Yeni kursları diziye atama
        courses[0] = pythonCourse;
        courses[1] = javaCourse;
        courses[2] = jsCourse;

        Console.WriteLine("Courses created.");
    }

    public Course[] GetAll()
    {
        return courses;
    }
}
