using Demo.DataAccess.Abstracts;
using Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAccess.Concretes
{
    public class InstructorDal :IInstructorDal
    {
        private List<Instructor> instructors = new List<Instructor>();

        public void AddInstructor(Instructor instructor)
        {
            instructors.Add(instructor);
            Console.WriteLine("Eğitmen Eklendi");
        }

        public void UpdateInstructor(Instructor instructor)
        {
            var instructorToUpdate = instructors.Find(i => i.Id == instructor.Id);
            if (instructorToUpdate != null)
            {
                instructorToUpdate.FirstName = instructor.FirstName;
                instructorToUpdate.LastName = instructor.LastName;
                instructorToUpdate.Image = instructor.Image;
            }
            Console.WriteLine("Eğitmen Güncellendi");
        }

        public void DeleteInstructor(int id)
        {
            var instructorToRemove = instructors.Find(i => i.Id == id);
            if (instructorToRemove != null)
            {
                instructors.Remove(instructorToRemove);
            }
            Console.WriteLine("Eğitmen Silindi");
        }

        public Instructor GetInstructorById(int id)
        {
            Console.WriteLine("Eğitmen Listesi id'ye göre getirildi");
            return instructors.Find(i => i.Id == id);
           
        }

        public List<Instructor> GetAllInstructors()
        {
            Console.WriteLine("Tüm Eğitmen Listesi getirildi");
            return instructors;
        }
    }
}
