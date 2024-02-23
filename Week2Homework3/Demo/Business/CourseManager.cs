using Demo.DataAccess.Abstracts;
using Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Business
{
    public class CourseManager : ICourseDal
    {
        private ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void AddCourse(Course course)
        {
            _courseDal.AddCourse(course);
        }

        public void UpdateCourse(Course course)
        {
            _courseDal.UpdateCourse(course);
        }

        public void DeleteCourse(int id)
        {
            _courseDal.DeleteCourse(id);
        }

        public Course GetCourseById(int id)
        {
            return _courseDal.GetCourseById(id);
        }

        public List<Course> GetAllCourses()
        {
            return _courseDal.GetAllCourses();
        }
    }

}
