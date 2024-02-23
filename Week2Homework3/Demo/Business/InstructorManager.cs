using Demo.DataAccess.Abstracts;
using Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Business
{
    public class InstructorManager : IInstructorDal
    {
        private IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public void AddInstructor(Instructor instructor)
        {
            _instructorDal.AddInstructor(instructor);
        }

        public void UpdateInstructor(Instructor instructor)
        {
            _instructorDal.UpdateInstructor(instructor);
        }

        public void DeleteInstructor(int id)
        {
            _instructorDal.DeleteInstructor(id);
        }

        public Instructor GetInstructorById(int id)
        {
            return _instructorDal.GetInstructorById(id);
        }

        public List<Instructor> GetAllInstructors()
        {
            return _instructorDal.GetAllInstructors();
        }
    }
}
