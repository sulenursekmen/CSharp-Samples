using Demo.Business;
using Demo.DataAccess.Concretes;
using Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    //Course, Category, Instructor
    //CRUD Operation
    public class Program
    {
        static void Main(string[] args)
        {
            // Dependency Injection ->  instance 
            CourseDal courseDal = new CourseDal();
            CategoryDal categoryDal = new CategoryDal();
            InstructorDal instructorDal = new InstructorDal();

            // Dependency Injection 
            CourseManager courseManager = new CourseManager(courseDal);
            CategoryManager categoryManager = new CategoryManager(categoryDal);
            InstructorManager instructorManager = new InstructorManager(instructorDal);

            // Category
            Category category1 = new Category { Id = 1, Name = "Programming" };
            Category category2 = new Category { Id = 2, Name = "Marketing" };

            Course course1 = new Course { Id = 1, Name = "C# Programming", Description = "Learn C# Programming", Price = 199.99m, CategoryId = 1, InstructorId = 1 };
            Course course2 = new Course { Id = 2, Name = "Social Media Marketing", Description = "Learn Social Media Marketing", Price = 299.99m, CategoryId = 2, InstructorId = 2 };
            Course course3 = new Course { Id = 3, Name = "Python Programming", Description = "Learn Python Programming", Price = 199.99m, CategoryId = 1, InstructorId = 1 };
            Course course4 = new Course { Id = 4, Name = "Email Marketing", Description = "Learn Email Marketing", Price = 199.99m, CategoryId = 2, InstructorId = 2 };
            Course course5 = new Course { Id = 5, Name = "JavaScript Programming", Description = "Learn JavaScript Programming", Price = 199.99m, CategoryId = 1, InstructorId = 1 };

            Instructor instructor1 = new Instructor { Id = 1, FirstName = "Engin", LastName = "Demiroğ", Image = "example.jpg" };
            Instructor instructor2 = new Instructor { Id = 2, FirstName = "Şule Nur", LastName = "Sekmen", Image = "example.jpg" };
            Instructor instructor3 = new Instructor { Id = 3, FirstName = "Sude", LastName = "Güneş", Image = "example.jpg" };

            // Category add
            categoryManager.AddCategory(category1);
            categoryManager.AddCategory(category2);

            // Course add
            courseManager.AddCourse(course1);
            courseManager.AddCourse(course2);
            courseManager.AddCourse(course3);
            courseManager.AddCourse(course4);
            courseManager.AddCourse(course5);

            // Instructor ekleme işlemi
            instructorManager.AddInstructor(instructor1);
            instructorManager.AddInstructor(instructor2);
            instructorManager.AddInstructor(instructor3);

            // Course Update
            course1.Name = "Updated C# Programming";
            courseManager.UpdateCourse(course1);

            // Category Delete
            categoryManager.DeleteCategory(category1.Id);

            // Instructor delete
            instructorManager.DeleteInstructor(instructor1.Id);
  
            // All Course List

            var allCourses = courseManager.GetAllCourses();
            Console.WriteLine("All Courses:");
            foreach (var course in allCourses)
            {
                Console.WriteLine($"Course ID: {course.Id}, Name: {course.Name}, Description: {course.Description}, Price: {course.Price}, Category ID: {course.CategoryId}, Instructor ID: {course.InstructorId}");
            }

            // All Category List 

            var allCategories = categoryManager.GetAllCategories();
            Console.WriteLine("All Categories:");
            foreach (var category in allCategories)
            {
                Console.WriteLine($"Category ID: {category.Id}, Name: {category.Name}");
            }

            // All Instructor List 
            var allInstructors = instructorManager.GetAllInstructors();
            Console.WriteLine("All Instructors:");
            foreach (var instructor in allInstructors)
            {
                Console.WriteLine($"Instructor ID: {instructor.Id}, Name: {instructor.FirstName} {instructor.LastName}, Image: {instructor.Image}");
            }

            Console.ReadLine();
        }
    }
}
