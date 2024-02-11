using Intro.DataAccess.Abstracts;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.DataAccess.Concretes;

public class CourseDal:ICourseDal
{
    // ctor ile 
    List<Course> courses;
    public CourseDal()
    {
        // Python Course
        Course pythonCourse = new Course() { Id = 1, Name = "Python Course", Description = "Python Programming for Beginners", Price = 0 };

        // Java Course
        Course javaCourse = new Course() { Id = 2, Name = "Java Course", Description = "Java Programming Essentials", Price = 0 };

        // JavaScript Course
        Course jsCourse = new Course() { Id = 3, Name = "JavaScript Course", Description = "Modern Web Development with JavaScript", Price = 0 };

        // Yeni kursları diziye atama
        //courses[0] = pythonCourse;
        //courses[1] = javaCourse;
        //courses[2] = jsCourse;

        courses = new List<Course>() { pythonCourse, javaCourse, jsCourse };
    }
    public List<Course> GetAll()
    {
        return courses;
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }
}
