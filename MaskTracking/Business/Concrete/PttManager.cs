using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        //DependecnyInjection Kullanılır
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService) //Constructor newlendiginde calısır
        {
             _applicantService = applicantService;
        }

        public void GiveMask(Person person)
        {
           
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.Firstname + " için maske verildi");
            }
        }
    }


}
