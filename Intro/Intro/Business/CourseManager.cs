using Intro.DataAccess.Abstracts;
using Intro.DataAccess.Concretes;
using Intro.Entities;
using System;

public class CourseManager
{
    //dependency injection
    private ICourseDal _courseDal;

    // ctrl . bas constructor olustur
    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public CourseManager()
    {
        Console.WriteLine("Courses created.");
    }

    public List<Course> GetAll()
    {
        // business rules
      //  CourseDal courseDal = new CourseDal();
        // newlemek yanlıs


        return _courseDal.GetAll();
    }
}
