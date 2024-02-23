using Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAccess.Abstracts
{
    public interface IInstructorDal
    {
        void AddInstructor(Instructor instructor);
        void UpdateInstructor(Instructor instructor);
        void DeleteInstructor(int id);
        Instructor GetInstructorById(int id);
        List<Instructor> GetAllInstructors();
    }
}
