using Demo.DataAccess.Abstracts;
using Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAccess.Concretes
{
    public class CourseDal :ICourseDal
    {
        private List<Course> courses = new List<Course>();

        public void AddCourse(Course course)
        {
            Console.WriteLine("Kurs Eklendi");
            courses.Add(course);
        }

        public void UpdateCourse(Course course)
        {
            var courseToUpdate = courses.Find(c => c.Id == course.Id);
            if (courseToUpdate != null)
            {
                courseToUpdate.Name = course.Name;
                courseToUpdate.Description = course.Description;
                courseToUpdate.Price = course.Price;
                courseToUpdate.CategoryId = course.CategoryId;
                courseToUpdate.InstructorId = course.InstructorId;
            }
        }

        public void DeleteCourse(int id)
        {
            var courseToRemove = courses.Find(c => c.Id == id);
            if (courseToRemove != null)
            {
                courses.Remove(courseToRemove);
            }
        }

        public Course GetCourseById(int id)
        {
            return courses.Find(c => c.Id == id);
        }

        public List<Course> GetAllCourses()
        {
            return courses;
        }
    }
}
