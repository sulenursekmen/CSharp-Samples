using System;

namespace Test
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